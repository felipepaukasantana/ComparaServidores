using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;

namespace ComparaServidores.Servidores
{
    internal class ServidorNT1083 : AbstractServidor
    {
        public ServidorNT1083(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt1083\";
        }
    }
}