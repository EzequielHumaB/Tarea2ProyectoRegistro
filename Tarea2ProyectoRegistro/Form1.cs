using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2ProyectoRegistro.UI.Consultas;
using Tarea2ProyectoRegistro.UI.Registros;

namespace Tarea2ProyectoRegistro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarios = new UsuariosForm();
            usuarios.StartPosition = FormStartPosition.CenterScreen;
            usuarios.Show();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarioForm consulta = new ConsultaUsuarioForm();
            consulta.StartPosition = FormStartPosition.CenterScreen;
            consulta.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargosForm cargos = new CargosForm();
            cargos.StartPosition = FormStartPosition.CenterScreen;
            cargos.Show();     
        }

        private void ConsultasDeCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCargos consulta = new ConsultaCargos();
            consulta.StartPosition = FormStartPosition.CenterScreen;
            consulta.Show();
        }
    }
}
