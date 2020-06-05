using ComparaServidores.DTO;
using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Abstracts
{
    public abstract class AbstractServidor
    {
        private ICaminho Caminho;

        public AbstractServidor(ICaminho caminho)
        {
            Caminho = caminho;
        }

        public abstract string GetPath();

        public List<ArquivoDiretorio> GetFiles()
        {
            var arquivos = new List<ArquivoDiretorio>();
            foreach (var diretory in Caminho.GetCaminho())
            {
                var caminho = string.Format("{0}{1}", GetPath(), diretory);
                if (Directory.Exists(caminho))
                {   
                    arquivos.Add(new ArquivoDiretorio
                    {
                        NomeDiretorio = diretory,
                        Arquivos = Directory.GetFiles(caminho)
                    });
                }
            }           
            return arquivos;
        }
    }
}
