using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;

namespace ComparaServidores.Servidores
{
    internal class ServidorNT50214 : AbstractServidor
    {
        public ServidorNT50214(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt50214\"; 
        }
    }
}