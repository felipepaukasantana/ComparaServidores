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
    public class ServidorNT3157 : AbstractServidor
    {
        public ServidorNT3157(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt3157\";
        }
    }
}
