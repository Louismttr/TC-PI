namespace pjAlgebraLineal
{
    partial class fmrMatrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMatrices));
            this.btnSaliir = new System.Windows.Forms.PictureBox();
            this.p_Boton = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.laResta = new pjAlgebraLineal.LeccionesAL();
            this.laMultiplica = new pjAlgebraLineal.LeccionesAL();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laSuma = new pjAlgebraLineal.LeccionesAL();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaliir)).BeginInit();
            this.p_Boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaliir
            // 
            this.btnSaliir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaliir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaliir.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btnSaliir.Location = new System.Drawing.Point(1482, 3);
            this.btnSaliir.Name = "btnSaliir";
            this.btnSaliir.Size = new System.Drawing.Size(40, 40);
            this.btnSaliir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaliir.TabIndex = 2;
            this.btnSaliir.TabStop = false;
            // 
            // p_Boton
            // 
            this.p_Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.p_Boton.Controls.Add(this.pictureBox4);
            this.p_Boton.Controls.Add(this.btnSaliir);
            this.p_Boton.Controls.Add(this.btn_Cerrar);
            this.p_Boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Boton.Location = new System.Drawing.Point(0, 0);
            this.p_Boton.Name = "p_Boton";
            this.p_Boton.Size = new System.Drawing.Size(820, 48);
            this.p_Boton.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.pictureBox4.Location = new System.Drawing.Point(777, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(2093, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(40, 40);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.TabStop = false;
            // 
            // laResta
            // 
            this.laResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.laResta.CambiarImagen = ((System.Drawing.Image)(resources.GetObject("laResta.CambiarImagen")));
            this.laResta.CambiarLbl = "Resta";
            this.laResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laResta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laResta.ForeColor = System.Drawing.Color.White;
            this.laResta.Location = new System.Drawing.Point(586, 156);
            this.laResta.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.laResta.Name = "laResta";
            this.laResta.Size = new System.Drawing.Size(207, 168);
            this.laResta.TabIndex = 29;
            this.laResta.Load += new System.EventHandler(this.leccionesal1_Load);
            this.laResta.Click += new System.EventHandler(this.laResta_Click);
            // 
            // laMultiplica
            // 
            this.laMultiplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.laMultiplica.CambiarImagen = ((System.Drawing.Image)(resources.GetObject("laMultiplica.CambiarImagen")));
            this.laMultiplica.CambiarLbl = "Multiplicación";
            this.laMultiplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laMultiplica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laMultiplica.ForeColor = System.Drawing.Color.White;
            this.laMultiplica.Location = new System.Drawing.Point(289, 255);
            this.laMultiplica.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.laMultiplica.Name = "laMultiplica";
            this.laMultiplica.Size = new System.Drawing.Size(230, 168);
            this.laMultiplica.TabIndex = 30;
            this.laMultiplica.Click += new System.EventHandler(this.laMultiplica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Matrices";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laSuma);
            this.panel1.Controls.Add(this.laMultiplica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 441);
            this.panel1.TabIndex = 32;
            // 
            // laSuma
            // 
            this.laSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.laSuma.CambiarImagen = global::pjAlgebraLineal.Properties.Resources.sumamatri;
            this.laSuma.CambiarLbl = "Suma";
            this.laSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laSuma.ForeColor = System.Drawing.Color.White;
            this.laSuma.Location = new System.Drawing.Point(25, 135);
            this.laSuma.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.laSuma.Name = "laSuma";
            this.laSuma.Size = new System.Drawing.Size(202, 168);
            this.laSuma.TabIndex = 29;
            this.laSuma.Click += new System.EventHandler(this.laSuma_Click_1);
            // 
            // fmrMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laResta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_Boton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrMatrices";
            this.Text = "fmrMatrices";
            ((System.ComponentModel.ISupportInitialize)(this.btnSaliir)).EndInit();
            this.p_Boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox btnSaliir;
        private Panel p_Boton;
        private PictureBox btn_Cerrar;
        private PictureBox pictureBox4;
        private LeccionesAL laResta;
        private LeccionesAL laMultiplica;
        private Label label1;
        private Panel panel1;
        private LeccionesAL laSuma;
    }
}