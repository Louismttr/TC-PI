namespace pjAlgebraLineal
{
    partial class LeccionesAL
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeccionesAL));
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnIconMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIconMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::pjAlgebraLineal.Properties.Resources.Registrarse;
            this.pbImagen.Location = new System.Drawing.Point(46, 35);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(110, 94);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // btnIconMenu
            // 
            this.btnIconMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnIconMenu.Image")));
            this.btnIconMenu.Location = new System.Drawing.Point(169, 0);
            this.btnIconMenu.Name = "btnIconMenu";
            this.btnIconMenu.Size = new System.Drawing.Size(35, 35);
            this.btnIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIconMenu.TabIndex = 2;
            this.btnIconMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escribe...";
            // 
            // LeccionesAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIconMenu);
            this.Controls.Add(this.pbImagen);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.Name = "LeccionesAL";
            this.Size = new System.Drawing.Size(207, 168);
            this.Load += new System.EventHandler(this.LeccionesAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIconMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbImagen;
        private PictureBox btnIconMenu;
        private Label label1;
    }
}
