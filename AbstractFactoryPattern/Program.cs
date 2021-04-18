using AbstractFactoryPattern.ConcreteFactories;
using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICelular nokiaCelular = new Nokia();
            CelularClient nokiaClient = new CelularClient(nokiaCelular);

            Console.WriteLine("************ N O K I A ************");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokiaClient.BuscarCelularComumDetalhes());


            ICelular samsungCelular = new Nokia();
            CelularClient samsungClient = new CelularClient(samsungCelular);

            Console.WriteLine("************ S A M S U N G ************");
            Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(samsungClient.BuscarCelularComumDetalhes());

            Console.ReadKey();
        }
    }
}
