using System;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //BlueShop blueShop = new BlueShop();
            //blueShop.Iniciar();
            //var a = 1;
            //var b = a; // b = 1
            //b = 2; // b = 2
            //Console.WriteLine($"a:{a}  - b:{b}");

            Produto p1 = new Produto();
            p1.Preco = 100;
            Produto p2 = p1;
            p2.Preco = p1.Preco;
            p2.Preco = 200;
            Console.WriteLine($" p1: {p1.Preco} - p2 {p2.Preco}");


            Produto prod1 = new Produto("Pc Gamer", 11000);
            //Produto prod2 = new Produto();
            ////prod.Nome = "Monitor";
            ////prod.Preco = 1000;

            //Console.WriteLine(prod1.Descricao);
            //Console.WriteLine(prod2.Descricao);
        }
    }
}

