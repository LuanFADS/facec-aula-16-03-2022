using Facec_Classes;
using Facec_Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Apresentacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chamada método extension
            //ImprimirVelocidadeFinal(new Cooper());
            //ImprimirVelocidadeFinal(new Fusca());
            #endregion Chamada método extension

            #region Classe partial
            //ImprimirMembrosHumano(new Humano());
            #endregion Classe partial

            #region Struct

            //PosicaoGPS posicaoGPS = new PosicaoGPS()
            //{
            //    Latitude = 50.00m,
            //    Longitude = -15.00m,
            //};

            var posicaoGPS = new PosicaoGPS(15.00m, -50.00m);

            Console.WriteLine("Está no Hemisfério Norte: " + $"{posicaoGPS.IsHemisphereNorth()}");

            #endregion Struct


            Console.ReadLine();
        }

        static void ImprimirVelocidadeFinal(AbstractCarro car)
        {
            Console.WriteLine(car.ObterVelocidadeFinal());
        }

        static void ImprimirMembrosHumano(Humano human)
        {
            Console.WriteLine($"{human.Bracos} - {human.Quadril} \n");
        }
    }
}
