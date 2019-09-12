namespace Registro1
{
    partial class RegistroForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarInscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarAlProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.registrarInscripciónToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrarToolStripMenuItem.Text = "Registros";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.estudianteToolStripMenuItem.Text = "Registrar Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.EstudianteToolStripMenuItem_Click);
            // 
            // registrarInscripciónToolStripMenuItem
            // 
            this.registrarInscripciónToolStripMenuItem.Name = "registrarInscripciónToolStripMenuItem";
            this.registrarInscripciónToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarInscripciónToolStripMenuItem.Text = "Registrar Inscripción";
            this.registrarInscripciónToolStripMenuItem.Click += new System.EventHandler(this.RegistrarInscripciónToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEstudianteToolStripMenuItem,
            this.consultarInscripciónToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarEstudianteToolStripMenuItem
            // 
            this.consultarEstudianteToolStripMenuItem.Name = "consultarEstudianteToolStripMenuItem";
            this.consultarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarEstudianteToolStripMenuItem.Text = "Consultar Estudiante";
            this.consultarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEstudianteToolStripMenuItem_Click);
            // 
            // consultarInscripciónToolStripMenuItem
            // 
            this.consultarInscripciónToolStripMenuItem.Name = "consultarInscripciónToolStripMenuItem";
            this.consultarInscripciónToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarInscripciónToolStripMenuItem.Text = "Consultar Inscripción";
            this.consultarInscripciónToolStripMenuItem.Click += new System.EventHandler(this.ConsultarInscripciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactarAlProgramadorToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // contactarAlProgramadorToolStripMenuItem
            // 
            this.contactarAlProgramadorToolStripMenuItem.Name = "contactarAlProgramadorToolStripMenuItem";
            this.contactarAlProgramadorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.contactarAlProgramadorToolStripMenuItem.Text = "Contactar al programador";
            this.contactarAlProgramadorToolStripMenuItem.Click += new System.EventHandler(this.ContactarAlProgramadorToolStripMenuItem_Click);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 332);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistroForm";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarInscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarAlProgramadorToolStripMenuItem;
    }
}

