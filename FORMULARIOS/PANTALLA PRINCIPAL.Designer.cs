namespace SCHOOL_MANAGEMENT
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btnControlEstudiantes = new System.Windows.Forms.Button();
            this.btnControlProfesores = new System.Windows.Forms.Button();
            this.btnControlSecciones = new System.Windows.Forms.Button();
            this.btnControlUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnControlEstudiantes
            // 
            this.btnControlEstudiantes.BackColor = System.Drawing.Color.Teal;
            this.btnControlEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnControlEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnControlEstudiantes.Image")));
            this.btnControlEstudiantes.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControlEstudiantes.Location = new System.Drawing.Point(305, 119);
            this.btnControlEstudiantes.Name = "btnControlEstudiantes";
            this.btnControlEstudiantes.Size = new System.Drawing.Size(256, 70);
            this.btnControlEstudiantes.TabIndex = 0;
            this.btnControlEstudiantes.Text = "CONTROL ESTUDIANTES";
            this.btnControlEstudiantes.UseVisualStyleBackColor = false;
            // 
            // btnControlProfesores
            // 
            this.btnControlProfesores.BackColor = System.Drawing.Color.Maroon;
            this.btnControlProfesores.ForeColor = System.Drawing.Color.White;
            this.btnControlProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnControlProfesores.Image")));
            this.btnControlProfesores.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControlProfesores.Location = new System.Drawing.Point(23, 119);
            this.btnControlProfesores.Name = "btnControlProfesores";
            this.btnControlProfesores.Size = new System.Drawing.Size(256, 70);
            this.btnControlProfesores.TabIndex = 1;
            this.btnControlProfesores.Text = "CONTROL PROFESORES";
            this.btnControlProfesores.UseVisualStyleBackColor = false;
            this.btnControlProfesores.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnControlSecciones
            // 
            this.btnControlSecciones.BackColor = System.Drawing.Color.Olive;
            this.btnControlSecciones.ForeColor = System.Drawing.Color.White;
            this.btnControlSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnControlSecciones.Image")));
            this.btnControlSecciones.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControlSecciones.Location = new System.Drawing.Point(23, 224);
            this.btnControlSecciones.Name = "btnControlSecciones";
            this.btnControlSecciones.Size = new System.Drawing.Size(256, 70);
            this.btnControlSecciones.TabIndex = 2;
            this.btnControlSecciones.Text = "CONTROL SECCIONES";
            this.btnControlSecciones.UseVisualStyleBackColor = false;
            // 
            // btnControlUsuarios
            // 
            this.btnControlUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnControlUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnControlUsuarios.Image")));
            this.btnControlUsuarios.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControlUsuarios.Location = new System.Drawing.Point(305, 224);
            this.btnControlUsuarios.Name = "btnControlUsuarios";
            this.btnControlUsuarios.Size = new System.Drawing.Size(256, 67);
            this.btnControlUsuarios.TabIndex = 3;
            this.btnControlUsuarios.Text = " CONTROL USUARIOS";
            this.btnControlUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.LOGO);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 102);
            this.panel1.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(491, 74);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(491, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.Click += new System.EventHandler(this.lblFechayHora_Click);
            // 
            // LOGO
            // 
            this.LOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LOGO.Image = ((System.Drawing.Image)(resources.GetObject("LOGO.Image")));
            this.LOGO.Location = new System.Drawing.Point(264, 3);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(192, 96);
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(596, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 362);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnControlUsuarios);
            this.Controls.Add(this.btnControlSecciones);
            this.Controls.Add(this.btnControlProfesores);
            this.Controls.Add(this.btnControlEstudiantes);
            this.Name = "PantallaPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnControlEstudiantes;
        private System.Windows.Forms.Button btnControlProfesores;
        private System.Windows.Forms.Button btnControlSecciones;
        private System.Windows.Forms.Button btnControlUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}

