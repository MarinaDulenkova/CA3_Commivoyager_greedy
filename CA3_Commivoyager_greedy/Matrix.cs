using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3_Commivoyager_greedy
{
    class Matrix
    {
        public int[,] matrix;
        public int size;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="size">Размер матрицы</param>
        public Matrix(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }

        /// <summary>
        /// Заполнение матрицы из DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        public void FillFromGrid(DataGridView dgv)
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    if ((string)dgv.Rows[i + 1].Cells[j + 1].Value != "")
                        matrix[i, j] = Convert.ToInt32(dgv.Rows[i + 1].Cells[j + 1].Value);

        }
    }
}
