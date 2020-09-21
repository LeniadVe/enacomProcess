using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enacom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {

        [HttpGet]
        [Route("obtenerNoticias")]
        public void GetNoticias()
        {

        }

        [HttpGet]
        [Route("obtenerNoticia")]
        public void GetNoticia()
        {

        }

        [HttpPost]
        [Route("insertarNoticia")]
        public void SetNotcia()
        {

        }

        [HttpPut]
        [Route("modificarNoticia")]
        public void UpdateNoticia()
        {

        }

        [HttpDelete]
        [Route("borrarNoticia")]
        public void DeleteNoticia()
        {

        }

    }
}
