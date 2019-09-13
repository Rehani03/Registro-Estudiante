using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro1.Entidades;
using Registro1.DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using Registro1.UI.Registros;

namespace Registro1.BLL
{
    public class InscripcionBLL
    {
        //este metodo guarda en la base de datos
        public static bool Guardar(Inscripcion inscripcion)
        {
            bool flag = false;
            Contexto db = new Contexto();


            try
            {
                if (db.Inscripcion.Add(inscripcion) != null)
                {
                    flag = db.SaveChanges() > 0;
                    db.Estudiante.Find(inscripcion.EstudianteID).Balance = inscripcion.Balance;
                    flag = db.SaveChanges() > 0;
                }      
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return flag;
        }

        //este metodo modifica la inscripcion en la base de datos
        public static bool Modificar(Inscripcion inscripcion)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(inscripcion).State = EntityState.Modified;
                flag = db.SaveChanges() > 0;
                db.Estudiante.Find(inscripcion.EstudianteID).Balance = inscripcion.Balance;
                flag = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return flag;
        }

        //este metodo elimina la el balance de la incripcion en la base de datos
        public static bool Eliminar(int id, int IDEstudiante)
        {
            bool flag = false;
            Contexto db = new Contexto();
           
            try
            {
                db.Inscripcion.Find(id).Balance = 0;
                db.Estudiante.Find(IDEstudiante).Balance = 0; 
                flag = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return flag;
        }

        //este metodo busca la inscripcion de la base de datos
        public static Inscripcion Buscar(int id)
        {
            Inscripcion inscripcion = new Inscripcion();
            Contexto db = new Contexto();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return inscripcion;
        }

        //Este metodo devuelve una lista de las inscripciones registrada en la base de datos
        public static List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> inscripcion)
        {
            List<Inscripcion> Lista = new List<Inscripcion>();

            Contexto db = new Contexto();
            try
            {
                Lista = db.Inscripcion.Where(inscripcion).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
