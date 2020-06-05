using ComparaServidores.Abstracts;
using ComparaServidores.Interfaces;

namespace ComparaServidores.Servidores
{
    internal class ServidorNT3156 : AbstractServidor
    {
        public ServidorNT3156(ICaminho caminho) : base(caminho)
        {
        }

        public override string GetPath()
        {
            return @"\\nt3156\";
        }
    }
}