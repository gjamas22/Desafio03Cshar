using System;

namespace Desafio03Cshar
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro ("Jeep Renegate", 50, 4, 50, true,"Jeep", 4, 2009);
            Console.WriteLine("------------------Carro-----------------------------");
            c1.ligar();
            c1.abastecer(50);
            c1.acelerar();
            c1.status();

            Avião c2 = new Avião("Boing 707", 200, 100, 200, true, "para turismo", "comercial");
            Console.WriteLine("---------------------Avião-----------------------------");
            c2.ligar();
            c2.acelerar();
            c2.abastecer(50);
            c2.acelerar();
            c2.status();

            Caminhão c3 = new Caminhão("Scannia", 30, 3, 30,true,230);
            Console.WriteLine("-------------------Caminhão--------------------------------");
            c3.ligar();
            c3.acelerar();
            c3.abastecer(50);
            c3.desligar();
            c3.status();

        }
    }
}
