using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Jogo
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.WriteLine("Informe seu nome: ");
            heroi = new(Console.ReadLine());
            Menu();
        }

        void Menu()
        {
            Console.Clear();
            MostraInfo();
            Console.WriteLine("Deseja lutar contra qual monstro?");
            Console.WriteLine("1 - Orc");
            Console.WriteLine("2 - Troll");
            Console.WriteLine("3 - Minotauro");
            Console.WriteLine("");
            Console.WriteLine("Digite 0 para sair do jogo");

            switch (Console.ReadLine().ToLower())
            {
                case "1": 
                case "orc": // SE FOR 1 OU SE FOR ORC, ELE ENTRA NESTE CASE!
                    Batalhar(new Monstro("Orc", heroi.nivel * 2, heroi.nivel));
                    break;
                case "2": 
                case "troll": // SE FOR 2 OU SE FOR TROLL, ELE ENTRA NESTE CASE!
                    Batalhar(new Monstro("Troll", heroi.nivel * 5, heroi.nivel*2));
                    break;
                case "3": 
                case "minotauro": // SE FOR 3 OU SE FOR MINOTAURO, ELE ENTRA NESTE CASE!
                    Batalhar(new Monstro("Minotauro", heroi.nivel * 10, heroi.nivel*4));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            if (heroi.vida <= 0)
            {
                Console.WriteLine("E morreu...");
                return;
            }
            else
            {
                Menu();
            }
        }

        void Batalhar(Monstro monstro)
        {
            Console.Clear();
            MostraInfo();
            Console.WriteLine($"MONSTRO ENCONTRADO: {monstro.nome} - Ataque: {monstro.ataque} - Vida: {monstro.vida} - XP: {monstro.xp}");
            Console.WriteLine("Deseja atacar (1) ou fugir (2)?");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "atacar":
                    monstro.vida -= heroi.ataque;
                    Console.WriteLine($"\n\nVocê causou {heroi.ataque} de dano no {monstro.nome}!");
                    Random talvez = new Random();
                    if (talvez.Next(1,11) % 2 == 0) {
                        heroi.vida -= monstro.ataque;
                        Console.WriteLine($"\n\nVocê recebeu {monstro.ataque} de dano do ataque do {monstro.nome}!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nO MONSTRO ERROU O ATAQUE!");
                    }
                
                    if (heroi.vida <= 0)
                    {
                        Console.WriteLine("\n\nE morreu...");
                        return;
                    }
                    if (monstro.vida <= 0)
                    {
                        Console.WriteLine($"\n\nVocê derrotou o {monstro.nome} e ganhou {monstro.xp} de xp!");
                        heroi.ganhaXP(monstro.xp);
                        return;
                    }
                    break;
                case "2":
                case "fugir":
                    Console.WriteLine("\n\nVocê fugiu da batalha! Arregou...");
                    return;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Batalhar(monstro);
        }

        void MostraInfo()
        {
            Console.WriteLine($"Olá {heroi.nome}");
            Console.WriteLine($"Seu nível é: {heroi.nivel}");
            Console.WriteLine($"Sua experiência é: {heroi.xp}");
            Console.WriteLine($"Seu ataque base é: {heroi.ataqueBase}");
            Console.WriteLine($"Seu ataque é: {heroi.ataque}");
            Console.WriteLine($"Sua vida é: {heroi.vida}");
            Console.WriteLine("***");
        }
        
    }

}
