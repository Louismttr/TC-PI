using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vectorrot;

namespace pjAlgebraLineal
{
    public partial class fmrVectores : Form
    {
        public fmrVectores()
        {
            InitializeComponent();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //La propiedad DrawMode se cambia para dibujar a tabctrlMatroVec y a tabctrlVectorCalcula
        #region Pestañas
        private void tabctrlMatroVec_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabctrlMatroVec.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            //rectangulo que se dibuja sobre el titulo del tab 
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            //color por defecto del tab no seleccionado 
            SolidBrush sb = new SolidBrush(Color.FromArgb(((int)(((byte)(17)))),
                ((int)(((byte)(27)))), ((int)(((byte)(45))))));

            //color del tab que se selecciona
            if (tabctrlMatroVec.SelectedIndex == e.Index)
                sb.Color = Color.DarkSlateGray;

            //color sobre el tabpage actual 
            g.FillRectangle(sb, e.Bounds);

            //escribe el texto que tenia el tab 
            g.DrawString(tp.Text, tabctrlMatroVec.Font, new SolidBrush(Color.White), headerRect, sf);
        }

        private void tabctrlVectorCalcula_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics gra = e.Graphics;
            TabPage tp = tabctrlVectorCalcula.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            SolidBrush bs = new SolidBrush(Color.FromArgb(((int)(((byte)(17)))),
                ((int)(((byte)(27)))), ((int)(((byte)(45))))));

            if (tabctrlVectorCalcula.SelectedIndex == e.Index)
                bs.Color = Color.DarkSlateGray;

            gra.FillRectangle(bs, e.Bounds);

            gra.DrawString(tp.Text, tabctrlVectorCalcula.Font, new SolidBrush(Color.White), headerRect, sf);
        }

        #endregion

