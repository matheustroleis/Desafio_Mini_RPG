using Desafio_Mini_RPG.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Mini_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personagem Arqueiro = new Arqueiro("Matheus");
            Personagem Mago = new Mago("Rezende");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem vindo ao jogo de RPG");
            Console.WriteLine("------------------------------");
            Console.WriteLine(Arqueiro.Nome + " escolhe: Arqueiro"  );
            Console.WriteLine("Possui " + Arqueiro.Defesa + " pontos de defesa que somam com a vida");
            Arqueiro.ExibirStatus();
            Console.WriteLine("Possuindo " + Arqueiro.Ataque + " pontos de ataque");
            Console.WriteLine(" ");
            Console.WriteLine(Mago.Nome + " escolhe: Mago");
            Console.WriteLine("Possui " + Mago.Defesa + " pontos de defesa que somam com a vida");
            Mago.ExibirStatus();
            Console.WriteLine("Possuindo " + Mago.Ataque + " pontos de ataque");
            Console.WriteLine(" ");

            int rodada = 1;

            while(Arqueiro.Vida > 0 && Mago.Vida > 0)
            {
                Console.WriteLine("--------- RODADA " + rodada + "---------------------------");

                Mago.Atacar(Arqueiro);
                Arqueiro.ExibirStatus();

                if(Mago.Vida <= 0)
                {
                    break;
                } 

                Arqueiro.Atacar(Mago);
                Mago.ExibirStatus();

                if (Arqueiro.Vida <= 0)
                {
                    break;
                }

                rodada++;

                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("\n--------- FIM DE COMBATE --------------------");

            if (Arqueiro.Vida > 0)
            {
                Console.WriteLine($"O vencedor é o Arqueiro {Arqueiro.Nome}!");
            }
            else
            {
                Console.WriteLine($"O vencedor é o Mago {Mago.Nome}!");
            }
        }
    }
}
