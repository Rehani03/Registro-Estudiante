using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro1.Entidades;
using Registro1.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Registro1.BLL
{
    public class EstudianteBLL
    {
        //este metodo nos sirve para guardar la entidad en la base de datos
        public static bool Guardar(Estudiante estudiante)
        {
            bool flag = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Estudiante.Add(estudiante) != null)
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

        public static bool Modificar(Estudiante estudiante)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
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

        //este metodo elimina el estudiante de la base de datos
        public static bool Eliminar(int id)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Estudiante.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

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

        //este metodo busca el estudiante de la base de datos
        public static Estudiante Buscar(int id)
        {
            Estudiante estudiante = new Estudiante();
            Contexto db = new Contexto();

            try
            {
                estudiante = db.Estudiante.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return estudiante;
        }

        public static List<Estudiante> GetList(Expression<Func<Estudiante, bool>> estudiante)
        {
            List<Estudiante> Lista = new List<Estudiante>();

            Contexto db = new Contexto();
            try
            {
                Lista = db.Estudiante.Where(estudiante).ToList();
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
