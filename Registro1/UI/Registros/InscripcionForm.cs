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
using Registro1.BLL;

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
            EstudianteIDNumericUpDown.Enabled = true;
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
            decimal monto, deposito, balance;
            deposito = Convert.ToDecimal(DepositoTextBox.Text);
            monto = Convert.ToDecimal(MontoTextBox.Text);
            balance = monto - deposito;

            Inscripcion inscripcion = new Inscripcion();
            inscripcion.InscripcionID = Convert.ToInt32(InscripcionIDNumericUpDown.Value);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.EstudianteID = Convert.ToInt32(EstudianteIDNumericUpDown.Value);
            inscripcion.Comentario = ComentarioTextBox.Text;
            inscripcion.Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            inscripcion.Monto = balance;
            inscripcion.Balance = balance;
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
            else
            {
                if(ComentarioTextBox.Text.Count() > MAXCOMENTARIO)
                {
                    MyErrorInscripcion.SetError(ComentarioTextBox, 
                                                "El campo Comentario no puede tener más "+MAXCOMENTARIO +" caracteres.");
                    flag = false;
                }

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

        private bool ExisteEnLaBaseDeDatosEstudiante()
        {
            Estudiante estudiante = EstudianteBLL.Buscar((int)EstudianteIDNumericUpDown.Value);
            return (estudiante != null);
        }

        private bool ExisteEnLaBaseDeDatosInscripcion()
        {
            Inscripcion inscripcion = InscripcionBLL.Buscar((int)InscripcionIDNumericUpDown.Value);
            return (inscripcion != null);
        }

        private bool ExisteIDEstudianteEnBaseDeDatosInscripcion()
        {
            int id;
            bool flag = false;
            Inscripcion inscripcion = new Inscripcion();
            id = Convert.ToInt32(InscripcionIDNumericUpDown.Value);
            inscripcion = InscripcionBLL.Buscar(id);

            if (inscripcion != null)
            {
               flag = inscripcion.EstudianteID == Convert.ToInt32(EstudianteIDNumericUpDown.Value);
            }
            
            return flag;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            EstudianteIDNumericUpDown.Enabled = true;
            LimpiarCamposInscripcion();
        }
        //Boton insertar en la base de datos inscripcion
        private void InsertarButton_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion;
            bool flag = false;

            if (!ValidarInscripcion())
                return;

            inscripcion = LlenaClaseInscripcion();

            if(InscripcionIDNumericUpDown.Value == 0 && ExisteEnLaBaseDeDatosEstudiante() == true
                && ExisteIDEstudianteEnBaseDeDatosInscripcion() == false)
            {
                flag = InscripcionBLL.Guardar(inscripcion);
            }     
            else
            {
                if (!ExisteEnLaBaseDeDatosInscripcion())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos Inscripción o Estudiante",
                          "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                flag = InscripcionBLL.Modificar(inscripcion);
            }

            if (flag)
            {
                LimpiarCamposInscripcion();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //este boton busca en la base de datos incripcion
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripcion inscripcion = new Inscripcion();
            id = Convert.ToInt32(InscripcionIDNumericUpDown.Value);

            LimpiarCamposInscripcion();

            inscripcion = InscripcionBLL.Buscar(id);
            if (inscripcion != null)
            {
                EstudianteIDNumericUpDown.Enabled = false;
                LlenarCamposInscripcion(inscripcion);
            }
            else
            {
                MessageBox.Show("Incripción no encontrada");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorInscripcion.Clear();
            int id;
            id = Convert.ToInt32(InscripcionIDNumericUpDown.Value);
            int idEstudiante = Convert.ToInt32(EstudianteIDNumericUpDown.Value);

            LimpiarCamposInscripcion();

            if (InscripcionBLL.Eliminar(id, idEstudiante))
                MessageBox.Show("Balance de Inscripción Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puede eliminar, porque no existe.");
        }
    }
}
