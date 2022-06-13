using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Polynomial
    {
        internal static double[] multiply(double[] A, double[] B,
                            int m, int n)
        {
            //throw new NotImplementedException();
            double[] prod = new double[m + n - 1];


            for (int i = 0; i < m + n - 1; i++)
            {
                prod[i] = 0;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    prod[i + j] += A[i] * B[j];
                }
            }

            return prod;
        }
    }
}
