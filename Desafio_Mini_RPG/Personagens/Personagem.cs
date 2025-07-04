using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Mini_RPG;

namespace Desafio_Mini_RPG.Personagens
{
    internal abstract class Personagem : IAtacavel
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public Personagem(string nome, int vidaBase, int ataque, int defesa)
        {
            Nome = nome;
            Vida = vidaBase + defesa;
            Ataque = ataque;
            Defesa = defesa;
        }

        public virtual void Atacar(Personagem alvo)
        {
            alvo.ReceberDano(Ataque);
        }

        public void ReceberDano(int dano)
        {
            Vida = Vida - dano;
            Console.WriteLine(Nome + " recebeu " + dano + " de dano.");
            
        }

        public void ExibirStatus()
        {
            Console.WriteLine("STATUS " + Nome + " -> Vida: " + Vida);
        }

    }
}  
