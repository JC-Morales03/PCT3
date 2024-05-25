using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCT3.Integration;
using PCT3.Integration.dto;

namespace PCT3.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly ListarUsuariosApiIntegration _listUsers;
        private readonly ListarAUsuarioApiIntegration _unUser;

        public UsuarioController(ILogger<UsuarioController> logger,
        ListarUsuariosApiIntegration listusers, ListarAUsuarioApiIntegration aUser)
        {
            _logger = logger;
            _listUsers = listusers;
            _unUser = aUser;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Usuario> users = await _listUsers.GetUser();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Perfil(int Id)
        {
            Usuario user = await _unUser.GetUser(Id);
            return View(user);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}