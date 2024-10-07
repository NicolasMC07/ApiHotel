using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Config;
using ApiHotel.Data;
using ApiHotel.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiHotel.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Utilities _utilities;


        public AuthController(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        [HttpPost("login")]
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