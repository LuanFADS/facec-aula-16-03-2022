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
            ImprimirVelocidadeFinal(new Cooper());
            ImprimirVelocidadeFinal(new Fusca());

            ImprimirMembrosHumano(new Humano());

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
