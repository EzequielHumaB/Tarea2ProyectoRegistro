using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Tarea2ProyectoRegistro.Entidades
{
   public class Cargo
    {
        [Key]
        public int CargoID { get; set; }
        public string DescripcionCargo { get; set; }

        public Cargo()
        {
            CargoID = 0;
            DescripcionCargo = string.Empty;
        }

    }
}
