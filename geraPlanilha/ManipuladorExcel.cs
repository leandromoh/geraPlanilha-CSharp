using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace geraPlanilha
{
    class ManipuladorExcel
    {
        private Data d1;
        private Excel.Application excel;
        private Excel.Workbook wb;
        private Excel.Worksheet ws;

        public ManipuladorExcel(string nome)
        {
            excel = new Excel.Application();
            wb = excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
            ws.Name = nome;
        }

        public void criarPlanilha(string guard1, string guard2, string guard3, DateTime date, int guardaComecaMes, bool openAfterCompleted)
        {
            int[] termos = new int[5];

            criarCabecalhoAno("D3", "H3", date.Year);

            termos = new int[] { date.Day, date.Month, date.Year, guardaComecaMes, 6 };

            for (int i = 0; i < 4; i++, termos[4] += 2)
            {
                string a = termos[4].ToString();
                string b = (++termos[4]).ToString();

                criarCabecalhoMes("B" + a, "J" + a, termos[1]);
                criarCabecalhoNomeGuardas("B" + b, "E" + b, "H" + b, guard1, guard2, guard3);
                termos = criarBlocoFolgaMes(termos[0], termos[1], termos[2], termos[3], ++termos[4]);
                bordaContinua("B" + b, "J" + termos[4]);
            }

            larguraColuna("B1", 7);
            larguraColuna("E1", 7);
            larguraColuna("H1", 7);

            alinharHorizontal("B6", "B" + termos[4]);
            alinharHorizontal("E6", "E" + termos[4]);
            alinharHorizontal("H6", "H" + termos[4]);

            string folder = Directory.GetCurrentDirectory();
            string fileName = string.Format("ESCALA {0}-{1}.xlsx", date.Month, date.Year);
            string path = Path.Combine(folder, fileName);

            salvar(path);
            fechar();

            if(openAfterCompleted)
                abrirArquivo(path);
        }

        public void salvar(string path)
        {
            wb.SaveAs(@path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        public void abrirArquivo(string path)
        {
            try
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = @path;
                myProcess.Start();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        public void fechar()
        {
            excel.Quit();
        }

        public void criarCabecalhoAno(string c1, string c2, int ano)
        {
            ws.get_Range(c1, c2).Merge();
            ws.get_Range(c1).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.get_Range(c1).Font.Bold = true;
            ws.get_Range(c1).Value = "ESCALA DE FOLGAS " + ano;
            ws.get_Range(c1).Font.Name = "Calibri";
            ws.get_Range(c1).Font.Size = 16;
        }

        public void criarCabecalhoMes(string c1, string c2, int mes)
        {
            ws.get_Range(c1, c2).Borders.Weight = Excel.XlBorderWeight.xlMedium;
            ws.get_Range(c1, c2).Merge();
            ws.get_Range(c1).Font.Bold = true;
            ws.get_Range(c1).Value = Data.getMesExtenso(mes).ToUpper();
            ws.get_Range(c1).Font.Name = "Calibri";
            ws.get_Range(c1).Font.Size = 16;
        }

        public void criarCabecalhoNomeGuardas(string c1, string c2, string c3, string g1, string g2, string g3)
        {
            string c0 = c1.Substring(1);
            string c4 = incrementCharacter(c1[0], 2) + c0;
            string c5 = incrementCharacter(c2[0], 2) + c0;
            string c6 = incrementCharacter(c3[0], 2) + c0;

            ws.get_Range(c1).Value = "Manha: " + g1;
            ws.get_Range(c2).Value = "Tarde: " + g2;
            ws.get_Range(c3).Value = "Noite: " + g3;

            ws.get_Range(c1).Font.Bold = true;
            ws.get_Range(c2).Font.Bold = true;
            ws.get_Range(c3).Font.Bold = true;

            ws.get_Range(c1, c4).Merge();
            ws.get_Range(c2, c5).Merge();
            ws.get_Range(c3, c6).Merge();
        }

        public void larguraColuna(string col, int tam)
        {
            ws.get_Range(col).EntireColumn.ColumnWidth = tam;
        }

        public void alinharHorizontal(string c1, string c2)
        {
            ws.get_Range(c1, c2).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }

        public void bordaContinua(string c1, string c2)
        {
            ws.get_Range(c1, c2).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        public void deletaIntervaloLinhas(string c1, string c2)
        {
            ws.get_Range(c1, c2).EntireRow.Delete();
        }

        public int[] criarBlocoFolgaMes(int dia, int mes, int ano, int guarda, int i)
        {
            int[] termos = new int[5];
            int i2 = i, j;
            bool b = true;
            d1 = new Data(dia, mes, ano);
            dia = guarda == 1 ? 0 : guarda == 2 ? 2 : 4;
            d1.sub(dia);
            dia = dia == 0 ? -1 : dia + 3;
            mes = (mes == 1 && d1.getMes() == 12) ? 2 : mes + 1;

            do
            {
                for (j = 2; j < 11; j += 2)
                {
                    Excel.Range ce = (ws.Cells[i, j] as Excel.Range);
                    Excel.Range cj = (ws.Cells[i, ++j] as Excel.Range);
                    Excel.Range cl = (ws.Cells[i, j + 1] as Excel.Range);

                    ws.Range[cj, cl].Merge();
                    ce.Value = d1.getDiaString() + " - ";
                    cj.Value = " " + d1.getDiaSemanaExtenso();

                    d1.soma(2);

                    if (d1.getMes() == mes || d1.getAno() > ano)
                    {
                        b = false;
                        break;
                    }
                }
                i++;
            }
            while (b);

            limpaPrimeiraLinhaBlocoFolgaMes(i2, dia);
            mesclaCellsUltimaLinhaBlocoFolgaMes(--i, j + 2);

            termos[0] = d1.getDia();
            termos[1] = d1.getMes();
            termos[2] = d1.getAno();
            termos[3] = j == 9 ? 1 : j == 6 ? 3 : 2;
            termos[4] = i;

            return termos;
        }

        private void limpaPrimeiraLinhaBlocoFolgaMes(int i, int lim)
        {
            for (int j = 2; j < lim; j++)
                ws.Cells[i, j].Value = String.Empty;
        }

        private void mesclaCellsUltimaLinhaBlocoFolgaMes(int i, int j)
        {
            for (; j < 11; j++)
            {
                Excel.Range cj = (ws.Cells[i, ++j] as Excel.Range);
                Excel.Range cl = (ws.Cells[i, ++j] as Excel.Range);

                ws.Range[cj, cl].Merge();
            }
        }

        private string incrementCharacter(char input, int increment)
        {
            return (input == 'Z' ? "A" : ((char)(input + increment)).ToString());
        }
    }
}