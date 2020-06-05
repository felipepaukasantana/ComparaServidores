using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;

namespace ComparaServidores.Servidores
{
    internal class ServidorNT1510 : AbstractServidor
    {
        public ServidorNT1510(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt1510\";
        }
    }
}