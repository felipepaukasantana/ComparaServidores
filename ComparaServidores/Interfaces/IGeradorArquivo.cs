using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Interfaces
{
    public interface IGeradorArquivo
    {
        void GerarCabecalho();
        void GerarCorpo();
        void GerarArquivo();
        string GetCaminhoArquivo();
      
    }
}
