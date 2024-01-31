using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] produtos = new string[5];
            produtos[0] = "jatoba";
            produtos[1] = "cajamanga";
            produtos[2] = "seriguela";
            produtos[3] = "pequi";
            produtos[4] = "atemoia";

            for(int i=0;i<= produtos.GetUpperBound(0);i++)
            {
                listBox1.Items.Add(i + " - " + produtos[i]);
            }
            listBox1.Items.Add(new string('-',20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numeros = { 0, 50, 100, 150, 200, 250, 300, 350, 400 };
            for (int i = 0; i <= numeros.Length-1; i++)
            {
                listBox1.Items.Add("numeros[" + i + "] = " + numeros[i]);
            }
            listBox1.Items.Add(new string('-', 30));

            //nesse tem que listar todo o array
            foreach(int i in numeros)
            {
                listBox1.Items.Add("numeros = " + i);
            }
            listBox1.Items.Add(new string('-', 30));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[,] alunos = new string[5, 2];
            alunos[0, 0] = "Camila";
            alunos[1, 0] = "Vitor";
            alunos[2, 0] = "Hiago";
            alunos[3, 0] = "Tarcio";
            alunos[4, 0] = "PC";
            alunos[0, 1] = "Noiva";
            alunos[1, 1] = "A caça";
            alunos[2, 1] = "Tinder";
            alunos[3, 1] = "Casado";
            alunos[4, 1] = "Pegando todas";

            for(int i = 0; i <= alunos.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= alunos.GetUpperBound(1); j++)
                {
                    listBox1.Items.Add(alunos[i, j]);
                }
                listBox1.Items.Add(new string('-', 30));
            }
            listBox1.Items.Add(new string('-', 30));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Tem que adicionar a biblioteca Collections no topo using
            ArrayList lista = new ArrayList();
            lista.Add("jatoba");
            lista.Add("cajamanga");
            lista.Add("seriguela");
            lista.Add("pequi");
            lista.Add("atemoia");
            lista.Add("pitomba");

            lista.Remove("pequi");
            lista.Insert(2, "lichia");
            for(int i = 0; i <= lista.Count - 1; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
            listBox1.Items.Add(new string('-', 30));
        }
    }
}
