using DesafioDevAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DesafioDevAPI.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (loginModel.Login == "admin" && loginModel.Password == "admin")
            {
                var token = GerarTokenJWT();
                return Ok(new { token });
            }
            return BadRequest(new {mensagem = "Credenciais inválidas. Por favor, verifique seu nome de usuário e senha."});
        }

        private string GerarTokenJWT() 
        {
            string secretKey = "3dc7753a-95ee-4c88-a31c-ff73ab066eba";

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credential = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("login","admin"),
                new Claim("nome","Administrador do Sistema")
            };

            var token = new JwtSecurityToken(
                issuer: "sua_empresa",
                audience: "sua_aplicacao",
                claims: claims,
                expires:DateTime.Now.AddHours(1),
                signingCredentials: credential
             );
            
            return new JwtSecurityTokenHandler().WriteToken(token);
            
        }
    }
}
