using ComparaServidores.Factory;
using ComparaServidores.Geracao;
using ComparaServidores.Processamento;
using ComparaServidores.Servidores;
using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparaServidores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gerar_Click(object sender, EventArgs e)
        {
            var noSelecionado = treeView.SelectedNode.Name;
            if (noSelecionado.Equals("Apollo"))
            {
                MessageBox.Show("Deve Selecionar registro filho.");
                return;
            }

            ocorrencias.Clear();

            ocorrencias.AppendText(string.Format(@"Iniciando... {0}", DateTime.Now));
            ocorrencias.Refresh();

            try
            {
                var caminho = CaminhoFactory.CreateInstance(noSelecionado);

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Processando: {0}", noSelecionado));
                ocorrencias.Refresh();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT3157"));
                ocorrencias.Refresh();

                var processadorNT3157 = new ProcessadorArquivos(new ServidorNT3157(caminho));
                processadorNT3157.Processar();

                var csv = new GeradorArquivoCSV(processadorNT3157);
                csv.GerarCabecalho();
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT3156"));
                ocorrencias.Refresh();

                var processadorNT3156 = new ProcessadorArquivos(new ServidorNT3156(caminho));
                processadorNT3156.Processar();
                csv.SetProcessadorArquivos(processadorNT3156);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT1519"));
                ocorrencias.Refresh();

                var processadorNT1519 = new ProcessadorArquivos(new ServidorNT1519(caminho));
                processadorNT1519.Processar();
                csv.SetProcessadorArquivos(processadorNT1519);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT1510"));
                ocorrencias.Refresh();

                var processadorNT1510 = new ProcessadorArquivos(new ServidorNT1510(caminho));
                processadorNT1510.Processar();
                csv.SetProcessadorArquivos(processadorNT1510);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT1505"));
                ocorrencias.Refresh();

                var processadorNT1505 = new ProcessadorArquivos(new ServidorNT1505(caminho));
                processadorNT1505.Processar();
                csv.SetProcessadorArquivos(processadorNT1505);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT888"));
                ocorrencias.Refresh();

                var processadorNT888 = new ProcessadorArquivos(new ServidorNT888(caminho));
                processadorNT888.Processar();
                csv.SetProcessadorArquivos(processadorNT888);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT50214"));
                ocorrencias.Refresh();

                var processadorNT50214 = new ProcessadorArquivos(new ServidorNT50214(caminho));
                processadorNT50214.Processar();
                csv.SetProcessadorArquivos(processadorNT50214);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT3158"));
                ocorrencias.Refresh();

                var processadorNT3158 = new ProcessadorArquivos(new ServidorNT3158(caminho));
                processadorNT3158.Processar();
                csv.SetProcessadorArquivos(processadorNT3158);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "1081"));
                ocorrencias.Refresh();

                var processadorNT1081 = new ProcessadorArquivos(new ServidorNT1081(caminho));
                processadorNT1081.Processar();
                csv.SetProcessadorArquivos(processadorNT1081);
                csv.GerarCorpo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Servidor: {0}", "NT1083"));
                ocorrencias.Refresh();

                var processadorNT1083 = new ProcessadorArquivos(new ServidorNT1083(caminho));
                processadorNT1083.Processar();
                csv.SetProcessadorArquivos(processadorNT1083);
                csv.GerarCorpo();

                csv.GerarArquivo();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(string.Format(@"Arquivo gerado: {0}", csv.GetCaminhoArquivo()));
                ocorrencias.Refresh();

                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(@"Processo Concluído!!!");
                ocorrencias.Refresh();
            }
            catch (Exception ex)
            {
                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(@"Erro!!!");
                ocorrencias.AppendText("\n");
                ocorrencias.AppendText(ex.Message);
                ocorrencias.Refresh();
            }
        }
    }
}
