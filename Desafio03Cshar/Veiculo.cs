using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03Cshar
{
    class Veiculo
    {
      

        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Passageiros { get; set; }
        public int Combustivel { get; set; }
        public Boolean isLigado { get; set; }


        public Veiculo(string modelo, int velocidade, int passageiros, int combustivel, Boolean isLigado)
        {
            Modelo = modelo;
            Velocidade = velocidade;
            Passageiros = passageiros;
            Combustivel = combustivel;
            isLigado = isLigado;
        }

        public Veiculo()
        {
        }
        public void abastecer(int qntdLitros)
        {
            Combustivel += qntdLitros;
        }
        public void acelerar()
        {
            if (this.isLigado == true)
            {
                Velocidade += 20;
                Combustivel -= 1;

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

            Console.WriteLine("O modelo do veiculo é " + Modelo + "\n A velocidade do veiculo é :" + Velocidade
                + " km " + "\n O número de passageiros é de :" + Passageiros + "\n Seu combustivel é de :"
                + Combustivel + " litros");
        }
    }
}

