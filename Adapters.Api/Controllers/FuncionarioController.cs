using Clinica.Application.Interfaces;
using Clinica.Application.Models.Funcionario;
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
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioApplicationService _application;

        public FuncionarioController(IFuncionarioApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(FuncionarioCreateModel model)
        {
            try
            {
                _application.Create(model);
                return Ok(new
                {
                    Message = "Funcionario cadastrado com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(FuncionarioUpdateModel model)
        {
            try
            {
                _application.Update(model);
                return Ok(new
                {
                    Message = "Funcionario atulizado com sucesso"
                });
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var funcionario = new FuncionarioDeleteModel { IdFuncionario = id };
                _application.Delete(funcionario);

                return Ok(new
                {
                    Message = "Funcionario removido com sucesso"
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
