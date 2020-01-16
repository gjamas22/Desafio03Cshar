using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03Cshar
{
    class Caminhão : Veiculo
    {
        public int PesoCarga { get; set; }

        public Caminhão(string modelo, int velocidade, int passageiros, int combustivel, Boolean isLigado,int pesoCarga) :base (modelo, velocidade, passageiros, combustivel, isLigado) 
        {
            PesoCarga = pesoCarga;
        }

        public int pesoCarga { get; set; }
        public void abastecer(int qntdLitros)
        {
            Combustivel += qntdLitros;
            Console.WriteLine("Você abasteceu.Seu combustivel é de " + Combustivel + "litros");

        }
        public void acelerar()
        {
            if (this.isLigado == true)
            {
                Velocidade += 40;
                Combustivel -= 1;
                Console.WriteLine("Você acelerou.Sua velocidade é de :" + Velocidade + "km por hora" + " Seu combustivel é de :" + Combustivel);
            }
            else
                Console.WriteLine("Você precisa ligar o carro primeiro");
        }

        public void ligar()
        {
            if (isLigado == true)
            {
                Console.WriteLine("O veiculo ja está ligado");
            }
            else
            {
                isLigado = true;
                Console.WriteLine("Você ligou o veiculo");
            }

        }

        public void desligar()
        {
            if (isLigado == false)
            {
                Console.WriteLine("O veiculo está desligado");

            }
            else
            {
                isLigado = false;
                Console.WriteLine("Você desligou o veiculo");
            }
        }

        public void status()
        {
            base.status();
            Console.WriteLine("O peso da carga do caminhão é " + PesoCarga);
           
            
        }
    }
}
