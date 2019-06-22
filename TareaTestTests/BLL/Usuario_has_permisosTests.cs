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
    public class Usuario_has_permisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Usuario_has_permisos> db = new Repositorio<Usuario_has_permisos> ();
            bool paso = false;
            Usuario_has_permisos u = new Usuario_has_permisos();

            u.IdUsuario = 1;
            u.IdPermiso = 1;

            paso = db.Guardar(u);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Usuario_has_permisos> repositorio = new Repositorio<Usuario_has_permisos>();
            bool paso = false;
            Usuario_has_permisos u = repositorio.Buscar(1);

            u.IdPermiso = 2;
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Usuario_has_permisos> db = new Repositorio<Usuario_has_permisos>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Usuario_has_permisos> db = new Repositorio<Usuario_has_permisos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Usuario_has_permisos> db = new Repositorio<Usuario_has_permisos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}