using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorrot
{
    public class OperacionesVectoriales : Vector
    {
        //OperacionesVectoriales hereda de Vector
        public OperacionesVectoriales(double[] vec) : base( vec)
        {}


        #region Operaciones Basicas (de las basicas)
        //Suma Vectorial
        public static double[]? SumaVectorial(double[] vectorA, double[] vectorB)
        {
            if (vectorA.Length == vectorB.Length)
            {
                double[] sumVec = new double[vectorA.Length];
                for (int i = 0; i < vectorA.Length; i++)
                {
                    sumVec[i] = SumVec(vectorA[i], vectorB[i]); //vectorA[i] + vectorB[i];
                }
                return sumVec;
            }
            else return null;
        }
        //Resta Vectorial
        public static double[]? RestaVectorial(double[] vectorA, double[] vectorB)
        {
            if (vectorA.Length == vectorB.Length)
            {
                double[] sumVec = new double[vectorA.Length];
                for (int i = 0; i < vectorA.Length; i++)
                {
                    sumVec[i] = ResVec(vectorA[i], vectorB[i]); //vectorA[i] - vectorB[i];
                }
                return sumVec;
            }
            else return null;
        }
        #endregion 

        //Opuesto Vectorial
        public static double[] OpuestoV(double[] vector)
        {
            double[] rotcev = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                rotcev[i] = -(vector[i]);
            }
            return rotcev;
        }

        #region Productos (del mercado)
        //Producto de un escalar por un vector
        public static double[] ProductXEscalar(double[] vector, double escalar)
        {
            double[] vecalar = new double[vector.Length];
            for (int j = 0; j < vector.Length; j++)
            {
                vecalar[j] = (escalar * vector[j]);
            }
            return vecalar;
        }

        //Producto Punto de un Vector
        public static double PuntoV(double[] vectorA, double[] vectorB)
        {
            double puntoVec = 0;
            for(int i = 0; i < vectorA.Length; i++)
            {
                puntoVec += vectorA[i] * vectorB[i];
            }
            return puntoVec;
        }

        //Producto Cruz de un Vector
        public static double[]? CruzV(double[] vectorA, double[] vectorB)
        {
            double[] cruzV;
            switch(vectorA.Length)
            {
                case 1:
                    return new double[] { 0 };
                case 2:
                    cruzV = new double[] { 0, 0, 
                        ((vectorA[0] * vectorB[1]) - (vectorA[1] * vectorB[0])) };
                    return cruzV;
                case 3:
                    cruzV = new double[]
                        {
                            ((vectorA[1] * vectorB[2]) - (vectorA[2] * vectorB[1])),
                            -((vectorA[0] * vectorB[2]) - (vectorB[0] * vectorA[2])),
                            ((vectorA[0] * vectorB[1]) - (vectorB[0] * vectorA[1]))
                        };
                    return cruzV;
                default: return null;

            }
        }
        #endregion

        #region Angulos, Ortogonales y Paralelos
        public static double AngulosEntreVectores(double[] vecA, double[] torB)
        {
            double basado = NormalV(vecA) * NormalV(torB);
            double ang;
            try
            {
                ang = Math.Round(Math.Acos((PuntoV(vecA, torB)) / basado), 4);
                return ang;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se pude dividir entre cero");
                return 0;
            }
        }

        public static bool VerificacionOrtogonal(double[] vecA, double[] torB)
        {
            if(PuntoV(vecA, torB) == 0)
            {
                return true;
            }
            else return false;
        }

        public static bool VerificacionParalelo(double[] vecA, double[] torB)
        {
            if (torB[0] != 0)
            {
                switch (vecA.Length)
                {
                    case 1:
                        if (vecA[0] == torB[0])
                            return true;
                        else return false;

                    case 2:
                        if ((vecA[0] / torB[0]) == (vecA[1] / torB[1]))
                            return true;
                        else return false;

                    case 3:
                        if ((vecA[0] / torB[0]) == (vecA[1] / torB[1]) &&
                            (vecA[0] / torB[0]) == (vecA[2] / torB[2]))
                            return true;
                        else return false;

                    default: return false;
                }
            }else return false;
        }
        #endregion 

        //Proyecciones de vectores
        public static double[]? ProyecciondeAsobreB(double[] vecA, double[] torB)
        {
            try
            {
                double proyec = ((PuntoV(vecA, torB)) / Math.Pow(NormalV(torB), 2));
                double[] yecci = new double[vecA.Length];
                for (int i = 0; i < vecA.Length; i++)
                {
                    yecci[i] = Math.Round(vecA[i] * proyec, 2);
                }
                return yecci;
            }
            catch(DivideByZeroException)
            {
                return null;
            }
            
        }
    }
}
