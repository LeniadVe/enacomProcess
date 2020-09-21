using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enacom_Api.Entity
{
    public class Noticias
    {
        /*
         * id
         * destinatario 
         * titulo
         * descripcion (resumen)
         * URL
         * imagen (quien lo manda, enacom, afip, etc)
         */

        public Guid id { get; set; }
        public string destinatario { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
        public string  imagen { get; set; }


    }
}
