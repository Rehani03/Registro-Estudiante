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

        //este metodo modifica la inscripcion en la base de datos
        public static bool Modificar(Inscripcion inscripcion)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(inscripcion).State = EntityState.Modified;
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

        //este metodo elimina la incripcion de la base de datos
        public static bool Eliminar(int id)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Inscripcion.Find(id);
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
    }
}
