using Clinica.Application.Interfaces;
using Clinica.Application.Models.Procedimento;
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
    public class ProcedimentoController : ControllerBase
    {
        private readonly IProcedimentoApplicationService _application;

        public ProcedimentoController(IProcedimentoApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(ProcedimentoCreateModel model)
        {
            try
            {
                _application.Create(model);
                return Ok(new
                {
                    Message = "Procedimento cadastrado com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(ProcedimentoUpdateModel model)
        {
            try
            {
                _application.Update(model);
                return Ok(new
                {
                    Message = "Procedimento atualizado com sucesso"
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var procedimento = new ProcedimentoDeleteModel { IdProcedimento = id };
                _application.Delete(procedimento);

                return Ok(new
                {
                    Message = "Procedimento removido com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
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
                return StatusCode(500, e.Message);
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
                return StatusCode(500, e.Message);
            }
        }
    }
}
