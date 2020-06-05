using ComparaServidores.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Modulos
{
    public class AgendamentoJobs : AbstractJobs
    {
        public override string GetModulo()
        {
            return "Porto.Saude.Agendamento.Jobs";
        }
    }
}
