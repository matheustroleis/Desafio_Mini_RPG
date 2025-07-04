using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Mini_RPG;

namespace Desafio_Mini_RPG.Personagens
{
    internal class Arqueiro : Personagem, IAtacavel
    {
        public Arqueiro (string nome) : base(nome, 110, 20,15)
        {
        }
        public override void Atacar(Personagem alvo)
        {
            Console.WriteLine(Nome + " ataca " + alvo.Nome + " com seu arco e flecha");
            alvo.ReceberDano(Ataque);
        }
    }
}
