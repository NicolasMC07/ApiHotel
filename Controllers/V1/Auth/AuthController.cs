using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Config;
using ApiHotel.Data;
using ApiHotel.DTOs;
using ApiHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiHotel.Controllers.V1.Auth
{
    [ApiController]
    [Route("/api/v1/auth")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Utilities _utilities;


        public AuthController(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        [HttpPost("/api/v1/auth/register")]
        public async Task<IActionResult> Register(Employe employe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Employes.Any(u => u.Email == employe.Email))
            {
                return BadRequest("Email already exists");
            }

            employe.Password = _utilities.EncryptSHA256(employe.Password);

            _context.Employes.Add(employe);
            await _context.SaveChangesAsync();
            return Ok("User registered successfully");
        }

        [HttpPost("/api/v1/auth/login")]
        public async Task<IActionResult> Login(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Employe = await _context.Employes.FirstOrDefaultAsync(u => u.Email == employeeDto.Email);
            if (Employe == null)
            {
                return Unauthorized("Email ivalido");
            }

            var passwordIsValid = Employe.Password == _utilities.EncryptSHA256(employeeDto.Password);

            if (passwordIsValid == false)
            {
                return Unauthorized("Contraseña invalida");
            }

            var token = _utilities.GenerateJwtToken(Employe);
            return Ok(new
            {
                message = "Por favor guarde este token: ",
                jwt = token
            });
        }
    }
}