        //Elección de dimensión para ejecutar las acciones
        #region ComboBox
        private void cboDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDimension.SelectedIndex != -1)
            {
                lblRectov.Visible = true;
                panVector.Visible = true;
                tabctrlVectorCalcula.Visible = true;

                if (cboDimension.SelectedIndex == 1)
                {
                    lblY.Visible = true; txtYVec.Visible = true;
                    lblZ.Visible = false; txtZVec.Visible = false;

                    label11.Visible = true; txtVecYdos.Visible = true;
                    label10.Visible = false; txtVecdosZ.Visible = false;

                    label28.Visible = true; textBox9.Visible = true;
                    label27.Visible = false; textBox8.Visible = false;

                    label25.Visible = true; textBox3.Visible = true;
                    label20.Visible = false; textBox2.Visible = true;

                    label8.Visible = true; textBox6.Visible = true;
                    label6.Visible = false; textBox5.Visible = false;
                }
                else if (cboDimension.SelectedIndex == 2)
                {
                    lblY.Visible = true; txtYVec.Visible = true;
                    lblZ.Visible = true; txtZVec.Visible = true;

                    label11.Visible = true; txtVecYdos.Visible = true;
                    label10.Visible = true; txtVecdosZ.Visible = true;

                    label28.Visible = true; textBox9.Visible = true;
                    label27.Visible = true; textBox8.Visible = true;

                    label25.Visible = true; textBox3.Visible = true;
                    label20.Visible = true; textBox2.Visible = true;

                    label8.Visible = true; textBox6.Visible = true;
                    label6.Visible = true; textBox5.Visible = true;
                }
            }
            else
            {
                lblRectov.Visible = false;
                panVector.Visible = false;
                tabctrlVectorCalcula.Visible = false;
                lblY.Visible = false; txtYVec.Visible = false;
                lblZ.Visible = false; txtZVec.Visible = false;

                label11.Visible = false; txtVecYdos.Visible = false;
                label10.Visible = false; txtVecdosZ.Visible = false;

                label28.Visible = false; textBox9.Visible = false;
                label27.Visible = false; textBox8.Visible = false;

                label25.Visible = false; textBox3.Visible = false;
                label20.Visible = false; textBox2.Visible = false;

                label8.Visible = false; textBox6.Visible = false;
                label6.Visible = false; textBox5.Visible = false;
            }

        }

        private void cboVecPunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVecPunt.SelectedIndex == 1)
            {
                panel2.Visible = true;
                groupBox2.Visible = true;
                lblRectov.Text = "PuntoA:";
                btnCalcuCarac.Visible = true;
            }
            else
            {
                lblRectov.Text = "Vector:";
                panel2.Visible = false;
                groupBox2.Visible = false;
                btnCalcuCarac.Visible = true;
            }
        }

        private void cboArVolEcua_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboArVolEcua.SelectedIndex)
            {
                case 0:
                case 1:
                    label18.Visible = true;
                    panel5.Visible = true;
                    lblRectov.Text = "VectorA:";
                    label17.Text = "VectorB:";
                    label18.Visible = false;
                    panel5.Visible = false;
                    break;
                case 2:
                    lblRectov.Text = "VectorA:";
                    label17.Text = "Vector B:";
                    label18.Visible = true;
                    panel5.Visible = true;
                    break;
                case 3:
                    label17.Text = "Vector Perpendicular:";
                    lblRectov.Text = "Punto en el Plano:";
                    label18.Visible = false;
                    panel5.Visible = false;
                    break;
                default:
                    label18.Visible = false;
                    panel5.Visible = false;
                    break;

            }

        }
        #endregion

        //Control de Letras
        #region Textos Sin Letras

        private void txtXVec_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtYVec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtZVec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtXVecdos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVecYdos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVecdosZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

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

        //Botones Medio Dobles de Riesgo
        #region Botones de Acción
        //btnCalculaVec
        private void btnCalculaVec_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            txtVectorGenerado.Visible = false;
            txtFormaCanonica.Visible = false;
            btnLimpiar.Visible = true;
            switch (cboDimension.SelectedIndex)
            {
                case 0:
                    {
                        if (ValidandoCalculaVec(1) == "")
                        {
                            double[] xacto = new double[] { Double.Parse(txtXVec.Text) };

                            double[] otcax = new double[] { Double.Parse(txtXVecdos.Text) };

                            double[]? cebo = OperacionesVectoriales.SumaVectorial(xacto, otcax);
                            double[]? rest = OperacionesVectoriales.RestaVectorial(xacto, otcax);
                            double vecpunt = OperacionesVectoriales.PuntoV(xacto, otcax);
                            double[]? veccruz = OperacionesVectoriales.CruzV(xacto, otcax);
                            double vecangu = OperacionesVectoriales.AngulosEntreVectores(xacto, otcax);
                            double[]? vecproy = OperacionesVectoriales.ProyecciondeAsobreB(xacto, otcax);
                            bool vecparalel = OperacionesVectoriales.VerificacionParalelo(xacto, otcax);
                            bool vecortog = OperacionesVectoriales.VerificacionOrtogonal(xacto, otcax);

                            Vector vac = new Vector(cebo);
                            Vector setr = new Vector(rest);
                            Vector yorp = new Vector(vecproy);
                            Vector cruzada = new Vector(veccruz);

                            lblSumVec.Text = vac.ToString();
                            lblRestVec.Text = setr.ToString();
                            lblProductPunt.Text = vecpunt.ToString();
                            lblProductCruz.Text = cruzada.ToString();
                            lblAngulado.Text = vecangu.ToString();
                            lblProyAenB.Text = yorp.ToString();
                            if (vecparalel)
                                lblVoyaParalelo.Text = "Son Paralelos";
                            else lblVoyaParalelo.Text = "No son Paralelos";
                            if (vecortog)
                                lblOrtogonalismo.Text = "Son Ortogonales";
                            else lblOrtogonalismo.Text = "No son Ortogonales";
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese el " + ValidandoCalculaVec(1) + ".",
                                "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 1:
                    {
                        string hacer = ValidandoCalculaVec(2);
                        if (hacer == "")
                        {
                            double[] xacto = new double[] { Double.Parse(txtXVec.Text),
                            Double.Parse(txtYVec.Text) };

                            double[] otcax = new double[] { Double.Parse(txtXVecdos.Text),
                            Double.Parse(txtVecYdos.Text) };

                            double[]? cebo = OperacionesVectoriales.SumaVectorial(xacto, otcax);
                            double[]? rest = OperacionesVectoriales.RestaVectorial(xacto, otcax);
                            double vecpunt = OperacionesVectoriales.PuntoV(xacto, otcax);
                            double[]? veccruz = OperacionesVectoriales.CruzV(xacto, otcax);
                            double vecangu = OperacionesVectoriales.AngulosEntreVectores(xacto, otcax);
                            double[]? vecproy = OperacionesVectoriales.ProyecciondeAsobreB(xacto, otcax);
                            bool vecparalel = OperacionesVectoriales.VerificacionParalelo(xacto, otcax);
                            bool vecortog = OperacionesVectoriales.VerificacionOrtogonal(xacto, otcax);

                            Vector vac = new Vector(cebo);
                            Vector setr = new Vector(rest);
                            Vector yorp = new Vector(vecproy);
                            Vector cruzada = new Vector(veccruz);

                            lblSumVec.Text = vac.ToString();
                            lblRestVec.Text = setr.ToString();
                            lblProductPunt.Text = vecpunt.ToString();
                            lblProductCruz.Text = cruzada.ToString();
                            lblAngulado.Text = vecangu.ToString();
                            lblProyAenB.Text = yorp.ToString();
                            if (vecparalel)
                                lblVoyaParalelo.Text = "Son Paralelos";
                            else lblVoyaParalelo.Text = "No son Paralelos";
                            if (vecortog)
                                lblOrtogonalismo.Text = "Son Ortogonales";
                            else lblOrtogonalismo.Text = "No son Ortogonales";
                        }
                        else if (hacer != "")
                        {
                            MessageBox.Show("Por favor, ingrese el " + hacer + ".",
                                "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 2:
                    {
                        string hago = ValidandoCalculaVec(3);
                        if (hago == "")
                        {
                            double[] xacto = new double[] { Double.Parse(txtXVec.Text),
                            Double.Parse(txtYVec.Text), Double.Parse(txtZVec.Text) };

                            double[] otcax = new double[] { Double.Parse(txtXVecdos.Text),
                            Double.Parse(txtVecYdos.Text), Double.Parse(txtVecdosZ.Text) };

                            double[]? cebo = OperacionesVectoriales.SumaVectorial(xacto, otcax);
                            double[]? rest = OperacionesVectoriales.RestaVectorial(xacto, otcax);
                            double vecpunt = OperacionesVectoriales.PuntoV(xacto, otcax);
                            double[]? veccruz = OperacionesVectoriales.CruzV(xacto, otcax);
                            double vecangu = OperacionesVectoriales.AngulosEntreVectores(xacto, otcax);
                            double[]? vecproy = OperacionesVectoriales.ProyecciondeAsobreB(xacto, otcax);
                            bool vecparalel = OperacionesVectoriales.VerificacionParalelo(xacto, otcax);
                            bool vecortog = OperacionesVectoriales.VerificacionOrtogonal(xacto, otcax);

                            Vector vac = new Vector(cebo);
                            Vector setr = new Vector(rest);
                            Vector yorp = new Vector(vecproy);
                            Vector cruzada = new Vector(veccruz);

                            lblSumVec.Text = vac.ToString();
                            lblRestVec.Text = setr.ToString();
                            lblProductPunt.Text = vecpunt.ToString();
                            lblProductCruz.Text = cruzada.ToString();
                            lblAngulado.Text = vecangu.ToString();
                            lblProyAenB.Text = yorp.ToString();
                            if (vecparalel)
                                lblVoyaParalelo.Text = "Son Paralelos";
                            else lblVoyaParalelo.Text = "No son Paralelos";
                            if (vecortog)
                                lblOrtogonalismo.Text = "Son Ortogonales";
                            else lblOrtogonalismo.Text = "No son Ortogonales";
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese el " + hago + ".",
                                "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        //Validación de espacio de texto vacío para el btnCalculaVec
        private string ValidandoCalculaVec(int dimen)
        {
            switch (dimen)
            {
                case 1:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtXVecdos.Text.Trim().Length == 0)
                        {
                            txtXVecdos.Clear(); txtXVecdos.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else return "";
                    }
                case 2:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtXVecdos.Text.Trim().Length == 0)
                        {
                            txtXVecdos.Clear(); txtXVecdos.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (txtVecYdos.Text.Trim().Length == 0)
                        {
                            txtVecYdos.Clear(); txtVecYdos.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else return "";
                    }
                case 3:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (txtZVec.Text.Trim().Length == 0)
                        {
                            txtZVec.Clear(); txtZVec.Focus();
                            return "Valor en Z del Primer Vector";
                        }
                        else if (txtXVecdos.Text.Trim().Length == 0)
                        {
                            txtXVecdos.Clear(); txtXVecdos.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (txtVecYdos.Text.Trim().Length == 0)
                        {
                            txtVecYdos.Clear(); txtVecYdos.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else if (txtVecdosZ.Text.Trim().Length == 0)
                        {
                            txtVecdosZ.Clear(); txtVecdosZ.Focus();
                            return "Valor en Z del Segundo Vector";
                        }
                        else return "";
                    }
                default: return "";
            }
        }

        //btnCalaca
        private void btnCalaca_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            txtVectorGenerado.Visible = false;
            txtFormaCanonica.Visible = false;
            btnLimpiar.Visible = true;
            string haiga;
            switch (cboDimension.SelectedIndex)
            {
                case 0:
                    {
                        haiga = ValidandoCalaca(1);
                        switch (cboArVolEcua.SelectedIndex)
                        {
                            case 0:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text) };

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text) };

                                        double areaparale = Math.Round(AreaVolumenEcuaciones.AreaParalelogramo(primV, sencV), 4);
                                        lblArParalelo.Text = areaparale.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text) };

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text) };

                                        double areatria = Math.Round(AreaVolumenEcuaciones.AreaTriangulo(primV, sencV), 4);
                                        lblArTria.Text = areatria.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    break;
                                }
                            case 2:
                                {
                                    haiga = ValidandoCalaca(-1);
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text) };

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text) };

                                        double[] tercV = new double[] { Double.Parse(textBox1.Text) };

                                        double volpido = Math.Round(AreaVolumenEcuaciones.VolumenParalelepipedo(primV,
                                            sencV, tercV), 4);
                                        lblVolParalele.Text = volpido.ToString() + "u^3";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    MessageBox.Show("Lo sentimos, pero dicho procedimiento no es posible.",
                                    "ERROR [planteamiento incorrecto]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case 1:
                    {
                        haiga = ValidandoCalaca(2);
                        switch (cboArVolEcua.SelectedIndex)
                        {
                            case 0:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text) };

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text)};

                                        double areaparale = Math.Round(AreaVolumenEcuaciones.AreaParalelogramo(primV, sencV), 4);
                                        lblArParalelo.Text = areaparale.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text)};

                                        double areatria = Math.Round(AreaVolumenEcuaciones.AreaTriangulo(primV, sencV), 4);
                                        lblArTria.Text = areatria.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    haiga = ValidandoCalaca(-2);
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text)};

                                        double[] tercV = new double[] { Double.Parse(textBox1.Text),
                                    Double.Parse(textBox3.Text)};

                                        double volpido = Math.Round(AreaVolumenEcuaciones.VolumenParalelepipedo(primV,
                                            sencV, tercV), 4);
                                        lblVolParalele.Text = volpido.ToString() + "u^3";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    MessageBox.Show("Lo sentimos, pero dicho procedimiento no es posible.",
                                    "ERROR [planteamiento incorrecto]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        haiga = ValidandoCalaca(3);
                        switch (cboArVolEcua.SelectedIndex)
                        {
                            case 0:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text),
                                    Double.Parse(txtZVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text), Double.Parse(textBox8.Text)};

                                        double areaparale = Math.Round(AreaVolumenEcuaciones.AreaParalelogramo(primV, sencV), 4);
                                        lblArParalelo.Text = areaparale.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text),
                                    Double.Parse(txtZVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text), Double.Parse(textBox8.Text)};

                                        double areatria = Math.Round(AreaVolumenEcuaciones.AreaTriangulo(primV, sencV), 4);
                                        lblArTria.Text = areatria.ToString() + "u^2";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    haiga = ValidandoCalaca(-3);
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text),
                                    Double.Parse(txtZVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text), Double.Parse(textBox8.Text)};

                                        double[] tercV = new double[] { Double.Parse(textBox1.Text),
                                    Double.Parse(textBox3.Text), Double.Parse(textBox2.Text)};

                                        double volpido = Math.Round(AreaVolumenEcuaciones.VolumenParalelepipedo(primV,
                                            sencV, tercV), 4);
                                        lblVolParalele.Text = volpido.ToString() + "u^3";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (haiga == "")
                                    {
                                        double[] primV = new double[] { Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text),
                                    Double.Parse(txtZVec.Text)};

                                        double[] sencV = new double[] { Double.Parse(textBox7.Text),
                                    Double.Parse(textBox9.Text), Double.Parse(textBox8.Text)};

                                        lblEcuaPla.Text = AreaVolumenEcuaciones.EcuacionPlano(primV, sencV);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haiga + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        //Validación de espacio de texto vacío para el btnCalaca
        private string ValidandoCalaca(int dimen)
        {
            switch (dimen)
            {
                case 1:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else return "";
                    }
                case -1:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (textBox1.Text.Trim().Length == 0)
                        {
                            textBox1.Clear(); textBox1.Focus();
                            return "Valor en X del Tercer Vector";
                        }
                        else return "";
                    }
                case 2:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (textBox9.Text.Trim().Length == 0)
                        {
                            textBox9.Clear(); textBox9.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else return "";
                    }
                case -2:
                    {

                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (textBox9.Text.Trim().Length == 0)
                        {
                            textBox9.Clear(); textBox9.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else if (textBox1.Text.Trim().Length == 0)
                        {
                            textBox1.Clear(); textBox1.Focus();
                            return "Valor en X del Tercer Vector";
                        }
                        else if (textBox3.Text.Trim().Length == 0)
                        {
                            textBox3.Clear(); textBox3.Focus();
                            return "Valor en Y del Tercer Vector";
                        }
                        else return "";
                    }
                case 3:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (txtZVec.Text.Trim().Length == 0)
                        {
                            txtZVec.Clear(); txtZVec.Focus();
                            return "Valor en Z del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (textBox9.Text.Trim().Length == 0)
                        {
                            textBox9.Clear(); textBox9.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else if (textBox8.Text.Trim().Length == 0)
                        {
                            textBox8.Clear(); textBox8.Focus();
                            return "Valor en Z del Segundo Vector";
                        }
                        else return "";
                    }
                case -3:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (txtZVec.Text.Trim().Length == 0)
                        {
                            txtZVec.Clear(); txtZVec.Focus();
                            return "Valor en Z del Primer Vector";
                        }
                        else if (textBox7.Text.Trim().Length == 0)
                        {
                            textBox7.Clear(); textBox7.Focus();
                            return "Valor en X del Segundo Vector";
                        }
                        else if (textBox9.Text.Trim().Length == 0)
                        {
                            textBox9.Clear(); textBox9.Focus();
                            return "Valor en Y del Segundo Vector";
                        }
                        else if (textBox8.Text.Trim().Length == 0)
                        {
                            textBox8.Clear(); textBox8.Focus();
                            return "Valor en Z del Segundo Vector";
                        }
                        else if (textBox1.Text.Trim().Length == 0)
                        {
                            textBox1.Clear(); textBox1.Focus();
                            return "Valor en X del Tercer Vector";
                        }
                        else if (textBox3.Text.Trim().Length == 0)
                        {
                            textBox3.Clear(); textBox3.Focus();
                            return "Valor en Y del Tercer Vector";
                        }
                        else if (textBox2.Text.Trim().Length == 0)
                        {
                            textBox2.Clear(); textBox2.Focus();
                            return "Valor en Z del Tercer Vector";
                        }
                        else return "";
                    }
                default: return "";
            }
        }

        //btnCalcuCarac
        private void btnCalcuCarac_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            txtFormaCanonica.Visible = true;
            txtVectorGenerado.Visible = true;
            btnLimpiar.Visible = true;
            string haciendo;
            switch (cboDimension.SelectedIndex)
            {
                case 0:
                    {
                        switch (cboVecPunt.SelectedIndex)
                        {
                            case 0:
                                {
                                    haciendo = ValidandoCarac(1);
                                    if (haciendo == "")
                                    {
                                        double[] vecfect = new double[] { Double.Parse(txtXVec.Text) };
                                        CaracterVec(vecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    haciendo = ValidandoCarac(-1);
                                    if (haciendo == "")
                                    {
                                        double[] vec = new double[] { Double.Parse(txtXVec.Text) };
                                        double[] fect = new double[] { Double.Parse(textBox4.Text) };

                                        double[] vecfect = Vector.VectorPorPuntos(vec, fect);
                                        CaracterVec(vecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                case 1:
                    {
                        switch (cboVecPunt.SelectedIndex)
                        {
                            case 0:
                                {
                                    haciendo = ValidandoCarac(2);
                                    if (haciendo == "")
                                    {
                                        double[] vecfect = new double[] {Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text) };
                                        CaracterVec(vecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    haciendo = ValidandoCarac(-2);
                                    if (haciendo == "")
                                    {
                                        double[] vec = new double[] {Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text)};
                                        double[] fect = new double[] {Double.Parse(textBox4.Text),
                                    Double.Parse(textBox6.Text)};

                                        double[] vecfect = Vector.VectorPorPuntos(vec, fect);
                                        CaracterVec(vecfect);

                                        double distvecfect = Vector.DistanciaPuntos(vec, fect);
                                        lblDistanciaPuntos.Text = Vector.ExpresionDistancia<double>(distvecfect);
                                        double[]? medvecfect = Vector.CoordenasMediasPP(fect, vecfect);
                                        lblCoorPuntoMedio.Text = Vector.ExpresarMedia(medvecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                case 2:
                    {
                        switch (cboVecPunt.SelectedIndex)
                        {
                            case 0:
                                {
                                    haciendo = ValidandoCarac(3);
                                    if (haciendo == "")
                                    {
                                        double[] vecfect = new double[] {Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text), Double.Parse(txtZVec.Text)};
                                        CaracterVec(vecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    haciendo = ValidandoCarac(-3);
                                    if (haciendo == "")
                                    {
                                        double[] vec = new double[] {Double.Parse(txtXVec.Text),
                                    Double.Parse(txtYVec.Text), Double.Parse(txtZVec.Text) };
                                        double[] fect = new double[] {Double.Parse(textBox4.Text),
                                    Double.Parse(textBox6.Text), Double.Parse(textBox5.Text) };

                                        double[] vecfect = Vector.VectorPorPuntos(vec, fect);
                                        CaracterVec(vecfect);

                                        double distvecfect = Vector.DistanciaPuntos(vec, fect);
                                        lblDistanciaPuntos.Text = Vector.ExpresionDistancia<double>(distvecfect);
                                        double[]? medvecfect = Vector.CoordenasMediasPP(fect, vecfect);
                                        lblCoorPuntoMedio.Text = Vector.ExpresarMedia(medvecfect);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, ingrese el " + haciendo + ".",
                                         "ERROR [ausencia de valor]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        //Validación de espacio de texto vacío para el btnCalcuCarac
        private string ValidandoCarac(int dimen)
        {
            switch (dimen)
            {
                case 1:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else return "";
                    }
                case -1:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Punto";
                        }
                        else if (textBox4.Text.Trim().Length == 0)
                        {
                            textBox4.Clear(); textBox4.Focus();
                            return "Valor en X del Segundo Punto";
                        }
                        else return "";
                    }
                case 2:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else return "";
                    }
                case -2:
                    {

                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Punto";
                        }
                        else if (textBox4.Text.Trim().Length == 0)
                        {
                            textBox4.Clear(); textBox4.Focus();
                            return "Valor en X del Segundo Punto";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Punto";
                        }
                        else if (textBox6.Text.Trim().Length == 0)
                        {
                            textBox6.Clear(); textBox6.Focus();
                            return "Valor en Y del Segundo Punto";
                        }
                        else return "";
                    }
                case 3:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Vector";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Vector";
                        }
                        else if (txtZVec.Text.Trim().Length == 0)
                        {
                            txtZVec.Clear(); txtZVec.Focus();
                            return "Valor en Z del Primer Vector";
                        }
                        else return "";
                    }
                case -3:
                    {
                        if (txtXVec.Text.Trim().Length == 0)
                        {
                            txtXVec.Clear(); txtXVec.Focus();
                            return "Valor en X del Primer Punto";
                        }
                        else if (txtYVec.Text.Trim().Length == 0)
                        {
                            txtYVec.Clear(); txtYVec.Focus();
                            return "Valor en Y del Primer Punto";
                        }
                        else if (txtZVec.Text.Trim().Length == 0)
                        {
                            txtZVec.Clear(); txtZVec.Focus();
                            return "Valor en Z del Primer Punto";
                        }
                        else if (textBox4.Text.Trim().Length == 0)
                        {
                            textBox4.Clear(); textBox4.Focus();
                            return "Valor en X del Segundo Punto";
                        }
                        else if (textBox6.Text.Trim().Length == 0)
                        {
                            textBox6.Clear(); textBox6.Focus();
                            return "Valor en Y del Segundo Punto";
                        }
                        else if (textBox5.Text.Trim().Length == 0)
                        {
                            textBox5.Clear(); textBox5.Focus();
                            return "Valor en Z del Segundo Punto";
                        }
                        else return "";
                    }
                default: return "";
            }
        }

        //Esto se usa para evitar repetir código en el switch
        private void CaracterVec(double[] vecfect)
        {
            double normalito = Vector.NormalV(vecfect);
            double[]? unity = Vector.VUnitario(vecfect);
            double[] cosdirectriz = Vector.CosenosDirectores(vecfect);
            double[] angdirectriz = Vector.AngulosDirectores(vecfect);
            double[] nega = OperacionesVectoriales.OpuestoV(vecfect);

            Vector titi = new Vector(unity);
            Vector csono = new Vector(cosdirectriz); Vector anga = new Vector(angdirectriz);
            Vector opo = new Vector(nega);

            lblNormalVec.Text = normalito.ToString();
            lblVecUnit.Text = titi.ToString();
            lblCosDirect.Text = csono.ToString();
            lblAngDirect.Text = anga.ToString();
            lblOpuestVec.Text = opo.ToString();

            Vector vector = new Vector(vecfect);
            txtVectorGenerado.Text = vector.ToString();
            txtFormaCanonica.Text = Vector.DeclaracionCanonica(vecfect);
            if (Vector.IdentidadCoseno(vecfect))
                lblIdentidadCos.Text = "Cumple la identidad";
            else lblIdentidadCos.Text = "No cumple la identidad";
        }

        //Boton de Limpieza y cierre de pestañas menores
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboDimension.SelectedIndex = -1;
            cboArVolEcua.SelectedIndex = -1;
            cboVecPunt.SelectedIndex = -1;

            //Primer Vector
            txtXVec.Text = "";
            txtYVec.Text = "";
            txtZVec.Text = "";
            //Operaciones Vectoriales
            txtXVecdos.Text = "";
            txtVecYdos.Text = "";
            txtVecdosZ.Text = "";
            //Area, Volumen y Ecuacion del Plano
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";

            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";



            //Limpiando acción de btnCalculaCarac
            lblNormalVec.Text = "----";
            lblVecUnit.Text = "----";
            lblCosDirect.Text = "----";
            lblAngDirect.Text = "----";
            lblOpuestVec.Text = "----";
            txtVectorGenerado.Text = "";
            txtFormaCanonica.Text = "";
            lblIdentidadCos.Text = "cos^2(a)+cos^2(b)+cos^2(c) = 0";
            lblDistanciaPuntos.Text = "----";
            lblCoorPuntoMedio.Text = "----";


            //Limpiando acción de btnCalaca
            lblEcuaPla.Text = "----";
            lblVolParalele.Text = "----";
            lblArTria.Text = "----";
            lblArParalelo.Text = "----";

            //Limpiando acción de CalculaVec
            lblSumVec.Text = "----";
            lblRestVec.Text = "----";
            lblProductPunt.Text = "----";
            lblProductCruz.Text = "----";
            lblAngulado.Text = "----";
            lblProyAenB.Text = "----";
            lblVoyaParalelo.Text = "----";
            lblOrtogonalismo.Text = "----";

            //Ocultando btnLimpiar
            btnLimpiar.Visible = false;


        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
