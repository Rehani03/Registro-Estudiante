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
        private string balance;

        public Estudiante()
        {

        }

        [Key]
        public int EstudianteID { get; set; }
        public string Matricula { get ; set; }
        public string Nombres { get; set; }
        public string Apellidos { get ; set ; }
        public string Cedula { get ; set ; }
        public string Telefono { get; set ; }
        public string Celular { get ; set ; }
        public string Email { get ; set ; }
        public DateTime FechaNacimiento { get ; set ; }
        public int Sexo { get ; set ; }
        public string Balance { get; set ; }
    }
}
