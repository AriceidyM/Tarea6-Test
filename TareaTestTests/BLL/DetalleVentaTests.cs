using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.Entidades;

namespace TareaTest.BLL.Tests
{
    [TestClass()]
    public class DetalleVentaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleVenta> db = new Repositorio<DetalleVenta>();
            bool paso = false;
            DetalleVenta d = new DetalleVenta();

            d.IdDetalleventa = 3;
            d.IdVenta = 1;
            d.Idproducto = 1;
            d.Unidades = 1;
            d.Costounidad = 123;
            d.Descuentounidad = 10;
            d.Total = 113;
            

            paso = db.Guardar(d);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool paso = false;
            DetalleVenta d = repositorio.Buscar(3);
            d.Unidades = 2;
            d.Total = 468;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<DetalleVenta> db = new Repositorio<DetalleVenta>();
            Assert.IsNotNull(db.Buscar(3));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<DetalleVenta> db = new Repositorio<DetalleVenta>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<DetalleVenta> db = new Repositorio<DetalleVenta>();
            Assert.IsTrue(db.Eliminar(3));

        }
    }
}