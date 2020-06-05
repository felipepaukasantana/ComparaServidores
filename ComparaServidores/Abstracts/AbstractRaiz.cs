using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Abstracts
{
    public abstract class AbstractRaiz : ICaminho
    {
        public abstract string GetModulo();
        public List<string> GetCaminho()
        {
            var modulo = GetModulo();

            return new List<string>()
            {
                string.Format(@"Apollo\{0}", modulo),
            };
        }
    }
}
