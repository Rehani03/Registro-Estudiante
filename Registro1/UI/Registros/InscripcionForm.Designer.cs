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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstudianteIDLabel = new System.Windows.Forms.Label();
            this.EstudianteIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ComentarioLabel = new System.Windows.Forms.Label();
            this.ComentarioListBox = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorInscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(27, 69);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 0;
            this.FechaLabel.Text = "Fecha";
            this.FechaLabel.Click += new System.EventHandler(this.FechaLabel_Click);
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
            this.ComentarioLabel.Location = new System.Drawing.Point(27, 198);
            this.ComentarioLabel.Name = "ComentarioLabel";
            this.ComentarioLabel.Size = new System.Drawing.Size(60, 13);
            this.ComentarioLabel.TabIndex = 0;
            this.ComentarioLabel.Text = "Comentario";
            // 
            // ComentarioListBox
            // 
            this.ComentarioListBox.FormattingEnabled = true;
            this.ComentarioListBox.Location = new System.Drawing.Point(152, 144);
            this.ComentarioListBox.Name = "ComentarioListBox";
            this.ComentarioListBox.Size = new System.Drawing.Size(234, 134);
            this.ComentarioListBox.TabIndex = 3;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(27, 300);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(37, 13);
            this.MontoLabel.TabIndex = 0;
            this.MontoLabel.Text = "Monto";
            this.MontoLabel.Click += new System.EventHandler(this.MontoLabel_Click);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(152, 293);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(120, 20);
            this.MontoTextBox.TabIndex = 4;
            // 
            // DepositoLabel
            // 
            this.DepositoLabel.AutoSize = true;
            this.DepositoLabel.Location = new System.Drawing.Point(27, 339);
            this.DepositoLabel.Name = "DepositoLabel";
            this.DepositoLabel.Size = new System.Drawing.Size(49, 13);
            this.DepositoLabel.TabIndex = 0;
            this.DepositoLabel.Text = "Depósito";
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(152, 332);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(120, 20);
            this.DepositoTextBox.TabIndex = 4;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(27, 377);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 0;
            this.BalanceLabel.Text = "Balance";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(152, 370);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(120, 20);
            this.BalanceTextBox.TabIndex = 4;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(27, 413);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(102, 62);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // InsertarButton
            // 
            this.InsertarButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertarButton.Image")));
            this.InsertarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarButton.Location = new System.Drawing.Point(152, 413);
            this.InsertarButton.Name = "InsertarButton";
            this.InsertarButton.Size = new System.Drawing.Size(110, 62);
            this.InsertarButton.TabIndex = 5;
            this.InsertarButton.Text = "Insertar";
            this.InsertarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(284, 413);
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
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 489);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.InsertarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.ComentarioListBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.EstudianteIDNumericUpDown);
            this.Controls.Add(this.numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider MyErrorInscripcion;
        private System.Windows.Forms.ListBox ComentarioListBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown EstudianteIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
    }
}