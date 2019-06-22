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
    public class TipoComprobantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<TipoComprobante> db = new Repositorio<TipoComprobante> ();
            bool paso = false;
            TipoComprobante tc = new TipoComprobante();

            tc.IdTipoComprobante = 2;
            tc.NombreComprobante = "fiscal";

            paso = db.Guardar(tc);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<TipoComprobante> repositorio = new Repositorio<TipoComprobante>();
            bool paso = false;
            TipoComprobante tc = repositorio.Buscar(2);

            tc.NombreComprobante = "daa";

            paso = repositorio.Modificar(tc);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<TipoComprobante> db = new Repositorio<TipoComprobante>();
            Assert.IsNotNull(db.Buscar(2));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<TipoComprobante> db = new Repositorio<TipoComprobante>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<TipoComprobante> db = new Repositorio<TipoComprobante>();
            Assert.IsTrue(db.Eliminar(2));

        }
    }
}