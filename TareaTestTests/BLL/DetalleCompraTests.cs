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
    public class DetalleCompraTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleCompra> db = new Repositorio<DetalleCompra>();
            bool paso = false;
            DetalleCompra d = new DetalleCompra();

            d.IdDetalleCompra = 1;
            d.IdCompra = 1;
            d.IdProducto = 1;
            d.Unidades = 1;
            d.CostoUnidad = 234;
            d.Total = 234;

            paso = db.Guardar(d);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            bool paso = false;
            DetalleCompra d = repositorio.Buscar(1);
            d.Unidades = 2;
            d.Total = 468;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<DetalleCompra> db = new Repositorio<DetalleCompra>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<DetalleCompra> db = new Repositorio<DetalleCompra>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<DetalleCompra> db = new Repositorio<DetalleCompra>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}