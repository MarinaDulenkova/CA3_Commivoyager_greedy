using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_Commivoyager_greedy
{
    class Solver
    {
        private int[] pth;
        private int[] pthRes;
        private HashSet<int> notVisited;
        private int lengthMin;
        public int Size { get; set; }

        const int MAX_VALUE = int.MaxValue;

        public Solver(Matrix matrix)
        {
            pth = new int[matrix.size];
            notVisited = new HashSet<int>();
        }


        /// <summary>
        /// Жадный алгоритм (по минимальному расстоянию до следующего города)
        /// </summary>
        /// <param name="i">Текущий город</param>
        /// <param name="k">Кол-во пройденных городов</param>
        /// <param name="lenght">Длина пройденного пути</param>
        /// <param name="matrix">Матрица с длинами пути между городами</param>
        /// <returns></returns>
        private void GreedyMethod(int i, ref int k, ref int lenght, Matrix matrix)
        {
            if (notVisited.Count > 0)
            {
                int len = MAX_VALUE;
                int goodCity = -1;
                for (int j = 1; j < matrix.size; j++)
                {
                    if (notVisited.Contains(j))
                    {
                        if (matrix.matrix[i, j] < len)
                        {
                            len = matrix.matrix[i, j];
                            goodCity = j;
                        }
                    }
                }
                lenght += len;
                notVisited.Remove(goodCity);
                pthRes[++k] = goodCity;
                GreedyMethod(goodCity, ref k, ref lenght, matrix);
            }
            else
            {
                lenght += matrix.matrix[i, 0];
            }
        }

        /// <summary>
        /// Решение задачи с помощью жадного алгоритма
        /// </summary>
        /// <param name="pth">Итоговый путь</param>
        /// <param name="time">Время работы алгоритма</param>
        /// <returns>Длина пути</returns>
        public int SolveTaskWithGreedy(out int[] pth, out TimeSpan time, Matrix matrix)
        {
            const int INIT_LEN = 0, INIT_K = 0;
            DateTime start = DateTime.Now;

            for (int i = 1; i < matrix.size; ++i)
                notVisited.Add(i);
            lengthMin = INIT_LEN;
            pthRes = new int[matrix.size];
            int k = INIT_K;

            GreedyMethod(0, ref k, ref lengthMin, matrix);

            time = DateTime.Now - start;

            pth = pthRes;
            return lengthMin;
        }
    }
}
