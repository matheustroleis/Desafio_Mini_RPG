using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Mini_RPG;

namespace Desafio_Mini_RPG.Personagens
{
    internal class Mago : Personagem, IAtacavel
    {
        public Mago(string nome) : base(nome, 80, 35,10)
        {
        }
        public override void Atacar(Personagem alvo)
        {
            Console.WriteLine(Nome + " ataca " + alvo.Nome + " com seu poder de fogo");
            alvo.ReceberDano(Ataque);
        }
    }
}
