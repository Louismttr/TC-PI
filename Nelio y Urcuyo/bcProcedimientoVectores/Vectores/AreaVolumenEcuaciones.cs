using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class AreaVolumenEcuaciones : OperacionesVectoriales
    {
        public AreaVolumenEcuaciones(double[] vec) : base(vec){}

        #region Areas Vectoriales
        public double AreaParalelogramo(double[] vecA, double[] torB)
        {
            return NormalV(vecA) * NormalV(torB) * Math.Sin(AngulosEntreVectores(vecA, torB));
        }

        public double AreaTriangulo(double[] vecA, double[] torB)
        {
            return (1 / 2) * AreaParalelogramo(vecA, torB);
        }
        #endregion

        #region Volumen del Paralelepípedo y Ecuaciones del Plano
        //Volumen del Paralelepipedo
        public double VolumenParalelepipedo(double[] vecA, double[] torB, double[] vrC)
        {
            return (vecA[0] * (torB[1] * vrC[2] - vrC[1] * torB[2])
                - vecA[1] * (torB[0] * vrC[2] - vrC[0] * torB[2])
                + vecA[2] * (torB[0] * vrC[1] - torB[1] * vrC[0]));
        }

        //Ecuación del plano
        public void EcuacionPlano(double[] puntoPlano, double[] vectorPerpendicular)
        {
            string[] cualquierPunto = new string[] { "X", "Y", "Z" };
            string[] vectorPuntos = new string[cualquierPunto.Length];
            string ecuacionPlano = "";
            for (int i = 0; i < cualquierPunto.Length; i++)
            {
                puntoPlano[i] = -puntoPlano[i] * vectorPerpendicular[i];
                if (puntoPlano[i] < 0)
                {
                    #region Referencia para punto menor a 0
                    /*if (vectorPerpendicular[i] == vectorPerpendicular[0])
                    {
                        vectorPuntos[i] = "(" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") ";
                    }
                    else vectorPuntos[i] = "+ (" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") ";*/
                    #endregion
                    vectorPuntos[i] = EcuaMasMenos(vectorPerpendicular, cualquierPunto, puntoPlano, i);

                }
                else if (puntoPlano[i] > 0)
                {
                    #region Referencia para punto mayor a 0
                    /*if (vectorPerpendicular[i] == vectorPerpendicular[0])
                    {
                        vectorPuntos[i] = "(" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") ";
                    }
                    else vectorPuntos[i] = "+ (" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") ";*/
                    #endregion
                    vectorPuntos[i] = EcuaMasMenos(vectorPerpendicular, cualquierPunto, puntoPlano, i);
                }
                else
                {
                    if (vectorPerpendicular[i] == vectorPerpendicular[0])
                    {
                        vectorPuntos[i] = "(" + vectorPerpendicular[i] + cualquierPunto[i] + ") ";
                    }
                    else vectorPuntos[i] = "+ (" + vectorPerpendicular[i] + cualquierPunto[i] + ") ";
                }

                ecuacionPlano += vectorPuntos[i];
            }
            Console.WriteLine(ecuacionPlano + "= 0");
        }
        public string EcuaMasMenos(double[] vectorPerpendicular, string[] cualquierPunto, double[] puntoPlano, int i)
        {
            string a = "";
            if (vectorPerpendicular[i] == vectorPerpendicular[0])
            {
                a = "(" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") ";
                return a;
            }
            else a = "+ (" + vectorPerpendicular[i] + cualquierPunto[i] + ") + (" + puntoPlano[i] + ") "; return a;
        }
        #endregion

    }
}
