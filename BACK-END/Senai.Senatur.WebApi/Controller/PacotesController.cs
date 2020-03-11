using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controller
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {

        private IPacotesRepository _pacotesRepository { get; set; }

        public PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                var pacotes = _pacotesRepository.Listar();

                return Ok(pacotes);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {
            var pacotes = _pacotesRepository.BuscarPorId(id);
            if (pacotes != null)
            {
                return Ok(pacotes);
            }

            return NotFound("Nunhum pacote encontrado com esse id");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Pacotes novoPacotes)
        {
            _pacotesRepository.Cadastrar(novoPacotes);
            return StatusCode(201);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(Pacotes pacotesAtualizado, int id)
        {
            var pacote = _pacotesRepository.BuscarPorId(id);

            if(pacote == null)
            {
                return NotFound("Pacote Inexistente");
            }

            _pacotesRepository.Atualizar(pacotesAtualizado,id);
            return StatusCode(200);
        }
    }
}