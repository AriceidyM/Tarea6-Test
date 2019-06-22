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
    public class UnidadMedidaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<UnidadMedida> db = new Repositorio<UnidadMedida> ();
            bool paso = false;
            UnidadMedida um = new UnidadMedida();

            um.Idunidadmedida = 1;
            um.Nombreunidad = "yes";

            paso = db.Guardar(um);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            bool paso = false;
            UnidadMedida um = repositorio.Buscar(1);
            um.Nombreunidad = "sksjs";

            paso = repositorio.Modificar(um);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<UnidadMedida> db = new Repositorio<UnidadMedida>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<UnidadMedida> db = new Repositorio<UnidadMedida>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<UnidadMedida> db = new Repositorio<UnidadMedida>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}