namespace Vectorrot
{
    public class Vector
    {
        //Vector
        public double[]? Rotcev { get; set; }

        
        public Vector(double[] vec)
        {
            Rotcev = vec; 
        }

        //Func con expresiones Lambda
        public static Func<double, double, double> SumVec = (A, B) => (A + B);
        public static Func<double, double, double> ResVec = (A, B) => (A - B);

        #region Forma Canónica
        public static string DeclaracionCanonica(double[] Rotcev)
        {
            switch (Rotcev.Length)
            {
                case 1: return "V = " + PosNeg(Rotcev)[0] + "i";
                case 2: return "V = " + PosNeg(Rotcev)[0] + "i " + PosNeg(Rotcev)[1] + "j";
                case 3: return "V = " + PosNeg(Rotcev)[0] + "i " + PosNeg(Rotcev)[1] + "j " + PosNeg(Rotcev)[2] + "k";
                default: return "No se permite vectores mayores a R3, lo sentimos.";
            }
        }

        public static string[] PosNeg(double[] Rotcev)
        {
            string[] posx = new string[Rotcev.Length];
            if (Rotcev.Length <= 3)
            {
                for (int i = 0; i < Rotcev.Length; i++)
                {
                    if (Rotcev[i] >= 0)
                    {
                        if (Rotcev[i] == Rotcev[0])
                        {
                            posx[i] = "" + Rotcev[i];
                        }
                        else
                        { posx[i] = "+ " + Rotcev[i]; }
                    }
                    else { posx[i] = "- " + (-1)*Rotcev[i]; }
                }
                return posx;
            }
            else { posx = new string[0]; return posx; }
        }
        #endregion

        #region Vector dado por Puntos (Punto A, Punto B)
        public static double[] VectorPorPuntos(double[] puntoA, double[] puntoB)
        {
            double[] vectorPorPuntos = new double[puntoA.Length];
            if (puntoA.Length == puntoB.Length)
            {
                if (puntoA.Length != 0)
                {
                    for (int i = 0; i < puntoA.Length; i++)
                    {
                        vectorPorPuntos[i] = puntoB[i] + puntoA[i];
                    }
                    return vectorPorPuntos;
                } else { return Array.Empty<double>(); }
            } else { return Array.Empty<double>(); }
        }

        public static void ExpresarPuntos<Valoro>(Valoro[] puntoX, Valoro[] puntoY)
        {
            if (puntoX.Length == puntoY.Length)
            {
                switch (puntoX.Length)
                {
                    case 1: Console.WriteLine("A({0}), B({1})",
                        puntoX[0], puntoY[0]); break;
                    case 2: Console.WriteLine("A({0}, {1}), B({2}, {3})",
                        puntoX[0], puntoX[1], puntoY[0], puntoY[1]); break;
                    case 3: Console.WriteLine("A({0}, {1}, {2}), B({3}, {4}, {5})",
                        puntoX[0], puntoX[1], puntoX[2], puntoY[0], puntoY[0], puntoY[1], puntoY[2]); break;
                    default: Console.WriteLine(
                        "No se admite vectores superiores (o inferiores) a R3"); break;
                }
            }
        }

        #endregion

        #region Forma Vectorial

        public override string ToString()
        {
            if (Rotcev.Length == 1)
            {
                return string.Format("v = <{0}>", Rotcev[0]);
            }
            else if (Rotcev.Length == 2)
            {
                return string.Format("v = <{0}, {1}>", Rotcev[0], Rotcev[1]);
            }
            else if (Rotcev.Length == 3)
            {
                return string.Format("V = <{0}, {1}, {2}>", Rotcev[0], Rotcev[1], Rotcev[2]);
            }
            else return string.Format("V");
        }
        #endregion

        #region Distancia de dos puntos

        public static double DistanciaPuntos(double[] Rotcev, double[] Vector)
        {
            double distan;
            switch (Rotcev.Length)
            {
                case 1:
                    {
                        distan = Rotcev[0] - Vector[0];

                        return distan;
                    }
                case 2:
                    {
                        distan = Math.Sqrt(Math.Pow((Rotcev[0] - Vector[0]), 2) +
                            Math.Pow((Rotcev[1] - Vector[1]), 2));

                        return distan;
                    }
                case 3:
                    {
                        distan = Math.Sqrt(Math.Pow((Rotcev[0] - Vector[0]), 2) +
                            Math.Pow((Rotcev[1] - Vector[1]), 2) +
                            Math.Pow((Rotcev[2] - Vector[2]), 2));

                        return distan;
                    }
                default: return -1;
            }
        }

        //Expresion de la distancia de dos puntos
        public static string ExpresionDistancia<Dist>(Dist distan)
        {
            return "d(P1, P2) = "+ distan;
        }
        #endregion

        #region Coordenadas del punto medio de un segmento

        public static double[]? CoordenasMediasPP(double[] puno, double[] pdos)
        {
            if (puno.Length == pdos.Length)
            {
                double[] coormedia = new double[puno.Length];

                for (int i = 0; i < puno.Length; i++)
                {
                    coormedia[i] = SumVec(puno[i], pdos[i]) / 2; //(puno[i] + pdos[i]) / 2;
                }
                return coormedia;
            }
            else return null;
        }

        public static string ExpresarMedia(double[] coormedia)
        {
            switch (coormedia.Length)
            {
                case 1:
                    return "m(" + coormedia[0] + ")";
                case 2:
                    return "m(" + coormedia[0] + ", " + coormedia[1] + ")";
                case 3:
                    return "m(" + coormedia[0] + ", " + coormedia[1] + ", " + coormedia[2] + ")";
                default:
                    return "";
            }
        }
        #endregion

        #region Normal del Vector, Vector Unitario, Coseno y Angulos Directores
        public static double NormalV(double[] vector)
        {
            double normal;
            double pren = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                pren += Math.Pow(vector[i], 2);
            }
            normal = Math.Sqrt(pren);
            return normal;
        }

        public static double[]? VUnitario(double[] vector)
        {
            double normal = NormalV(vector);
            double[] unitario = new double[vector.Length];
            if (normal != 0)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    unitario[i] = Math.Round(((1 / normal) * vector[i]), 2);
                }
                return unitario;
            }
            else return null;
        }

        public static double[] CosenosDirectores(double[] vector)
        {
            double[] cosV = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {

                try
                {
                    cosV[i] = Math.Round((vector[i] / NormalV(vector)), 2);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
            }
            return cosV;
        }

        public static double[] AngulosDirectores(double[] vector)
        {
            double[] cosV = CosenosDirectores(vector);
            double[] angV = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                angV[i] = Math.Round(Math.Acos(cosV[i]), 2);
            }
            return angV;
        }

        public static bool IdentidadCoseno(double[] vector)
        {
            double identidad = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                identidad += Math.Cos(Math.Cos(vector[i]));
            }
            if(identidad < 2 && identidad > 0)
            {
                return true;
            }
            else return false;
        }
        #endregion 

    }
}