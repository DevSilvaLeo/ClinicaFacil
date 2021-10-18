using Clinica.Application.Interfaces;
using Clinica.Application.Models.Cargo;
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
    public class CargoController : ControllerBase
    {
        private readonly ICargoApplicationService _application;

        public CargoController(ICargoApplicationService application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(CargoCreateModel model)
        {
            try
            {
                _application.Create(model);
                return Ok(new
                {
                    Message = "Cargo cadastrado com sucesso."
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpPut]
        public IActionResult Update(CargoUpdateModel model)
        {
            _application.Update(model);

            return Ok(new
            {
                Message = "Cargo atualizado com sucesso"
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var model = new CargoDeleteModel { IdCargo = id };
                _application.Delete(model);

                return Ok(new
                {
                    Message = "Cargo removido com sucesso"
                });
            }
            catch (Exception e)
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
