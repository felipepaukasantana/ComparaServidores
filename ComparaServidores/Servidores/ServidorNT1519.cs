using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;

namespace ComparaServidores.Servidores
{
    internal class ServidorNT1519 : AbstractServidor
    {
        public ServidorNT1519(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt1519\";
        }
    }
}