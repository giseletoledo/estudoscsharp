using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcessoMultiplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string instrucao = "Select * from cliente order by nome";
            string instrucao = string.Format("Select * from cliente where nome like '%{0}%' order by nome", textBox1.Text);
            string conexao = @"Data Source=TIT0489982W10-1;Initial Catalog=vendas;Integrated Security=True";
            //interprete, abre, pega os dados e fecha
            SqlDataAdapter da = new SqlDataAdapter(instrucao, conexao);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(SqlException ex)
            {
                MessageBox.Show("erro de banco " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("erro de aplicação " + ex.Message);
            }
        }
    }
}
