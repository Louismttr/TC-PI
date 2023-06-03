using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjMatiz_1._1
{
    public partial class frmMulti : Form
    {
        #region atributos
        int fila = 0;
        int columna = 0;

        double[,] MatrizA = new double[100, 100];
        double[,] MatrizB = new double[100, 100];
        double[,] MatrizR = new double[100, 100];
        public frmMulti()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        public string ValorCelda(int columna, int fila, DataGridView dgvThink)
        {
            object celda = dgvThink[columna, fila].Value;
            return celda == null ? "" : celda.ToString();
        }
        public void ActivarMatrizA()
        {
            if (int.TryParse(txtFilas.Text, out fila) && int.TryParse(txtColumnas.Text, out columna))
            {
                dgvMA.ColumnCount = columna;
                dgvMA.RowCount = fila;

                //Hacer visible el componente del coeficiente
                dgvMA.Visible = true;

                //dimensionar matriz
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        dgvMA.Columns[j].HeaderText = j.ToString();
                        dgvMA.Columns[j].Width = 40;
                        dgvMA[j, i].Value = 1;
                    }
                }
            }
        }
        public void ActivarMatrizB()
        {
            if (int.TryParse(txtFilas.Text, out fila) && int.TryParse(txtColumnas.Text, out columna))
            {
                dgvMB.ColumnCount = columna;
                dgvMB.RowCount = fila;

                //Hacer visible el componente del coeficiente
                dgvMB.Visible = true;

                //dimensionar matriz
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        dgvMB.Columns[j].HeaderText = j.ToString();
                        dgvMB.Columns[j].Width = 40;
                        dgvMB[j, i].Value = 1;
                    }
                }
            }
        }
        public static void InicializarMatriz(int fila, int columna, ref double[,] Matriz)
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Matriz[i, j] = 0;
                }
            }
        }
        public void MutiplicacionMatrices()
        {
            //Recuperar coeficientes de la primera matriz (datagriedview1)
            InicializarMatriz(fila, columna, ref MatrizA);
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    double co = 0;
                    if (double.TryParse(ValorCelda(j, i, dgvMA), out co))
                        MatrizA[i, j] = co;
                }
            }

            //Recuperar coeficientes de la segunda matriz (datagriedview2)
            InicializarMatriz(fila, columna, ref MatrizB);
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    double co = 0;
                    if (double.TryParse(ValorCelda(j, i, dgvMB), out co))
                        MatrizB[i, j] = co;
                }
            }

            //Multiplicacion de Matrices
            if(txtFilas.Text == txtColumnas.Text)
            {
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        MatrizR[i, j] = 0;
                        for (int k = 0; k < columna; k++)
                        {
                            MatrizR[i, j] = (MatrizA[i, k] * MatrizB[k, j]) + MatrizR[i, j];
                        }
                    }
                }

                //Mostrar Resultados
                dgvMR.ColumnCount = columna;
                dgvMR.RowCount = fila;

                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        dgvMR.Columns[j].HeaderText = i.ToString();
                        dgvMR.Columns[j].Width = 40;
                        dgvMR[j, i].Value = MatrizR[i, j].ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Las filas deben de ser iguales a las columnas", "Matriz Multiplicacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        #region filas y columnas
        private void txtFilas_Leave(object sender, EventArgs e)
        {
            ActivarMatrizA();
            ActivarMatrizB();
        }

        private void txtColumnas_Leave(object sender, EventArgs e)
        {
            ActivarMatrizA();
            ActivarMatrizB();
        }
        #endregion

        private void btnMulti_Click(object sender, EventArgs e)
        {
            MutiplicacionMatrices();
        }

        #region Validaciones
        private void txtFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtColumnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnSaliir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_Boton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
