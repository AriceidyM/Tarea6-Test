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
    public class TipoPersonaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<TipoPersona> db = new Repositorio<TipoPersona> ();
            bool paso = false;
            TipoPersona tp = new TipoPersona();

            tp.IdTipoPersona = 1;
            tp.Nombre = "Maria";
            
            paso = db.Guardar(tp);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
            bool paso = false;
            TipoPersona tp = repositorio.Buscar(1);
            tp.Nombre = "Juana";

            paso = repositorio.Modificar(tp);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<TipoPersona> db = new Repositorio<TipoPersona>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<TipoPersona> db = new Repositorio<TipoPersona>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<TipoPersona> db = new Repositorio<TipoPersona>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}