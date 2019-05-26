using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;
using Tarea2ProyectoRegistro.Entidades;
using Tarea2ProyectoRegistro.BLL;

namespace Tarea2ProyectoRegistro.DAL
{
   public class Contexto : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        
        public Contexto() : base("constStr")
        {
            
        }

    }
}
