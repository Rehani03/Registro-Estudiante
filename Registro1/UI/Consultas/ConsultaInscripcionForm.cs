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
    public partial class ConsultaInscripcionForm : Form
    {
        public ConsultaInscripcionForm()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {

            var listado = new List<Inscripcion>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //todo
                        listado = InscripcionBLL.GetList(p => true);
                        MessageBox.Show("Todo");
                        break;
                    case 1: //ID
                        try
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = InscripcionBLL.GetList(p => p.InscripcionID == id);
                            MessageBox.Show("ID");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Por favor, ingrese un ID valido");
                        }
                        break;
                    default:
                        MessageBox.Show("No existe esa opción en el Filtro");
                        break;

                }
                //fecha
                /*listado = listado.Where(p => p.Fecha.Date >= DesdeDateTimePicker.Value.Date &&
                                        p.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();*/
            }
            else
            {
                listado = InscripcionBLL.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }
    }
}
