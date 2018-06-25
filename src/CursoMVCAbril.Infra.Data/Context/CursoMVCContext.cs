using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVCAbril.Infra.Data.Context
{
    class CursoMVCContext : DbContext // >Transforma a classe num contexto do entity
    {
        public CursoMVCContext()
            :base("CursoMVC")
        {

        }
    }
}
