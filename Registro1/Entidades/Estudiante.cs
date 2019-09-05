using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Registro1.Entidades
{
    public class Estudiante
    {
        private int estudianteID;
        private string matricula;
        private string nombres;
        private string apellidos;
        private string cedula;
        private string telefono;
        private string celular;
        private string email;
        private DateTime fechaNacimiento;
        private int sexo;
        private double balance;

        public Estudiante()
        {

        }

        [Key]
        public int EstudianteID { get => estudianteID; set => estudianteID = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Nombres { get => nombres; set => nombres = value; }
    }
}
