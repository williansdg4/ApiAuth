using ApiAuth.Contracts;
using ApiAuth.Models;
using ApiAuth.Repository;
using ApiAuth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [Route("v1")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IUser _user;

        public LoginController(IUser user)
        {
            _user = user;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            //Recupera o usuário
            var user = _user.Get(model.Username, model.Password);

            //Verifica se o usuário existe
            if(user == null)
            {
                return NotFound(new {message = "Usuário e/ou senha inválidos"});
            }

            //Gera token
            var token = TokenServices.GenerateToken(user);

            user.Password = "";
            //Retorna os dados
            return new
            {
                user,
                token
            };
        }
    }
}
