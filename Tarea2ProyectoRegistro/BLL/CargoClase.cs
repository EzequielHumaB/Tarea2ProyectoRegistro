using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;
using System.Data.Entity;
using Tarea2ProyectoRegistro.Entidades;
using Tarea2ProyectoRegistro.DAL;

namespace Tarea2ProyectoRegistro.BLL
{
    public class CargoClase
    {
        public static bool guardar(Cargo cargo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Cargo.Add(cargo) != null)
                {
                    paso = contexto.SaveChanges() > 0;

                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Cargo cargo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(cargo).State = System.Data.Entity.EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }


        public static bool eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Cargo.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }


        public static Cargo Buscar(int id)
        {
            Cargo cargo = new Cargo();
            Contexto contexto = new Contexto();
            try
            {
                cargo = contexto.Cargo.Find(id);

            }
            catch (Exception)
            {
                throw;
            }

            return cargo;
        }

        //Extraer una lista de los usuarios 
        public static List<Cargo> GetList(Expression<Func<Cargo, bool>> cargo)
        {
            List<Cargo> lista = new List<Cargo>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Cargo.Where(cargo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;

        }
    }
}
