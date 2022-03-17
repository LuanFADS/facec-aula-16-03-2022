using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractCarro carro1 = new AbstractCarro(); -- NÃO CONSIGO INSTANCIAR
            
            // AbstractCarro carro1 = new Cooper();
            
            //Console.WriteLine(car.RelatorioDeManutencao());
            //Console.ReadLine();

            ImprimirRelatorioDeManutencao(new Cooper());
            ImprimirRelatorioDeManutencao(new Fusca());
            Console.ReadLine();
        }

        static void ImprimirRelatorioDeManutencao(AbstractCarro car)
        {
            Console.WriteLine(car.RelatorioDeManutencao() + "\n");
        }
    }
}
