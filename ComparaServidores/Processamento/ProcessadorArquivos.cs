using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Processamento
{
    public class ProcessadorArquivos : IProcessadorArquivos
    {
        private AbstractServidor Servidor;
        private StringBuilder Dados { get; }
        public ProcessadorArquivos(AbstractServidor servidor)
        {
            Servidor = servidor;
            Dados = new StringBuilder();
        }

        public void Processar()
        {
            var nomeSevidor = Servidor.GetPath();
            foreach (var arquivoDiretorio in Servidor.GetFiles())
            {
                foreach (var arquivo in arquivoDiretorio.Arquivos)
                {
                    var arquivoInfo = new FileInfo(arquivo);
                    Dados.AppendLine(string.Format("{0};{1};{2};{3}", nomeSevidor, arquivoDiretorio.NomeDiretorio, arquivoInfo.Name, arquivoInfo.LastWriteTime));
                }                
            }
        }

        public StringBuilder GetDados()
        {
            return Dados;
        }
    }
}
