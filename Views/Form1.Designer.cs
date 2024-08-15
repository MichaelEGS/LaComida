namespace LaComida
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtInstrucciones = new System.Windows.Forms.TextBox();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnTurorial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btnmaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.panelFondo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // txtInstrucciones
            // 
            resources.ApplyResources(this.txtInstrucciones, "txtInstrucciones");
            this.txtInstrucciones.BackColor = System.Drawing.Color.SeaShell;
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.ReadOnly = true;
            // 
            // lstIngredientes
            // 
            resources.ApplyResources(this.lstIngredientes, "lstIngredientes");
            this.lstIngredientes.BackColor = System.Drawing.Color.SeaShell;
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.Name = "lstIngredientes";
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.SeaShell;
            this.panelFondo.Controls.Add(this.label5);
            this.panelFondo.Controls.Add(this.BtnTurorial);
            this.panelFondo.Controls.Add(this.panel2);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.label4);
            this.panelFondo.Controls.Add(this.txtNombreReceta);
            this.panelFondo.Controls.Add(this.txtInstrucciones);
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Controls.Add(this.btnBuscar);
            this.panelFondo.Controls.Add(this.picImagen);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.lblNombre);
            this.panelFondo.Controls.Add(this.lstIngredientes);
            resources.ApplyResources(this.panelFondo, "panelFondo");
            this.panelFondo.Name = "panelFondo";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // BtnTurorial
            // 
            resources.ApplyResources(this.BtnTurorial, "BtnTurorial");
            this.BtnTurorial.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnTurorial.Name = "BtnTurorial";
            this.BtnTurorial.UseVisualStyleBackColor = false;
            this.BtnTurorial.Click += new System.EventHandler(this.BtnTurorial_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.btnminimizar);
            this.panel2.Controls.Add(this.btnmaximizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnminimizar
            // 
            resources.ApplyResources(this.btnminimizar, "btnminimizar");
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.BackgroundImage = global::LaComida.Properties.Resources.minimizar_ventana1;
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.UseVisualStyleBackColor = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            resources.ApplyResources(this.btnmaximizar, "btnmaximizar");
            this.btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximizar.BackgroundImage = global::LaComida.Properties.Resources.expandir;
            this.btnmaximizar.FlatAppearance.BorderSize = 0;
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.UseVisualStyleBackColor = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LaComida.Properties.Resources.cruz;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtNombreReceta
            // 
            resources.ApplyResources(this.txtNombreReceta, "txtNombreReceta");
            this.txtNombreReceta.Name = "txtNombreReceta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::LaComida.Properties.Resources.Portada_ebook_de_cocina_y_recetas__300_x_900_px_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // picImagen
            // 
            resources.ApplyResources(this.picImagen, "picImagen");
            this.picImagen.Name = "picImagen";
            this.picImagen.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TextBox txtInstrucciones;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btnmaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnTurorial;
        private System.Windows.Forms.Label label5;
    }
}

