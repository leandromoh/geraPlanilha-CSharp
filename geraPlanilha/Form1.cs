using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geraPlanilha
{
    public partial class Form1 : Form
    {
        private string guard1;
        private string guard2;
        private string guard3;
        private int dia;
        private int mes;
        private int ano;
        private int nGuard;
        private int[] termos = new int[5];

        public Form1()
        {
            InitializeComponent();
            txtAno.Text = DateTime.Today.Year.ToString();
            txtMes.Text = DateTime.Today.Month.ToString();
        }

        private void btnGeraPlanilha_Click(object sender, EventArgs e)
        {
            ManipuladorExcel m1 = new ManipuladorExcel("Escala de Folga");

            guard1 = txtGuarda1.Text;
            guard2 = txtGuarda2.Text;
            guard3 = txtGuarda3.Text;

            ano = int.Parse(txtAno.Text);
            mes = int.Parse(txtMes.Text);
            dia = rbtnDia1.Checked ? 1 : 2;
            nGuard = rbtnG1.Checked ? 1 : rbtnG2.Checked ? 2 : 3;

            m1.criarCabecalhoAno("D3", "H3", ano);

            termos = new int[] { dia, mes, ano, nGuard, 6 };

            for (int i = 0; i < 4; i++, termos[4] += 2)
            {
                string a = termos[4].ToString();
                string b = (++termos[4]).ToString();

                m1.criarCabecalhoMes("B" + a, "J" + a, termos[1]);
                m1.criarCabecalhoNomeGuardas("B" + b, "E" + b, "H" + b, guard1, guard2, guard3);
                termos = m1.criarBlocoFolgaMes(termos[0], termos[1], termos[2], termos[3], ++termos[4]);
                m1.bordaContinua("B" + b, "J" + termos[4].ToString());
            }

            m1.larguraColuna("B1", 7);
            m1.larguraColuna("E1", 7);
            m1.larguraColuna("H1", 7);

            string f = termos[4].ToString();

            m1.alinharHorizontal("B6", "B" + f);
            m1.alinharHorizontal("E6", "E" + f);
            m1.alinharHorizontal("H6", "H" + f);

            string path = System.IO.Directory.GetCurrentDirectory();
            path += "\\ESCALA " + txtMes.Text + "-" + txtAno.Text + ".xlsx";

            m1.salvar(path);
            m1.fechar();
            m1.abrirArquivo(path);
        }
    }
}
