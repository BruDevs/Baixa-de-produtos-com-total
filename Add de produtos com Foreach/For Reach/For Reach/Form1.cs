using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Reach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vUnit, vTotal, total = 0;
            int qtd;
            string nome;

            nome = txtProduto.Text;
            qtd = Convert.ToInt32(txtQtd.Text);
            vUnit = Convert.ToDouble(txtVunitario.Text);
            vTotal = qtd * vUnit;

            dataGridView1.Rows.Add(nome, vUnit, qtd, vTotal);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }

            txtTotal.Text = Convert.ToDouble(total).ToString("C");

            limpar();
           

        }

        private void limpar() 
        {
            txtProduto.Clear();
            txtQtd.Clear();
            txtVunitario.Clear();
        }
    }
}
