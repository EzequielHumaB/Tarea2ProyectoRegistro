using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2ProyectoRegistro.UI.Registros;
using Tarea2ProyectoRegistro.Entidades;
using Tarea2ProyectoRegistro.BLL;

namespace Tarea2ProyectoRegistro.UI.Registros
{
    public partial class CargosForm : Form
    {
        public CargosForm()
        {
            InitializeComponent();
        }

        private void RichTextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            numericUpDownIdCargo.Value = 0;
            richTextBoxDescripcion.Text = string.Empty;
        }

        private Cargo LlenarClase()
        {
            Cargo cargo = new Cargo();
            cargo.CargoID = Convert.ToInt32(Math.Round(numericUpDownIdCargo.Value, 0));
            cargo.DescripcionCargo = richTextBoxDescripcion.Text;
           
            return cargo;
        }

        private void LlenarCampo(Cargo cargo)
        {
            numericUpDownIdCargo.Value = cargo.CargoID;
            richTextBoxDescripcion.Text = cargo.DescripcionCargo; 
        }

        public bool valirdar()
        {
            bool paso = true;

            if (richTextBoxDescripcion.Text == string.Empty)
            {
                MessageBox.Show("La descripcion no puede estar vacio");
                richTextBoxDescripcion.Focus();
                paso = false;

            }
 
            return paso;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargo cargo = CargoClase.Buscar((int)numericUpDownIdCargo.Value);

            return (cargo != null);
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Cargo cargo;
            bool paso = false;

            if (!valirdar())
            {
                return;
            }

            cargo = LlenarClase();
            Limpiar();
            //Determinar si es guardar o modificar
            if (numericUpDownIdCargo.Value == 0)
            {
                paso = CargoClase.guardar(cargo);

            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargoClase.Modificar(cargo);
            }


            //Informar
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(numericUpDownIdCargo.Text, out id);
            Limpiar();
            if (CargoClase.eliminar(id))
            {
                MessageBox.Show("Usuario eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("No se puede eliminar a una persona que no existe");
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Cargo cargo = new Cargo();
            int.TryParse(numericUpDownIdCargo.Text, out id);
            Limpiar();

            cargo = CargoClase.Buscar(id);

            if (cargo != null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenarCampo(cargo);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }
    }
}
