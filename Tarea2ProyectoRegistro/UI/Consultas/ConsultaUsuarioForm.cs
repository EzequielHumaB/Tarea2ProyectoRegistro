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
using Tarea2ProyectoRegistro.DAL;
using Tarea2ProyectoRegistro.UI;
using System.Collections;


namespace Tarea2ProyectoRegistro.UI.Consultas
{
    public partial class ConsultaUsuarioForm : Form
    {
        public ConsultaUsuarioForm()
        {
            InitializeComponent();
        }

        private void ButtonConsultar_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuario>();
            if(textBoxCristerio.Text.Trim().Length > 0)
            {
                switch(comboBoxFiltro.SelectedIndex)
                {
                    //Todo
                    case 0:
                        listado = UsuarioClase.GetList(p => true);
                        break;
                    case 1: //Seleccionar ID
                        int id = Convert.ToInt32(textBoxCristerio.Text);
                        listado = UsuarioClase.GetList(p => p.UsuarioID == id);
                        break;
                    case 2: //Seleccionar nombre
                        listado = UsuarioClase.GetList(p => p.nombre.Contains(textBoxCristerio.Text));
                        break;
                    case 3: //Seleccionar email
                        listado = UsuarioClase.GetList(p => p.email.Contains(textBoxCristerio.Text));
                        break;
                    case 4:
                        listado = UsuarioClase.GetList(p => p.usuario.Contains(textBoxCristerio.Text));
                        break;                          
                }
             
            } 
            else
            {
                listado = UsuarioClase.GetList(p => true);
            }

            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = listado;
        }

      
    }
}
