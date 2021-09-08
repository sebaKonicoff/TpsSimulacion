using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Distribucion
    {
        private static Random RND = new Random();
        private static Random r1;
        private static double pi, variable1, variable2, z1, z2;

        // genera un valor aleatorio aplicando la distribucion uniforme
        public static double[] generarUniforme(double min, double max, int n)
        {
            double[] v = new double[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = Math.Round(RND.NextDouble() * (max - min) + min, 4);
            }
            return v;
        }

        // genera un valor aleatorio aplicando la distribucion exponencial
        public static double[] generarExponencial(double media, int n)
        {
            double[] v = new double[n];
            for (int i = 0; i < n; i++)
            {

                v[i] = Math.Round(-media * Math.Log(1 - RND.NextDouble()), 4);

            }

            return v;

        }

        // genera dos valores aleatorios aplicando la distribucion normal
        public static double[] generarNormal(int n, double media, double desviacion)
        {
            pi = Math.PI;
            r1 = new Random();

            double[] v = new double[n];


            for (int i = 0; i < v.Length; i = i + 2)
            {

                double aux1 = r1.NextDouble();
                double aux2 = r1.NextDouble();

                z1 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Sin(2 * pi * aux2));
                z2 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Cos(2 * pi * aux2));
                variable1 = media + desviacion * z1;
                variable2 = media + desviacion * z2;

                v[i] = Math.Round(variable1, 4);
                if (i + 1 != v.Length)
                    v[i + 1] = Math.Round(variable2, 4);
            }

            return v;
        }

        // genera un valor aleatorio aplicando la distribucion Poisson
        public static double[] generarPoisson(double lambda, int n)
        {
            double[] v = new double[n];

            double p;
            double x;
            double u;
            double a = Math.Exp(-lambda);
            r1 = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                p = 1;
                x = -1;
                do
                {
                    u = r1.NextDouble();
                    p *= u;

                    x++;
                } while (p >= a);

                v[i] = x;
            }
            return v;
        }

    }
}