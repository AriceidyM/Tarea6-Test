using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            IdUsuario = 0;
            IdEmpleado = 0;
            Nombre = string.Empty;
            Clave = string.Empty;

        }
    }
}
