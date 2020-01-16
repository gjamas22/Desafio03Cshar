using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03Cshar
{
    class Carro : Veiculo
    {
        public string Marca { get; set; }
        public int Portas { get; set; }
        public int Anos { get; set; }

        public Carro(string modelo, int velocidade, int passageiros, int combustivel, bool isLigado, string marca, int portas, int anos) : base(modelo, velocidade, passageiros, combustivel,isLigado)
        {
            Marca = marca;
            Portas = portas;
            Anos = anos;

        }

        public Carro()
        {
        }


        public void abastecer(int qntdLitros)
        {
            Combustivel += qntdLitros;
            Console.WriteLine("Você abasteceu.Seu combustivel é de " + Combustivel + "litros");
        }
        public void acelerar()
        {
            if (isLigado == true)
            {
                Velocidade += 20;
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
            if 
                (isLigado == false)
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
            Console.WriteLine("O carro possue : " + Portas + " portas");
            Console.WriteLine("O ano do carro é : " + Anos);
           
            
        }
    }

}

    

