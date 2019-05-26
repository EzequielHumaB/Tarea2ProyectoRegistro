using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2ProyectoRegistro.Entidades;
using Tarea2ProyectoRegistro.BLL;

namespace Tarea2ProyectoRegistro.UI.Consultas
{
    public partial class ConsultaCargos : Form
    {
        public ConsultaCargos()
        {
            InitializeComponent();
        }

        private void ButtonConsultar_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargo>();
            if (textBoxCriterioCargo.Text.Trim().Length > 0)
            {
                switch (comboBoxfiltroCargo.SelectedIndex)
                {
                    //Todo
                    case 0:
                        listado = CargoClase.GetList(p => true);
                        break;
                    case 1: //Seleccionar ID
                        int id = Convert.ToInt32(textBoxCriterioCargo.Text);
                        listado = CargoClase.GetList(p => p.CargoID == id);
                        break;
                }

            }
            else
            {
                listado = CargoClase.GetList(p => true);
            }
            dataGridViewCargo.DataSource = null;
            dataGridViewCargo.DataSource = listado;
        }
    }
}
