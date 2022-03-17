using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Classes
{
    public sealed class Cooper : AbstractCarro
    {
        public override string obterMarca()
        {
            return "Mini";
        }

        public override string ObterModelo()
        {
            return "Cooper";
        }

        public override int ObterVelocidade()
        {
            return 180;
        }

        internal override string RelatorioDeManutencao()
        {
            return $"Este método foi sobreescrito \n " + 
                base.RelatorioDeManutencao();
        }
    }
}
