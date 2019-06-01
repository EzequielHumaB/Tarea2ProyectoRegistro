using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2ProyectoRegistro.Entidades;
using Tarea2ProyectoRegistro.DAL;
using System.Collections;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Tarea2ProyectoRegistro.BLL
{
   public class UsuarioClase
    {

        public static bool guardar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Add(usuario)!=null)
                {
                    paso = contexto.SaveChanges() > 0;

                }

            }catch(Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Modificar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);


            } catch(Exception)
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
                var eliminar = contexto.Usuarios.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }


        public static Usuario Buscar(int id)
        {
            Usuario usuario = new Usuario();
            Contexto contexto = new Contexto();
            try
            {
                usuario = contexto.Usuarios.Find(id); 

            }catch(Exception)
            {
                throw;
            }

            return usuario;
        }

        //Extraer una lista de los usuarios 
        public static List<Usuario> GetList(Expression<Func<Usuario,bool>>usuario)
        {
            List<Usuario> lista = new List<Usuario>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Usuarios.Where(usuario).ToList();


            } catch(Exception)
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
