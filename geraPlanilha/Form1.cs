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
        public Form1()
        {
            InitializeComponent();
            txtAno.Text = DateTime.Today.Year.ToString();
            txtMes.Text = DateTime.Today.Month.ToString();
        }

        private void btnGeraPlanilha_Click(object sender, EventArgs e)
        {
            ManipuladorExcel m1 = new ManipuladorExcel("Escala de Folga");
            
            DateTime data = new DateTime(int.Parse(txtAno.Text), int.Parse(txtMes.Text), rbtnDia1.Checked ? 1 : 2);

            int guardaComecaMes = rbtnG1.Checked ? 1 : rbtnG2.Checked ? 2 : 3;

            m1.criarPlanilha(txtGuarda1.Text, txtGuarda2.Text, txtGuarda3.Text, data, guardaComecaMes, true);
        }
    }
}
