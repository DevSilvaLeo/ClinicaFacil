using Clinica.Application.Models;
using Clinica.Application.Services;
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
        private readonly MedicoApplicationService _application;

        public MedicoController(MedicoApplicationService application)
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
    }
}
