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

        private void RegistrarInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionForm inscripcionForm = new InscripcionForm();
            inscripcionForm.Show();
        }

        private void ConsultarInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaInscripcionForm cif = new ConsultaInscripcionForm();
            cif.Show();
        }

        private void ContactarAlProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea mejoras, por favor contactar a Rehani Cordero.");
        }
    }
}
