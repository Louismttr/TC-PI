namespace Vectores
{
    public class Vector
    {
        //Vector
        public double[]? Rotcev { get; set; }

        
        public Vector(double[] vec)
        {
            Rotcev = vec; 
        }

        public Func<double, double, double> SumVec = (A, B) => (A + B);
        public Func<double, double, double> ResVec = (A, B) => (A - B);

        #region Forma Canónica
        public void DeclaracionCanonica(double[] Rotcev)
        {
            switch (Rotcev.Length)
            {
                case 1: Console.WriteLine("V = {0}i", PosNeg(Rotcev)[0]); break;
                case 2: Console.WriteLine("V = {0}i {1}j", PosNeg(Rotcev)[0], PosNeg(Rotcev)[1]); break;
                case 3: Console.WriteLine("V = {0}i {1}j {2}k", PosNeg(Rotcev)[0], PosNeg(Rotcev)[1], PosNeg(Rotcev)[2]); break;
                default: Console.WriteLine("No se permite vectores mayores a R3, lo sentimos. Atte: Nelio (el capitán y único responsable)"); break;
            }
        }

        public string[] PosNeg(double[] Rotcev)
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
                    else { posx[i] = "- " + Rotcev[i]; }
                }
                return posx;
            }
            else { posx = new string[0]; return posx; }
        }
        #endregion

        #region Vector dado por Puntos (Punto A, Punto B)
        static double[] VectorPorPuntos(double[] puntoA, double[] puntoB)
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
            return string.Format("V = <{0}, {1}, {2}>", Rotcev[0], Rotcev[1], Rotcev[2]);
        }
        #endregion

        #region Distancia de dos puntos

        public double DistanciaPuntos(double[] Rotcev, double[] Vector)
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
        public static void ExpresionDistancia<Dist>(Dist distan)
        {
            Console.WriteLine("d(P1, P2) = {0}", distan);
        }
        #endregion

        #region Coordenadas del punto medio de un segmento

        public double[]? CoordenasMediasPP(double[] puno, double[] pdos)
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

        public void ExpresarMedia(double[] coormedia)
        {
            switch (coormedia.Length)
            {
                case 1:
                    Console.WriteLine("m({0})", coormedia[0]);
                    break;
                case 2:
                    Console.WriteLine("m({0}, {1})", coormedia[0], coormedia[1]);
                    break;
                case 3:
                    Console.WriteLine("m({0}, {1}, {2})",
                    coormedia[0], coormedia[1], coormedia[2]);
                    break;
            }
        }
        #endregion

        #region Normal del Vector, Vector Unitario, Coseno y Angulos Directores
        public double NormalV(double[] vector)
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

        public double[]? VUnitario(double[] vector)
        {
            double normal = NormalV(vector);
            double[] unitario = new double[vector.Length];
            if (normal != 0)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    unitario[i] = (1 / normal) * vector[i];
                }
                return unitario;
            }
            else return null;
        }

        public double[] CosenosDirectores(double[] vector)
        {
            double[] cosV = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {

                try
                {
                    cosV[i] = vector[i] / NormalV(vector);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
            }
            return cosV;
        }

        public double[] AngulosDirectores(double[] vector)
        {
            double[] cosV = CosenosDirectores(vector);
            double[] angV = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                angV[i] = Math.Acos(cosV[i]);
            }
            return angV;
        }

        public bool IdentidadCoseno(double[] vector)
        {
            double identidad = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                identidad += Math.Pow(vector[i], 2);
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