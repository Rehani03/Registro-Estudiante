using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Registro1.Entidades;

namespace Registro1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
