using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgoritmosGrafos
{
    public partial class Grafos : Form
    {   
        Algoritmos algo = new Algoritmos();
        int[,] Matriz;
        int i = 0;
        int j = 0;
        int vertices;

        public Grafos()
        {
            InitializeComponent();           
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (num_updonw.Value < 1)
            {
                MessageBox.Show("Você deve entrar com um valor");
            }
            else
            {
                vertices = (int)num_updonw.Value - 1;
                
                pn_PainelVertices.Enabled = false;
                pn_GrafoDigrafo.Visible = true;
                Matriz = new int[(vertices+1), (vertices+1)];
                 lb_InformaVAlor.Text = "Informe o valor do posição A[" + (i+1) + "," + (j+1) + "]";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (i <= vertices && j <= vertices)
            {
                if (radio_0.Checked == false && radio_1.Checked == false)
                    MessageBox.Show("Voce deve selecionar algun valor");
                else if (radio_0.Checked == true)
                    Matriz[i, j] = 0;
                else
                    Matriz[i, j] = 1;

                j++;

                if (j > vertices)
                {
                    i++;
                    j = 0;

                }
                radio_0.Checked = false;
                radio_1.Checked = false;
                lb_InformaVAlor.Text = "Informe o valor do posição A[" + (i+1) + "," + (j+1) + "]";
                
                if (i > vertices)
                {
                    lb_InformaVAlor.Text = "Informe o valor do posição A[" + (i) + "," + (i) + "]";//apenas para designe 
                    pn_GrafoDigrafo.Enabled = false;
                    rd_alcancabilidade.Visible = true;
                    rd_wharshal.Visible = true;
                    rtxb_Matriz.Visible = true;
                }

            }
        }

        private void rd_wharshal_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_wharshal.Checked == true)
            {
                rtxb_Matriz.Text = "";

                int[,] M = algo.Wharshal(Matriz);

                for (int i = 0; i <= vertices; i++)
                {
                    for (int j = 0; j <= vertices; j++)
                    {
                        rtxb_Matriz.Text += M[i, j] + "\t";
                    }
                    rtxb_Matriz.Text += "\n";
                }
            }
            else
            {
                rtxb_Matriz.Text = "";
                for (int i = 0; i <= Math.Sqrt(Matriz.Length) - 1; i++)
                {
                    for (int j = 0; j <= Math.Sqrt(Matriz.Length) - 1; j++)
                    {
                        rtxb_Matriz.Text += Matriz[i, j] + "\t";
                        
                    }
                    rtxb_Matriz.Text += "\n";                    
                }
            }
        }

        private void rd_alcancabilidade_CheckedChanged(object sender, EventArgs e)
        {
            rd_wharshal_CheckedChanged(sender, e);
        }
    }
}
