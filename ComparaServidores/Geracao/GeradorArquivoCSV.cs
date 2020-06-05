using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Geracao
{
    public class GeradorArquivoCSV : IGeradorArquivo
    {
        private StringBuilder Dados;
        private IProcessadorArquivos ProcessadorArquivos;
        private string CaminhoArquivo;

        public GeradorArquivoCSV(IProcessadorArquivos processadorArquivos)
        {
            Dados = new StringBuilder();
            ProcessadorArquivos = processadorArquivos;
        }

        public void GerarArquivo()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            CaminhoArquivo = string.Format(@"{6}\Binarios{0}{1}{2}{3}{4}{5}.csv",
                DateTime.Now.Year, 
                DateTime.Now.Month, 
                DateTime.Now.Day, 
                DateTime.Now.Hour, 
                DateTime.Now.Minute, 
                DateTime.Now.Second,
                desktop);

            StreamWriter file = new StreamWriter(CaminhoArquivo, true, Encoding.ASCII);

            file.WriteLine(Dados); 

            file.Close();

        }

        public void GerarCabecalho()
        {
            Dados.AppendLine(string.Format("{0};{1};{2};{3}", "SERVIDOR", "DIRETORIO", "ARQUIVO", "DATA_MODIFICACAO"));
        }

        public void GerarCorpo()
        {
            Dados.Append(ProcessadorArquivos.GetDados());
        }

        public string GetCaminhoArquivo()
        {
            return CaminhoArquivo;
        }

        public void SetProcessadorArquivos(IProcessadorArquivos processadorArquivos)
        {
            ProcessadorArquivos = processadorArquivos;
        }
    }
}
