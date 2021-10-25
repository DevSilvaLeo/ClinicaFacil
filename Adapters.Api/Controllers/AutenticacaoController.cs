using Adapters.Authentication.Security;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapters.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioApplicationService _application;
        private readonly JwtToken _token;

        public AutenticacaoController(IUsuarioApplicationService application, JwtToken token)
        {
            _application = application;
            _token = token;
        }
        
        [HttpPost]
        public IActionResult Post(UsuarioAuthenticationModel model)
        {
            var usuario = _application.GetByLoginSenha(model.Email, model.Senha);
            //if (usuario.Login.Equals(model.Email) && usuario.Senha.Equals(model.Senha))
            if(usuario != null)
            {
                try
                {
                    var token = _token.GenerateToken(usuario);
                    return Ok(new { 
                        Message = "Usuário autenticado",
                        Token = token
                    });
                }
                catch(Exception e)
                {
                    return StatusCode(500, new { e.Message });
                }

            }
            else
            {
                return BadRequest("Usuaário ou Senha inválidos");
            }
        }
        
    }
}
