using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controller
{
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuariosRepository { get; set; }


        public UsuariosController()
        {
            _usuariosRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuariosRepository.Listar());
        }
    }
}