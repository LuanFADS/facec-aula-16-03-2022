using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Classes
{
    public struct PosicaoGPS
    {
        public decimal Latitude { get; private set; }

        public decimal Longitude { get; private set; }

        // APÓS A DECLARAÇÃO DE UM CONSTRUTOR COM PARAMS, NÃO É POSSÍVEL DECLARAR UM CONSTRUTOR SEM
        // PARAMS.
        //public PosicaoGPS(){}

        public PosicaoGPS(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool IsHemisphereNorth()
        { 
            return Latitude > 0; 
        }
    
    }
}
