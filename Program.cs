using System.Text;
using ApiHotel.Config;
using ApiHotel.Data;
using ApiHotel.Repositories;
using ApiHotel.Services;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;


// Load environment variables from .env file
Env.Load();

// Configure database connection using environment variables
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

// Build the connection string for MySQL
var connectionDB = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";


var builder = WebApplication.CreateBuilder(args);

// Add DbContext with MySQL configuration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionDB, ServerVersion.Parse("8.0.20-mysql")));

// Register utility services for encryption and token generation
builder.Services.AddSingleton<Utilities>();

// Configure authentication using JWT Bearer
builder.Services.AddAuthentication(config =>
{
    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config =>
{
    config.RequireHttpsMetadata = false; // Set to true in production
    config.SaveToken = true; // Save the token in the AuthenticationProperties
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER"),
        ValidateAudience = false, // Audience validation can be enabled if needed
        ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
        ValidateLifetime = true, // Validate the token lifetime
        ClockSkew = TimeSpan.Zero, // No delay before token expiration
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY")!))
    };
});

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .WithOrigins("http://127.0.0.1:5500")
            .AllowAnyOrigin()  // Permitir solicitudes desde cualquier origen
            .AllowAnyMethod()  // Permitir cualquier método HTTP (GET, POST, PUT, DELETE, etc.)
            .AllowAnyHeader(); // Permitir cualquier encabezado
    });
});

// Add services for controllers
builder.Services.AddControllers();

// Register repositories with dependency injection
builder.Services.AddScoped<IBookingRepository, BookingServices>();
builder.Services.AddScoped<IGuestRepository, GuestServices>();
builder.Services.AddScoped<IRoomRepository, RoomServices>();
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeServices>();

// Add API documentation and Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Hotel", Version = "v1" });
    
    // Configure security definition for JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    // Add security requirement for the API
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddSwaggerGen(c =>    
{    
   c.EnableAnnotations();    
});  

var app = builder.Build(); // Build the application

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger in development mode
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Hotel v1"); // Specify the endpoint for Swagger UI
        c.RoutePrefix = string.Empty; // Serve the Swagger UI at the app's root
    });
}

// Usar CORS
app.UseCors("AllowAll");

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS

app.UseAuthentication();

app.UseAuthorization(); // Enable authorization middleware

// Optional welcome page
app.UseWelcomePage(new WelcomePageOptions
{
    Path = "/"
});

// Map controller routes
app.MapControllers();

app.Run(); // Run the application
