namespace pjMatiz_1._1
{
    partial class frmSuma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMA = new System.Windows.Forms.DataGridView();
            this.dgvMB = new System.Windows.Forms.DataGridView();
            this.dgvMR = new System.Windows.Forms.DataGridView();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.p_Boton = new System.Windows.Forms.Panel();
            this.btnSaliir = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).BeginInit();
            this.p_Boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaliir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(274, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(274, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columnas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matriz A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(304, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matriz B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(607, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matriz Resultado";
            // 
            // dgvMA
            // 
            this.dgvMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMA.Location = new System.Drawing.Point(0, 242);
            this.dgvMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMA.Name = "dgvMA";
            this.dgvMA.RowHeadersWidth = 51;
            this.dgvMA.RowTemplate.Height = 29;
            this.dgvMA.Size = new System.Drawing.Size(262, 141);
            this.dgvMA.TabIndex = 6;
            // 
            // dgvMB
            // 
            this.dgvMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMB.Location = new System.Drawing.Point(304, 242);
            this.dgvMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMB.Name = "dgvMB";
            this.dgvMB.RowHeadersWidth = 51;
            this.dgvMB.RowTemplate.Height = 29;
            this.dgvMB.Size = new System.Drawing.Size(262, 141);
            this.dgvMB.TabIndex = 7;
            // 
            // dgvMR
            // 
            this.dgvMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMR.Location = new System.Drawing.Point(607, 242);
            this.dgvMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMR.Name = "dgvMR";
            this.dgvMR.RowHeadersWidth = 51;
            this.dgvMR.RowTemplate.Height = 29;
            this.dgvMR.Size = new System.Drawing.Size(262, 141);
            this.dgvMR.TabIndex = 8;
            // 
            // txtFilas
            // 
            this.txtFilas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFilas.Location = new System.Drawing.Point(380, 99);
            this.txtFilas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(110, 23);
            this.txtFilas.TabIndex = 9;
            this.txtFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilas_KeyPress);
            this.txtFilas.Leave += new System.EventHandler(this.txtFilas_Leave);
            // 
            // txtColumnas
            // 
            this.txtColumnas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtColumnas.Location = new System.Drawing.Point(380, 149);
            this.txtColumnas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(110, 23);
            this.txtColumnas.TabIndex = 10;
            this.txtColumnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnas_KeyPress);
            this.txtColumnas.Leave += new System.EventHandler(this.txtColumnas_Leave);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Teal;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuma.Location = new System.Drawing.Point(1, 417);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(428, 31);
            this.btnSuma.TabIndex = 11;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // p_Boton
            // 
            this.p_Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.p_Boton.Controls.Add(this.bntSalir);
            this.p_Boton.Controls.Add(this.btnSaliir);
            this.p_Boton.Controls.Add(this.btn_Cerrar);
            this.p_Boton.Controls.Add(this.label7);
            this.p_Boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Boton.Location = new System.Drawing.Point(0, 0);
            this.p_Boton.Name = "p_Boton";
            this.p_Boton.Size = new System.Drawing.Size(881, 48);
            this.p_Boton.TabIndex = 27;
            // 
            // btnSaliir
            // 
            this.btnSaliir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaliir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaliir.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btnSaliir.Location = new System.Drawing.Point(1543, 3);
            this.btnSaliir.Name = "btnSaliir";
            this.btnSaliir.Size = new System.Drawing.Size(40, 40);
            this.btnSaliir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaliir.TabIndex = 2;
            this.btnSaliir.TabStop = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(2154, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(40, 40);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Suma de Matrices";
            // 
            // bntSalir
            // 
            this.bntSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalir.Image = global::pjAlgebraLineal.Properties.Resources.Cerrar;
            this.bntSalir.Location = new System.Drawing.Point(829, 5);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(40, 40);
            this.bntSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bntSalir.TabIndex = 14;
            this.bntSalir.TabStop = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // frmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(881, 472);
            this.Controls.Add(this.p_Boton);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.dgvMR);
            this.Controls.Add(this.dgvMB);
            this.Controls.Add(this.dgvMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSuma";
            this.Text = "frmSuma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).EndInit();
            this.p_Boton.ResumeLayout(false);
            this.p_Boton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaliir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvMA;
        private DataGridView dgvMB;
        private DataGridView dgvMR;
        private TextBox txtFilas;
        private TextBox txtColumnas;
        private Button btnSuma;
        private Panel p_Boton;
        private PictureBox btnSaliir;
        private PictureBox btn_Cerrar;
        private Label label7;
        private PictureBox bntSalir;
    }
}