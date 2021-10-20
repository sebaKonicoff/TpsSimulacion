using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoTp4.Distribucion
{
    class Distribuciones
    {
        private static double variable1, variable2, z1, z2;
        // genera un valor aleatorio aplicando la distribucion uniforme
        public static double generarUniforme(double min, double max, double rnd)
        {
            double v;          
            v = Math.Round(rnd * (max - min) + min, 4);
            return v;
        }
        
        // genera un valor aleatorio aplicando la distribucion exponencial
        public static double generarExponencial(double media, double rnd)
        {
            double v;
            v = Math.Round(-media * Math.Log(1 - rnd), 4);
            return v;

        }
      
        // genera dos valores aleatorios aplicando la distribucion normal
        public static double[] generarNormal(int n, double media, double desviacion)
        {
            
            double pi = Math.PI;
            Random r1 = new Random();

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
    }
}
