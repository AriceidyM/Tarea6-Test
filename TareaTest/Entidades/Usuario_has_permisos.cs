using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuario_has_permisos
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public Usuario_has_permisos()
        {
            IdUsuario = 0;
            IdPermiso = 0;

        }
    }
}
