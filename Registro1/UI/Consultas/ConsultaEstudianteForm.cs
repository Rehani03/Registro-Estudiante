using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro1.Entidades;
using Registro1.BLL;

namespace Registro1.UI.Consultas
{
    public partial class ConsultaEstudianteForm : Form
    {
        public ConsultaEstudianteForm()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiante>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //todo
                        listado = EstudianteBLL.GetList(p => true);
                        MessageBox.Show("Todo");
                    break;
                    case 1: //ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = EstudianteBLL.GetList(p => p.EstudianteID == id);
                        MessageBox.Show("ID");
                        break;
                    case 2: //matricula
                      
                        listado = EstudianteBLL.GetList(p => p.Matricula.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //nombres
                        listado = EstudianteBLL.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;

                    case 4: //apellidos
                        listado = EstudianteBLL.GetList(p => p.Apellidos.Contains(CriterioTextBox.Text));
                        break;
                    case 5: //cedula
                        listado = EstudianteBLL.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                        break;
                  

                }
                //fecha
                /*listado = listado.Where(p => p.FechaNacimiento.Date >= DesdeDataTime.Value.Date &&
                                        p.FechaNacimiento.Date <= HastaDataTime.Value.Date).ToList();*/
             }
             else
             {
                 listado = EstudianteBLL.GetList(p => true);
             }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }

    }
}
