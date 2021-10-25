using Adapters.Authentication.Security;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Usuario;
using Clinica.Application.Security.Interfaces;
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
        private readonly ICriptoService _cripto;

        public AutenticacaoController(IUsuarioApplicationService application, JwtToken token, ICriptoService cripto)
        {
            _application = application;
            _token = token;
            _cripto = cripto;
        }
        
        [HttpPost]
        public IActionResult Post(UsuarioAuthenticationModel model)
        {            
            var usuario = _application.GetByLoginSenha(model.Email, _cripto.Ecrypt(model.Senha));
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
