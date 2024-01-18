using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AiSD_KR
{
    internal class GaussMethod
    {
        public static double[] SolveGauss(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                double maxElement = Math.Abs(matrix[i, i]);
                int maxIndex = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matrix[k, i]) > maxElement)
                    {
                        maxElement = Math.Abs(matrix[k, i]);
                        maxIndex = k;
                    }
                }

                for (int k = i; k < n + 1; k++)
                {
                    double temp = matrix[maxIndex, k];
                    matrix[maxIndex, k] = matrix[i, k];
                    matrix[i, k] = temp;
                }

                for (int k = i + 1; k < n; k++)
                {
                    double coeff = -matrix[k, i] / matrix[i, i];

                    for (int j = i; j < n + 1; j++)
                    {
                        if (i == j)
                        {
                            matrix[k, j] = 0;
                        }

                        else
                        {
                            matrix[k, j] += coeff * matrix[i, j];
                        }
                    }
                }
            }

            double[] result = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = matrix[i, n] / matrix[i, i];
                for (int k = i - 1; k >= 0; k--)
                {
                    matrix[k, n] -= matrix[k, i] * result[i];
                }
            }

            return result;
        }
    }
}
