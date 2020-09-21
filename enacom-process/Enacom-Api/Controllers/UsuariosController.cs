using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enacom_Api.Entity;
using Enacom_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enacom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        UsuariosServices usuariosServices = new UsuariosServices();

        [HttpGet]
        public List<Usuarios> getUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = this.usuariosServices.getUsuarios();


            return usuarios;
        }
    }
}
