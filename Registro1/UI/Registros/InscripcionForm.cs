using Registro1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro1.UI.Registros
{
    public partial class InscripcionForm : Form
    {
        private int MAXCOMENTARIO = 60;
        
        public InscripcionForm()
        {
            InitializeComponent();
        }

        private void LimpiarCamposInscripcion()
        {
            InscripcionIDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            EstudianteIDNumericUpDown.Value = 0;
            ComentarioTextBox.Text = string.Empty;
            MontoTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            MyErrorInscripcion.Clear();
        }

        private Inscripcion LlenaClaseInscripcion()
        {
            decimal monto, deposito;
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.InscripcionID = Convert.ToInt32(InscripcionIDNumericUpDown.Value);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.EstudianteID = Convert.ToInt32(EstudianteIDNumericUpDown.Value);
            inscripcion.Comentario = ComentarioTextBox.Text;
            inscripcion.Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            deposito = Convert.ToDecimal(DepositoTextBox.Text);
            inscripcion.Monto = Convert.ToDecimal(MontoTextBox.Text);
            monto = Convert.ToDecimal(MontoTextBox.Text);
            inscripcion.Balance = (monto - deposito);
            return inscripcion;
        }

        private void LlenarCamposInscripcion(Inscripcion inscripcion)
        {
            InscripcionIDNumericUpDown.Value = inscripcion.InscripcionID;
            FechaDateTimePicker.Value = inscripcion.Fecha;
            EstudianteIDNumericUpDown.Value = inscripcion.EstudianteID;
            ComentarioTextBox.Text = inscripcion.Comentario;
            DepositoTextBox.Text = Convert.ToString(inscripcion.Deposito);
            MontoTextBox.Text = Convert.ToString(inscripcion.Monto);
            BalanceTextBox.Text = Convert.ToString(inscripcion.Balance);
        }

        private bool ValidarInscripcion()
        {
            bool flag = true;
            MyErrorInscripcion.Clear();
            if (String.IsNullOrWhiteSpace(ComentarioTextBox.Text))
            {
                MyErrorInscripcion.SetError(ComentarioTextBox, "El campo Comentario no puede estar vacío.");
                flag = false;
            }

            if (String.IsNullOrWhiteSpace(DepositoTextBox.Text))
            {

                MyErrorInscripcion.SetError(DepositoTextBox, "El campo Deposito no puede estar vacío.");
                flag = false;
            }
            else
            {
                try
                {
                    decimal deposito = Convert.ToDecimal(DepositoTextBox.Text);
                }
                catch(FormatException error)
                {
                    MyErrorInscripcion.SetError(DepositoTextBox, "El campo Deposito debe tener numeros.");
                    flag = false;
                }
            }

            if (String.IsNullOrWhiteSpace(MontoTextBox.Text))
            {

                MyErrorInscripcion.SetError(MontoTextBox, "El campo Monto no puede estar vacío.");
                flag = false;
            }
            else
            {
                try
                {
                    decimal monto = Convert.ToDecimal(MontoTextBox.Text);
                }
                catch (FormatException error)
                {
                    MyErrorInscripcion.SetError(MontoTextBox, "El campo Monto debe tener numeros.");
                    flag = false;
                }
            }

            return flag;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCamposInscripcion();
        }

        private void InsertarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarInscripcion())
                return;
        }
    }
}
