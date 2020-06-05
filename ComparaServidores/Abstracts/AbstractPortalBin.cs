using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Abstracts
{
    public abstract class AbstractPortalBin : ICaminho
    {
        public abstract string GetModulo();
        public List<string> GetCaminho()
        {
            var modulo = GetModulo();

            return new List<string>()
            {
                string.Format(@"Apollo\{0}.Portal", modulo),
                string.Format( @"Apollo\{0}.Portal\bin", modulo),
                string.Format(@"Apollo\{0}.Services", modulo),
                string.Format(@"Apollo\{0}.Services\bin", modulo),
            };
        }
    }
}
