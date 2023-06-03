namespace pjMatiz_1._1
{
    partial class frmResta
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.dgvMR = new System.Windows.Forms.DataGridView();
            this.dgvMB = new System.Windows.Forms.DataGridView();
            this.dgvMA = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Teal;
            this.btnSalir.Location = new System.Drawing.Point(497, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(501, 29);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.Teal;
            this.btnResta.Location = new System.Drawing.Point(11, 332);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(501, 29);
            this.btnResta.TabIndex = 24;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // txtColumnas
            // 
            this.txtColumnas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtColumnas.Location = new System.Drawing.Point(388, 48);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(125, 27);
            this.txtColumnas.TabIndex = 23;
            this.txtColumnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnas_KeyPress);
            this.txtColumnas.Leave += new System.EventHandler(this.txtColumnas_Leave);
            // 
            // txtFilas
            // 
            this.txtFilas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilas.Location = new System.Drawing.Point(388, 18);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(125, 27);
            this.txtFilas.TabIndex = 22;
            this.txtFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilas_KeyPress);
            this.txtFilas.Leave += new System.EventHandler(this.txtFilas_Leave);
            // 
            // dgvMR
            // 
            this.dgvMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMR.Location = new System.Drawing.Point(698, 127);
            this.dgvMR.Name = "dgvMR";
            this.dgvMR.RowHeadersWidth = 51;
            this.dgvMR.RowTemplate.Height = 29;
            this.dgvMR.Size = new System.Drawing.Size(300, 188);
            this.dgvMR.TabIndex = 21;
            // 
            // dgvMB
            // 
            this.dgvMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMB.Location = new System.Drawing.Point(347, 127);
            this.dgvMB.Name = "dgvMB";
            this.dgvMB.RowHeadersWidth = 51;
            this.dgvMB.RowTemplate.Height = 29;
            this.dgvMB.Size = new System.Drawing.Size(300, 188);
            this.dgvMB.TabIndex = 20;
            // 
            // dgvMA
            // 
            this.dgvMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMA.Location = new System.Drawing.Point(11, 127);
            this.dgvMA.Name = "dgvMA";
            this.dgvMA.RowHeadersWidth = 51;
            this.dgvMA.RowTemplate.Height = 29;
            this.dgvMA.Size = new System.Drawing.Size(300, 188);
            this.dgvMA.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(698, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Matriz Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(347, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Matriz B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Matriz A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(296, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Columnas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(296, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Resta de Matrices";
            // 
            // frmResta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1022, 386);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResta);
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
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "frmResta";
            this.Text = "frmResta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private Button btnResta;
        private TextBox txtColumnas;
        private TextBox txtFilas;
        private DataGridView dgvMR;
        private DataGridView dgvMB;
        private DataGridView dgvMA;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}