namespace pjAlgebraLineal
{
    partial class fmrLecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrLecciones));
            this.p_Boton = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_For = new System.Windows.Forms.Panel();
            this.leccion_uno = new pjAlgebraLineal.LeccionesAL();
            this.leccion_dos = new pjAlgebraLineal.LeccionesAL();
            this.p_Boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.pTitulo.SuspendLayout();
            this.p_For.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Boton
            // 
            this.p_Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.p_Boton.Controls.Add(this.btn_Cerrar);
            this.p_Boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Boton.Location = new System.Drawing.Point(0, 0);
            this.p_Boton.Name = "p_Boton";
            this.p_Boton.Size = new System.Drawing.Size(820, 48);
            this.p_Boton.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(768, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(40, 40);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pTitulo
            // 
            this.pTitulo.Controls.Add(this.label2);
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 48);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(820, 63);
            this.pTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sus lecciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecciones";
            // 
            // p_For
            // 
            this.p_For.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.p_For.Controls.Add(this.leccion_uno);
            this.p_For.Controls.Add(this.leccion_dos);
            this.p_For.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_For.Location = new System.Drawing.Point(0, 111);
            this.p_For.Name = "p_For";
            this.p_For.Size = new System.Drawing.Size(820, 369);
            this.p_For.TabIndex = 2;
            // 
            // leccion_uno
            // 
            this.leccion_uno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.leccion_uno.CambiarImagen = ((System.Drawing.Image)(resources.GetObject("leccion_uno.CambiarImagen")));
            this.leccion_uno.CambiarLbl = "Matrices";
            this.leccion_uno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leccion_uno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leccion_uno.ForeColor = System.Drawing.Color.White;
            this.leccion_uno.Location = new System.Drawing.Point(68, 131);
            this.leccion_uno.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.leccion_uno.Name = "leccion_uno";
            this.leccion_uno.Size = new System.Drawing.Size(207, 168);
            this.leccion_uno.TabIndex = 1;
            this.leccion_uno.Click += new System.EventHandler(this.leccion_uno_Click);
            // 
            // leccion_dos
            // 
            this.leccion_dos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leccion_dos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.leccion_dos.CambiarImagen = ((System.Drawing.Image)(resources.GetObject("leccion_dos.CambiarImagen")));
            this.leccion_dos.CambiarLbl = "Vectores";
            this.leccion_dos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leccion_dos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leccion_dos.ForeColor = System.Drawing.Color.White;
            this.leccion_dos.Location = new System.Drawing.Point(586, 131);
            this.leccion_dos.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.leccion_dos.Name = "leccion_dos";
            this.leccion_dos.Size = new System.Drawing.Size(207, 168);
            this.leccion_dos.TabIndex = 0;
            this.leccion_dos.Click += new System.EventHandler(this.leccion_dos_Click);
            // 
            // fmrLecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.p_For);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.p_Boton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrLecciones";
            this.Text = "fmrLecciones";
            this.p_Boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.p_For.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel p_Boton;
        private Panel pTitulo;
        private Label label2;
        private Label label1;
        private Panel p_For;
        private LeccionesAL leccion_uno;
        private LeccionesAL leccion_dos;
        private PictureBox btn_Cerrar;
    }
}