using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Tarea2ProyectoRegistro.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public string usuario { get; set; }
        public string NivelUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }


        public Usuario()
        {
            UsuarioID = 0;
            nombre = string.Empty;
            email = string.Empty;
            usuario = string.Empty;
            NivelUsuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;

        }
    }

  }
