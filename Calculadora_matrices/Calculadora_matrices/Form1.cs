using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[,] matriz1;
        int[,] matriz2;
        int[,] matriz3;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            int fila = int.Parse(txb1.Text);
            int columna = int.Parse(txb2.Text);

            matriz1 = new int[fila, columna];
            dgvMatriz1.RowCount = fila;
            dgvMatriz1.ColumnCount = columna;
            

            matriz2 = new int[fila, columna];
            dgvMatriz2.ColumnCount = columna;
            dgvMatriz2.RowCount = fila;

            matriz3 = new int[fila, columna];
            dgvResultado.ColumnCount = columna;
            dgvResultado.RowCount = fila;

          for (int i = 0; i < fila; i++)
            {
                for (int k = 0; k < columna; k++)
                {
                    int result = 0;
                    if (int.TryParse(textBox1.Text, out result))
                    matriz1[i, k] = int.Parse(textBox1.Text);
                    textBox1.Clear();
                }
            }
            for (int i = 0; i < fila; i++)
            {
                for (int k = 0; k < columna; k++)
                {
                    dgvMatriz1.Rows[i].Cells[k].Value = matriz1[i, k];
                   
                }
            }
        }

        





    }
}
