using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Heroi
    {
        public int nivel { get; set; }
        public int vida { get; set; }
        public string nome { get; set; }
        public int xp { get; set; }
        public int ataqueBase { get; set; }
        public int ataque { get; set; }

        public Heroi(string nome)
        {
            Random aleatorio = new Random();
            this.nome = nome;
            this.ataqueBase = aleatorio.Next(1, 11);
            this.ataque = this.ataqueBase;
            this.vida = 10;
            this.xp = 0;
            this.nivel = 1;
        }

        public void ganhaXP(int experiencia)
        {
            xp += experiencia;
            int novo_nivel = (xp / 10) + 1;
            if (novo_nivel > nivel)
            {
                Console.WriteLine("\n\nVocê aumentou de nível!");
                vida = novo_nivel * 10;
            }
            nivel = novo_nivel;
            ataque = ataqueBase + nivel;
        }
    }
}
