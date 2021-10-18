using Clinica.Application.Interfaces;
using Clinica.Application.Models.Especialidade;
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
    public class EspecialidadeController : ControllerBase
    {
        private readonly IEspecialidadeApplicationService _application;

        public EspecialidadeController(IEspecialidadeApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(EspecialidadeCreateModel model)
        {
            try
            {
                _application.Create(model);

                return Ok(new
                {
                    Message = "Especialidade cadastrada com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpPut]
        public IActionResult Put(EspecialidadeUpdateModel model)
        {
            try
            {
                _application.Update(model);

                return Ok(new
                {
                    Message = "Especialidade atualizada com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var model = new EspecialidadeDeleteModel { Id = id };
                _application.Delete(model);

                return Ok(new {
                    Message = "Especialidade removida com sucesso"
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
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
