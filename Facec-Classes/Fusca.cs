using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Classes
{
    public class Fusca : AbstractCarro
    {
        public override string obterMarca()
        {
            return "Volkswagen";
        }

        public override string ObterModelo()
        {
            return "Fusca";
        }

        public override int ObterVelocidade()
        {
            return 100;
        }
    }
}
