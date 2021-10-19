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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplicationService _application;

        public UsuarioController(IUsuarioApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(UsuarioCreateModel model)
        {
            try
            {
                _application.Create(model);

                return Ok(new
                {
                    Message = "Ususario cadastrado com sucesso"
                });

            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpPut]
        public IActionResult Update(UsuarioUpdateModel model)
        {
            try
            {
                _application.Update(model);

                return Ok(new
                {
                    Message = "Usuario atualizado com sucesso"
                });

            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {            
            try
            {
                var model = new UsuarioDeleteModel { Id = id };
                _application.Delete(model);

                return Ok(new
                {
                    Message = "Usuario removido com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_application.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_application.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
