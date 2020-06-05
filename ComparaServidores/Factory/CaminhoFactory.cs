using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Factory
{
    public static class CaminhoFactory
    {
        public static ICaminho CreateInstance(string nome)
        {
            return Activator.CreateInstance(Type.GetType("ComparaServidores.Modulos." + nome)) as ICaminho;
        }
    }
}
