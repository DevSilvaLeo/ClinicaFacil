using Clinica.Application.Interfaces;
using Clinica.Application.Models.Medico;
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
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoApplicationService _application;

        public MedicoController(IMedicoApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(MedicoCreateModel model)
        {
            try
            {
                _application.Create(model);
                return Ok(new
                {
                    Message = "Medico/Terapeuta cadastrado com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(MedicoUpdateModel model)
        {
            try
            {
                _application.Update(model);
                return Ok(new
                {
                    Message = "Medico/Terapeuta atualizado com sucesso"
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
                var medico = new MedicoDeleteModel { Id = id };
                _application.Delete(medico);
                return Ok(new
                {
                    Message = "Medico/Terapeuta removido com sucesso"
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
            catch(Exception e)
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
