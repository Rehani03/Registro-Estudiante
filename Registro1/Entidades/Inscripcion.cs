using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Registro1.Entidades
{
    public class Inscripcion
    {
        private int inscripcionID;
        private DateTime fecha;
        private int estudianteID;
        private string comentario;
        private decimal monto;
        private decimal deposito;
        private decimal balance;

        public Inscripcion()
        {

        }

        [Key]
        public int InscripcionID { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteID { get; set; }
        public string Comentario { get; set; }
        public decimal Monto { get; set; }
        public decimal Deposito { get; set; }
        public decimal Balance { get; set; }
    }
}
