using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Classes
{
    public abstract class AbstractCarro
    {
        
        public abstract string obterMarca();

        public abstract string ObterModelo();
        
        public  abstract int ObterVelocidade();

        // NÃO PERMITE SOBRESCRITA
        //
        //public string RelatorioDeManutencao()
        //{
        //    return $"{obterMarca()} - " + $"{ObterModelo()}\n" + $"TESTE TESTE";
        //}

        // VISÍVEL EM OUTRO ASSEMBLY
        //
        //public virtual string RelatorioDeManutencao()
        //{
        //    return $"{obterMarca()} - " + $"{ObterModelo()}\n" + $"TESTE TESTE";
        //}

        internal virtual string RelatorioDeManutencao()
        {
            return $"{obterMarca()} - " + $"{ObterModelo()}\n" + $"TESTE TESTE";
        }
    }
}
