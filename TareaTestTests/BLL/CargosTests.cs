﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class CargosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Cargos> db = new Repositorio<Cargos>();
            Cargos cargos = new Cargos();

            cargos.IdCargo = 2;
            cargos.NombreCargo = "Gerente";
            cargos.IdEstado = 1;

            bool paso = false;

            paso = db.Guardar(cargos);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cargos> repositorio = new Repositorio<Cargos>();
            bool paso = false;
            Cargos c = repositorio.Buscar(2);
            c.NombreCargo = "Administrador";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Cargos> db = new Repositorio<Cargos>();
            Assert.IsNotNull(db.Buscar(2));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Cargos> db = new Repositorio<Cargos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Cargos> db = new Repositorio<Cargos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}