using ComparaServidores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Abstracts
{
    public abstract class AbstractJobs : ICaminho
    {
        public abstract string GetModulo();
        public List<string> GetCaminho()
        {
            var modulo = GetModulo();

            return new List<string>()
            {
                string.Format(@"Apollo\{0}\Porto.Saude.Ans.Jobs", modulo),
                string.Format(@"Apollo\{0}\Porto.Saude.Ans.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Autorizacoes.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Autorizacoes.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Central.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Central.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Comissionamento.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Comissionamento.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Conectividade.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Conectividade.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Configuracao.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Configuracao.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Contas.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Contas.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Financeiro.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Financeiro.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Gerencial.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Gerencial.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.GIPSS.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.GIPSS.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Operacional.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Operacional.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Prestadores.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Prestadores.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Produtos.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Produtos.Jobs\bin", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Vidas.Jobs", modulo),
                string.Format( @"Apollo\{0}\Porto.Saude.Vidas.Jobs\bin", modulo),
            };
        }
    }
}
