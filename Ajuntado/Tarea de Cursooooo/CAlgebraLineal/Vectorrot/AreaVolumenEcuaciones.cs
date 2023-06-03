using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorrot
{
    public class AreaVolumenEcuaciones : OperacionesVectoriales
    {
        //AreaVolumenEcuaciones hereda de OperacionesVectoriales lo que hace que herede también de Vector
        public AreaVolumenEcuaciones(double[] vec) : base(vec){}

        #region Areas Vectoriales
        public static double AreaParalelogramo(double[] vecA, double[] torB)
        {
            return NormalV(vecA) * NormalV(torB) * Math.Sin(AngulosEntreVectores(vecA, torB));
        }

        public static double AreaTriangulo(double[] vecA, double[] torB)
        {
            return AreaParalelogramo(vecA, torB) / 2;
        }
        #endregion

        #region Volumen del Paralelepípedo y Ecuaciones del Plano
        //Volumen del Paralelepipedo
        public static double VolumenParalelepipedo(double[] vecA, double[] torB, double[] vrC)
        {
            double vparas = PuntoV(vecA, (CruzV(torB, vrC)));
            return vparas;

            //también se puede realizar de la siguiente manera
            /*return (vecA[0] * (torB[1] * vrC[2] - vrC[1] * torB[2])
                - vecA[1] * (torB[0] * vrC[2] - vrC[0] * torB[2])
                + vecA[2] * (torB[0] * vrC[1] - torB[1] * vrC[0]));*/
        }

        //Ecuación del plano
        public static string EcuacionPlano(double[] puntoPlano, double[] vectorPerpendicular)
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
            return ecuacionPlano + "= 0";
        }
        public static string EcuaMasMenos(double[] vectorPerpendicular, string[] cualquierPunto, double[] puntoPlano, int i)
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
