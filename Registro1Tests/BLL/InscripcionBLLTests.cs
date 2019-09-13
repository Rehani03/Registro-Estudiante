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
    public class InscripcionBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Inscripcion i = new Inscripcion();
            i.InscripcionID = 0;
            i.Fecha = DateTime.Now;
            i.EstudianteID = 4;
            i.Comentario = "Test Debug";
            i.Deposito = 1000;
            i.Monto = 500;
            paso = InscripcionBLL.Guardar(i);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Inscripcion i = new Inscripcion();
            i.InscripcionID = 1;
            i.Fecha = DateTime.Now;
            i.EstudianteID = 1;
            i.Comentario = "Test Debug";
            i.Deposito = 1000;
            i.Monto = 500;
            paso = InscripcionBLL.Modificar(i);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = InscripcionBLL.Eliminar(2, 2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Inscripcion i; 
            i = InscripcionBLL.Buscar(3);
            Assert.AreEqual(i, i);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listado = new List<Inscripcion>();
            listado = InscripcionBLL.GetList(p => true);
            Assert.AreEqual(listado, listado);
        }
    }
}