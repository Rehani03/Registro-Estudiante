namespace Registro1.UI.Registros
{
    partial class InscripcionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionForm));
            this.MyErrorInscripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.InscripcionIDLabel = new System.Windows.Forms.Label();
            this.InscripcionIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstudianteIDLabel = new System.Windows.Forms.Label();
            this.EstudianteIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ComentarioLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DepositoLabel = new System.Windows.Forms.Label();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.InsertarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorInscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MyErrorInscripcion
            // 
            this.MyErrorInscripcion.ContainerControl = this;
            // 
            // InscripcionIDLabel
            // 
            this.InscripcionIDLabel.AutoSize = true;
            this.InscripcionIDLabel.Location = new System.Drawing.Point(27, 31);
            this.InscripcionIDLabel.Name = "InscripcionIDLabel";
            this.InscripcionIDLabel.Size = new System.Drawing.Size(72, 13);
            this.InscripcionIDLabel.TabIndex = 0;
            this.InscripcionIDLabel.Text = "Inscripción ID";
            // 
            // InscripcionIDNumericUpDown
            // 
            this.InscripcionIDNumericUpDown.Location = new System.Drawing.Point(152, 24);
            this.InscripcionIDNumericUpDown.Name = "InscripcionIDNumericUpDown";
            this.InscripcionIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.InscripcionIDNumericUpDown.TabIndex = 1;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(27, 69);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 0;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(152, 62);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // EstudianteIDLabel
            // 
            this.EstudianteIDLabel.AutoSize = true;
            this.EstudianteIDLabel.Location = new System.Drawing.Point(27, 110);
            this.EstudianteIDLabel.Name = "EstudianteIDLabel";
            this.EstudianteIDLabel.Size = new System.Drawing.Size(71, 13);
            this.EstudianteIDLabel.TabIndex = 0;
            this.EstudianteIDLabel.Text = "Estudiante ID";
            // 
            // EstudianteIDNumericUpDown
            // 
            this.EstudianteIDNumericUpDown.Location = new System.Drawing.Point(152, 103);
            this.EstudianteIDNumericUpDown.Name = "EstudianteIDNumericUpDown";
            this.EstudianteIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.EstudianteIDNumericUpDown.TabIndex = 1;
            // 
            // ComentarioLabel
            // 
            this.ComentarioLabel.AutoSize = true;
            this.ComentarioLabel.Location = new System.Drawing.Point(27, 156);
            this.ComentarioLabel.Name = "ComentarioLabel";
            this.ComentarioLabel.Size = new System.Drawing.Size(60, 13);
            this.ComentarioLabel.TabIndex = 0;
            this.ComentarioLabel.Text = "Comentario";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(27, 200);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(37, 13);
            this.MontoLabel.TabIndex = 0;
            this.MontoLabel.Text = "Monto";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(152, 193);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(120, 20);
            this.MontoTextBox.TabIndex = 4;
            // 
            // DepositoLabel
            // 
            this.DepositoLabel.AutoSize = true;
            this.DepositoLabel.Location = new System.Drawing.Point(27, 244);
            this.DepositoLabel.Name = "DepositoLabel";
            this.DepositoLabel.Size = new System.Drawing.Size(49, 13);
            this.DepositoLabel.TabIndex = 0;
            this.DepositoLabel.Text = "Depósito";
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(152, 237);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(120, 20);
            this.DepositoTextBox.TabIndex = 4;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(27, 287);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 0;
            this.BalanceLabel.Text = "Balance";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(152, 280);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(120, 20);
            this.BalanceTextBox.TabIndex = 4;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(12, 338);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(102, 62);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // InsertarButton
            // 
            this.InsertarButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertarButton.Image")));
            this.InsertarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarButton.Location = new System.Drawing.Point(152, 338);
            this.InsertarButton.Name = "InsertarButton";
            this.InsertarButton.Size = new System.Drawing.Size(110, 62);
            this.InsertarButton.TabIndex = 5;
            this.InsertarButton.Text = "Insertar";
            this.InsertarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertarButton.UseVisualStyleBackColor = true;
            this.InsertarButton.Click += new System.EventHandler(this.InsertarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(284, 338);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(102, 62);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(284, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(102, 53);
            this.BuscarButton.TabIndex = 5;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(152, 149);
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.Size = new System.Drawing.Size(234, 20);
            this.ComentarioTextBox.TabIndex = 6;
            // 
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.ComentarioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.InsertarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.EstudianteIDNumericUpDown);
            this.Controls.Add(this.InscripcionIDNumericUpDown);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.DepositoLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.ComentarioLabel);
            this.Controls.Add(this.EstudianteIDLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.InscripcionIDLabel);
            this.MaximizeBox = false;
            this.Name = "InscripcionForm";
            this.Text = "Registro de Inscripción";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorInscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider MyErrorInscripcion;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown EstudianteIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown InscripcionIDNumericUpDown;
        private System.Windows.Forms.Label ComentarioLabel;
        private System.Windows.Forms.Label EstudianteIDLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label InscripcionIDLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button InsertarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label DepositoLabel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox ComentarioTextBox;
    }
}