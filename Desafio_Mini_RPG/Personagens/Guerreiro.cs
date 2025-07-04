using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Mini_RPG;

namespace Desafio_Mini_RPG.Personagens
{
    internal class Guerreiro : Personagem, IAtacavel
    {
        public Guerreiro(string nome) : base(nome, 150, 10,25)
        {
        }

        public override void Atacar(Personagem alvo)
        {
            Console.WriteLine(Nome + " ataca " + alvo.Nome + " com sua espada");
            alvo.ReceberDano(Ataque);
        }
    } 
}
