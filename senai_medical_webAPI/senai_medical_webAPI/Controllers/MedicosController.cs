﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_medical_webAPI.Interfaces;
using senai_medical_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_medical_webAPI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    //http://localhost:5000/api/medicos

    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository _medicoRepository;

        public MedicosController()
        {
            _medicoRepository = new MedicoRepository();
        }


        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.Listar());
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);
            }
        }
    }
}
