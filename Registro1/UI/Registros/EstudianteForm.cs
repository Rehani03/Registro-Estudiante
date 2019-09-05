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

namespace Registro1.UI.Registros
{
    public partial class EstudianteForm : Form
    {
        public EstudianteForm()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            numericUpDown.Value = 0;
            MatriculaTextBox.Text = string.Empty;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            CelularTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FechaDateTime.Value = DateTime.Now;
            SexoComboBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
        }

        private Estudiante LlenarClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteID = Convert.ToInt32(numericUpDown.Value);
            estudiante.Matricula = MatriculaTextBox.Text;
            estudiante.Nombres = NombresTextBox.Text;
            estudiante.Apellidos = ApellidosTextBox.Text;
            estudiante.Cedula = CedulaTextBox.Text;
            estudiante.Telefono = TelefonoTextBox.Text;
            estudiante.Celular = CelularTextBox.Text;
            estudiante.Email = EmailTextBox.Text;
            estudiante.FechaNacimiento = FechaDateTime.Value;
            if (SexoComboBox.SelectedItem.ToString() == "Femenino")
                estudiante.Sexo = 0;
            else
                if (SexoComboBox.SelectedItem.ToString() == "Masculino")
                estudiante.Sexo = 1;
            estudiante.Balance = Convert.ToDouble(BalanceTextBox.Text);


            return estudiante;
        }

        private void LlenarCampos(Estudiante estudiante)
        {
            numericUpDown.Value = estudiante.EstudianteID;
            MatriculaTextBox.Text = estudiante.Matricula;
            NombresTextBox.Text = estudiante.Nombres;
            ApellidosTextBox.Text = estudiante.Apellidos;
            CedulaTextBox.Text = estudiante.Cedula;
            TelefonoTextBox.Text = estudiante.Telefono;
            CelularTextBox.Text = estudiante.Celular;
            EmailTextBox.Text = estudiante.Email;
            FechaDateTime.Value = estudiante.FechaNacimiento;
            if (estudiante.Sexo == 0)
                SexoComboBox.Text = "Femenino";
            else
                if (estudiante.Sexo == 1)
                SexoComboBox.Text = "Masculino";
            BalanceTextBox.Text = Convert.ToString(estudiante.Balance);
        }

        private bool ValidarCampos()
        {
            bool flag = false;
            MyError.Clear();

            
            return flag; 
        }



        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
