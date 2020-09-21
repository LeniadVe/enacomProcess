using Enacom_Api.Data;
using Enacom_Api.Entity;
using Enacom_Api.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enacom_Api.Services
{
    public class UsuariosServices
    {
        UsuariosValidation usuariosValidation = new UsuariosValidation();
        UsuariosData usuariosData = new UsuariosData();

        public List<Usuarios> getUsuarios ()
        {
            List<Usuarios> usuarios = new List<Usuarios>();


            return usuarios;
        }
    }
}
