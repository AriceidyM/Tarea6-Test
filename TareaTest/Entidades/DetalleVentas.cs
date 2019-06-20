using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class DetalleVenta
    {
        [Key]
        public int IdDetalleventa { get; set; }
        public int IdVenta { get; set; }
        public int Idproducto { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double Descuentounidad { get; set; }
        public double Total { get; set; }

        public DetalleVenta()
        {
            IdDetalleventa = 0;
            IdVenta = 0;
            Idproducto = 0;
            Unidades = 0;
            Costounidad = 0;
            Descuentounidad = 0;
            Total = 0;

        }
    }
}
