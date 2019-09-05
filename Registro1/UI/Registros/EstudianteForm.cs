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
            MatriculaMaskedTextBox.Text = string.Empty;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FechaDateTime.Value = DateTime.Now;
            SexoComboBox.Text = string.Empty;
            BalanceMaskedTextBox.Text = string.Empty;
            MyError.Clear();
        }

        private Estudiante LlenarClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteID = Convert.ToInt32(numericUpDown.Value);
            estudiante.Matricula = MatriculaMaskedTextBox.Text;
            estudiante.Nombres = NombresTextBox.Text;
            estudiante.Apellidos = ApellidosTextBox.Text;
            estudiante.Cedula = CedulaMaskedTextBox.Text;
            estudiante.Telefono = TelefonoMaskedTextBox.Text;
            estudiante.Celular = CelularMaskedTextBox.Text;
            estudiante.Email = EmailTextBox.Text;
            estudiante.FechaNacimiento = FechaDateTime.Value;
            if (SexoComboBox.SelectedItem.ToString() == "Femenino")
                estudiante.Sexo = 0;
            else
                if (SexoComboBox.SelectedItem.ToString() == "Masculino")
                estudiante.Sexo = 1;

            estudiante.Balance = BalanceMaskedTextBox.Text;


            return estudiante;
        }

        private void LlenarCampos(Estudiante estudiante)
        {
            numericUpDown.Value = estudiante.EstudianteID;
            MatriculaMaskedTextBox.Text = estudiante.Matricula;
            NombresTextBox.Text = estudiante.Nombres;
            ApellidosTextBox.Text = estudiante.Apellidos;
            CedulaMaskedTextBox.Text = estudiante.Cedula;
            TelefonoMaskedTextBox.Text = estudiante.Telefono;
            CelularMaskedTextBox.Text = estudiante.Celular;
            EmailTextBox.Text = estudiante.Email;
            FechaDateTime.Value = estudiante.FechaNacimiento;
            if (estudiante.Sexo == 0)
            {
                SexoComboBox.SelectedIndex = 0;
                SexoComboBox.Show();

            }    
            else
                if (estudiante.Sexo == 1)
                {
                     SexoComboBox.SelectedIndex = 1;
                     SexoComboBox.Show();
                }
                
            BalanceMaskedTextBox.Text = estudiante.Balance;
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            MyError.Clear();

            if (!MatriculaMaskedTextBox.MaskFull)
            {
                MyError.SetError(MatriculaMaskedTextBox, "El campo Matrìcula no puede estar vacio.");
                flag = false;
            }

            if (String.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyError.SetError(NombresTextBox, "El campo Nombre no puede estar vacio.");
                flag = false;
            }

            if (String.IsNullOrWhiteSpace(ApellidosTextBox.Text))
            {
                MyError.SetError(ApellidosTextBox, "El campo Apellidos no puede estar vacio.");
                flag = false;
            }

            if (!CedulaMaskedTextBox.MaskFull)
            {
                MyError.SetError(CedulaMaskedTextBox, "El campo Cédula no puede estar vacio.");
                flag = false;
            }

            if (!TelefonoMaskedTextBox.MaskFull)
            {
                MyError.SetError(TelefonoMaskedTextBox, "El campo Teléfono no puede estar vacio.");
                flag = false;
            }

            if (!CelularMaskedTextBox.MaskFull)
            {
                MyError.SetError(CelularMaskedTextBox, "El campo Celular no puede estar vacio.");
                flag = false;
            }

            if (String.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyError.SetError(EmailTextBox, "El campo Email no puede estar vacio.");
                flag = false;
            }

            if (SexoComboBox.SelectedIndex == -1)
            {
                MyError.SetError(SexoComboBox, "El campo Sexo no puede estar vacio.");
                flag = false;
            }


            if (String.IsNullOrWhiteSpace(BalanceMaskedTextBox.Text))
            {
                MyError.SetError(BalanceMaskedTextBox, "El campo Balance no puede estar vacio");
                flag = false;
            }

            return flag; 
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiante estudiante = EstudianteBLL.Buscar((int)numericUpDown.Value);
            return (estudiante != null);
        }

        //Boton guardar del menu de registo de estudiante
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante;
            bool flag = false;

            if (!ValidarCampos())
                return;
            estudiante = LlenarClase();

            if (numericUpDown.Value == 0)
                flag = EstudianteBLL.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                flag = EstudianteBLL.Modificar(estudiante);
            }


            if (flag)
            {
                LimpiarCampos();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiante estudiante = new Estudiante();
            id = Convert.ToInt32(numericUpDown.Value);

            LimpiarCampos();

            estudiante = EstudianteBLL.Buscar(id);
            if(estudiante!= null)
            {
                MessageBox.Show("Estudiante encontrado");
                LlenarCampos(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyError.Clear();
            int id;
            id = Convert.ToInt32(numericUpDown.Value);

            LimpiarCampos();
            if (EstudianteBLL.Eliminar(id))
                MessageBox.Show("Estudiante Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puede eliminar, porque no existe.");
        }
    }
}
