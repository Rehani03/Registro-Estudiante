using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro1.UI.Registros;
using Registro1.UI.Consultas;

namespace Registro1
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteForm ef = new EstudianteForm();
            ef.Show();
        }

        private void ConsultarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstudianteForm cef = new ConsultaEstudianteForm();
            cef.Show();
        }
    }
}
