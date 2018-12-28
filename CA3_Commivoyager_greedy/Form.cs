using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3_Commivoyager_greedy
{
    public partial class fmMain : System.Windows.Forms.Form
    {
        private Matrix matrix;


        public fmMain()
        {
            InitializeComponent();
        }
             
        private void fmMain_Load(object sender, EventArgs e)
        {
            InitTable();
            matrix = new Matrix((int)nudSize.Value);
        }

        void InitTable()
        {
            int n = (int)nudSize.Value;
            dgvMatrix.RowCount = n + 1;
            dgvMatrix.ColumnCount = n + 1;
            foreach (DataGridViewRow row in dgvMatrix.Rows)
                row.Height = dgvMatrix.Columns[0].Width;
            dgvMatrix.Height = (int)(dgvMatrix.Rows[0].Height * (n + 1)) + 3;
            for (int i = 0; i < n + 1; ++i)
            {
                for (int j = 1; j < n + 1; ++j)
                {
                    dgvMatrix.Rows[i].Cells[j].Value = "";
                }

                dgvMatrix.Rows[0].Cells[i].Value = i.ToString();
                dgvMatrix.Rows[0].Cells[i].ReadOnly = true;
                dgvMatrix.Rows[0].Cells[i].Style.BackColor = Color.Snow;

                dgvMatrix.Rows[i].Cells[0].Value = i.ToString();
                dgvMatrix.Rows[i].Cells[0].ReadOnly = true;
                dgvMatrix.Rows[i].Cells[0].Style.BackColor = Color.Snow;

                dgvMatrix.Rows[i].Cells[i].Value = "";
                dgvMatrix.Rows[i].Cells[i].ReadOnly = true;
                dgvMatrix.Rows[i].Cells[i].Style.BackColor = Color.DimGray;
            }
            dgvMatrix.Rows[0].Cells[0].Selected = false;
            dgvMatrix.Update();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            matrix.FillFromGrid(dgvMatrix);
            int[] perm;
            TimeSpan time;
            lblExact.Text = "";
            lblGreedy.Text = "";
            String str = "Длина пути: " + new Solver(matrix).SolveTaskWithRecursion(out perm, out time, matrix).ToString() + '\n';
            foreach (int i in perm)
                str += (i + 1).ToString() + " - ";
            str += "1\n" + "Время: " + time.ToString();
            lblExact.Text = str;

            str = "Длина пути: " + new Solver(matrix).SolveTaskWithGreedy(out perm, out time, matrix).ToString() + '\n';
            foreach (int i in perm)
                str += (i + 1).ToString() + " - ";
            str += "1\n" + "Время: " + time.ToString();
            lblGreedy.Text = str;
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            InitTable();
            matrix = new Matrix((int)nudSize.Value);
            lblExact.Text = "";
            lblGreedy.Text = "";
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int32.Parse((string)dgvMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            catch
            {
                dgvMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
            finally
            {
                lblExact.Text = "";
                lblGreedy.Text = "";
            }
        }

        private void fillRand()
        {
            Random rand = new Random();
            int n = (int)nudSize.Value;
            for (int i = 1; i < n + 1; ++i)
                for (int j = 1; j < n + 1; ++j)
                {
                    if (i != j)
                        dgvMatrix.Rows[i].Cells[j].Value = rand.Next(1, 25).ToString();
                }
            dgvMatrix.Update();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            lblExact.Text = "";
            lblGreedy.Text = "";
            fillRand();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string message = "Коммивояжер. \nТорговец должен выйти из первого города, посетить по одному разу в неизвестном порядке города 2,3,4, … N и вернуться в первый город, чтобы путь коммивояжера был кратчайшим. \nИзвестна матрица расстояний между городами. Необходимо сравнить скорость работы точного и жадного алгоритмов.\n";
            MessageBox.Show(message, "Help", MessageBoxButtons.OK);
        }
    }
}
