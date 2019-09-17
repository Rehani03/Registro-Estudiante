using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro1.BLL;
using Registro1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro1.BLL.Tests
{
    [TestClass()]
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiante e = new Estudiante();
            e.EstudianteID = 0;
            e.Matricula = "2017-8963";
            e.Nombres = "Pablo";
            e.Apellidos = "Jimenez";
            e.Cedula = "402-2555003-3";
            e.Telefono = "829-869-9325";
            e.Celular = "829-789-3696";
            e.Email = "pablo@gamil.com";
            e.FechaNacimiento = DateTime.Now;
            e.Sexo = 1;
            paso = EstudianteBLL.Guardar(e);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiante e = new Estudiante();
            e.EstudianteID = 1;
            e.Matricula = "2017-8963";
            e.Nombres = "Pablo";
            e.Apellidos = "Jimenez";
            e.Cedula = "402-2555003-3";
            e.Telefono = "829-869-9325";
            e.Celular = "829-789-3696";
            e.Email = "pablo@gamil.com";
            e.FechaNacimiento = DateTime.Now;
            e.Sexo = 1;
            e.Balance = 1400;
            paso = EstudianteBLL.Modificar(e);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = EstudianteBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Estudiante e;
            e = EstudianteBLL.Buscar(2);
            Assert.AreEqual(e, e);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listado = new List<Estudiante>();
            listado = EstudianteBLL.GetList(p => true);
            Assert.AreEqual(listado, listado);
        }
    }
}