﻿using ComparaServidores.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaServidores.Modulos
{
    public class Central : AbstractPortalBin
    {
        public override string GetModulo()
        {
            return "Porto.Saude.Central";
        }
    }
}
