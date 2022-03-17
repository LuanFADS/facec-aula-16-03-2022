using Facec_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Extensoes
{
    public static class CarroExtensoes
    {
        public static string ObterVelocidadeFinal(this AbstractCarro car)
        {
            return $"{car.obterMarca()} - {car.ObterModelo()}: " +
                $"{car.ObterVelocidade()} Km/h \n";
        }
    }
}
