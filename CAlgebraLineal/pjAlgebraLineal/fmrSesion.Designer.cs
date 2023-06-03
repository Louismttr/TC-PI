namespace pjAlgebraLineal
{
    partial class fmrSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContras = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cB_Mostrar = new System.Windows.Forms.CheckBox();
            this.p_Boton = new System.Windows.Forms.Panel();
            this.btnRetornar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_Boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetornar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pjAlgebraLineal.Properties.Resources.Registrarse;
            this.pictureBox1.Location = new System.Drawing.Point(348, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(248, 253);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(416, 29);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContras
            // 
            this.txtContras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContras.ForeColor = System.Drawing.Color.White;
            this.txtContras.Location = new System.Drawing.Point(248, 329);
            this.txtContras.Name = "txtContras";
            this.txtContras.Size = new System.Drawing.Size(416, 29);
            this.txtContras.TabIndex = 4;
            this.txtContras.UseSystemPasswordChar = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(348, 425);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(181, 42);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cB_Mostrar
            // 
            this.cB_Mostrar.AutoSize = true;
            this.cB_Mostrar.Location = new System.Drawing.Point(580, 377);
            this.cB_Mostrar.Name = "cB_Mostrar";
            this.cB_Mostrar.Size = new System.Drawing.Size(84, 25);
            this.cB_Mostrar.TabIndex = 6;
            this.cB_Mostrar.Text = "Mostrar";
            this.cB_Mostrar.UseVisualStyleBackColor = true;
            this.cB_Mostrar.CheckedChanged += new System.EventHandler(this.cB_Mostrar_CheckedChanged);
            // 
            // p_Boton
            // 
            this.p_Boton.Controls.Add(this.btnRetornar);
            this.p_Boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Boton.Location = new System.Drawing.Point(0, 0);
            this.p_Boton.Name = "p_Boton";
            this.p_Boton.Size = new System.Drawing.Size(820, 48);
            this.p_Boton.TabIndex = 7;
            this.p_Boton.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Boton_Paint);
            this.p_Boton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Boton_MouseDown);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btnRetornar.Location = new System.Drawing.Point(768, 5);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(40, 40);
            this.btnRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetornar.TabIndex = 0;
            this.btnRetornar.TabStop = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // fmrSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.p_Boton);
            this.Controls.Add(this.cB_Mostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContras);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrSesion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmrSesion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_Boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRetornar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContras;
        private Button btnRegistrar;
        private CheckBox cB_Mostrar;
        private Panel p_Boton;
        private PictureBox btnRetornar;
    }
}