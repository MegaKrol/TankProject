using SampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1
{
    public class Optimization
    {
        public static int SimplexMethod(ref double[] p, double stepSize = 0.1, double tol = 1e-6, int maxIter = 1000)
        {
            int dim = p.Length;
            double[][] simplex = new double[dim + 1][];

            // Створення симплексу на основі початкової точки p
            simplex[0] = (double[])p.Clone();
            for (int i = 1; i <= dim; i++)
            {
                simplex[i] = (double[])p.Clone();
                simplex[i][i - 1] += stepSize;
            }

            double alpha = 0.1, rho = 0.5, sigma = 0.5;
            int iteration = 0;

            while (iteration < maxIter)
            {
                Array.Sort(simplex, (a, b) => Criteria.I2Criteria(a).CompareTo(Criteria.I2Criteria(b)));

                double[] best = simplex[0];
                double[] worst = simplex[dim];

                // Центроїд без найгіршої точки
                double[] centroid = new double[dim];
                for (int i = 0; i < dim; i++)
                    for (int j = 0; j < dim; j++)
                        centroid[j] += simplex[i][j] / dim;

                // Відбиття
                double[] reflected = new double[dim];
                for (int i = 0; i < dim; i++)
                    reflected[i] = centroid[i] + alpha * (centroid[i] - worst[i]);

                double f_reflected = Criteria.I2Criteria(reflected);
                double f_worst = Criteria.I2Criteria(worst);
                double f_best = Criteria.I2Criteria(best);

                if (f_reflected < Criteria.I2Criteria(simplex[dim - 1]))
                {
                    simplex[dim] = reflected;
                }
                else
                {
                    // Стиснення
                    double[] contracted = new double[dim];
                    for (int i = 0; i < dim; i++)
                        contracted[i] = centroid[i] + rho * (worst[i] - centroid[i]);

                    if (Criteria.I2Criteria(contracted) < f_worst)
                    {
                        simplex[dim] = contracted;
                    }
                    else
                    {
                        // Зменшення
                        for (int i = 1; i < simplex.Length; i++)
                            for (int j = 0; j < dim; j++)
                                simplex[i][j] = best[j] + sigma * (simplex[i][j] - best[j]);
                    }
                }

                // Перевірка збіжності
                double maxDiff = 0;
                for (int i = 0; i <= dim; i++)
                    maxDiff = Math.Max(maxDiff, Math.Abs(Criteria.I2Criteria(simplex[i]) - f_best));

                if (maxDiff < tol)
                    break;

                iteration++;
            }

            // Результат у p
            for (int i = 0; i < dim; i++)
                p[i] = simplex[0][i];

            return iteration;
        }
        public static string PointToString(double[] point, String caption = "")
        {
            string s = "";
            if (!String.IsNullOrEmpty(caption))
            {
                s += caption + " ";
            }
            for (int i = 0; i < point.Length; i++)
            {
                s += $"u[{i}]={point[i]} ";
            }
            return s;
        }
    }

}
