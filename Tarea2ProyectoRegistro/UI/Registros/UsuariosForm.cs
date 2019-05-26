using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2ProyectoRegistro.BLL;
using Tarea2ProyectoRegistro.Entidades;

namespace Tarea2ProyectoRegistro.UI.Registros
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        //Boton nuevo
        private void Button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            numericUpDownUID.Value = 0;
            textBoxNombre.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxNivelUsuario.Text = string.Empty;
            textBoxUsuario.Text = string.Empty;
            textBoxClave.Text = string.Empty;
            dateTimePickerFechaIngreso.Value = DateTime.Now;
        }

        private Usuario LlenarClase()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioID = Convert.ToInt32(Math.Round(numericUpDownUID.Value,0));
            usuario.nombre = textBoxNombre.Text;
            usuario.usuario = textBoxUsuario.Text;
            usuario.Clave = textBoxClave.Text;
            usuario.NivelUsuario = textBoxNivelUsuario.Text;
            usuario.email = textBoxEmail.Text;
            usuario.FechaIngreso = dateTimePickerFechaIngreso.Value;

            return usuario;
        }

        private void LlenarCampo(Usuario usuario)
        {
            numericUpDownUID.Value = usuario.UsuarioID;
            textBoxNombre.Text = usuario.nombre;
            textBoxEmail.Text = usuario.email;
            textBoxUsuario.Text = usuario.usuario;
            textBoxNivelUsuario.Text = usuario.NivelUsuario;
            textBoxClave.Text = usuario.Clave;
            dateTimePickerFechaIngreso.Value = usuario.FechaIngreso;
        }

        public bool valirdar()
        {
            bool paso = true;

            if (textBoxNombre.Text ==string.Empty)
            {
                MessageBox.Show("El nombre no puede estar vacio");
                textBoxNombre.Focus();
                paso = false;

            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {            
                MessageBox.Show("El email no puede estar vacio");
                textBoxEmail.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                MessageBox.Show("El email no puede estar vacio");
                textBoxEmail.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNivelUsuario.Text))
            {
                MessageBox.Show("El nivel de usuario no puede estar vacio");
                textBoxNivelUsuario.Focus();
                paso = false;

            }

          if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                MessageBox.Show("El usuario no puede estar vacio");
                textBoxUsuario.Focus();
                paso = false;
            }

          if (string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                MessageBox.Show("La clave no puede estar vacia");
                textBoxClave.Focus();
                paso = false;
            }

            return paso;
          
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuario usuario = UsuarioClase.Buscar((int)numericUpDownUID.Value);

            return (usuario != null);
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool paso = false;

            if (!valirdar())
            {
                return;
            }

            usuario = LlenarClase();
            Limpiar();
            //Determinar si es guardar o modificar
            if (numericUpDownUID.Value == 0)
            {
                paso = UsuarioClase.guardar(usuario);
               
            } else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuarioClase.Modificar(usuario);
            }

           
            //Informar
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Usuario usuario = new Usuario();
            int.TryParse(numericUpDownUID.Text, out id);
            Limpiar();

            usuario = UsuarioClase.Buscar(id);

            if (usuario!=null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenarCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(numericUpDownUID.Text, out id);
            Limpiar();
            if (UsuarioClase.eliminar(id))
            {
                MessageBox.Show("Usuario eliminado exitosamente");
            } else
            {
                MessageBox.Show("No se puede eliminar a una persona que no existe");
            }
        }

        private void NumericUpDownidCargo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxCargoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
