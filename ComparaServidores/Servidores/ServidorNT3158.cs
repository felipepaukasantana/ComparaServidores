using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Servidores
{
    public class ServidorNT3158 : AbstractServidor
    {
        public ServidorNT3158(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt3158\";
        }
    }
}
