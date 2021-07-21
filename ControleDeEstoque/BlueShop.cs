using System;
using System.Collections.Generic;

namespace ControleDeEstoque
{
    public class BlueShop
    {
        List<Produto> produtos = new List<Produto>(); // { { nome: Monitor, preco: 1000} , { nome: Mouse, preco: 50} }
        public void Iniciar()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar um produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("0 - Sair da aplicação");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastroDeProdutos();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Iniciar();
        }


        void CadastroDeProdutos()
        {
            Produto produto = new Produto();

            Console.WriteLine("Informe um nome para o novo produto:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Informe um preco para o novo produto:");
            produto.Preco = Convert.ToDouble(Console.ReadLine());
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso!");
        }

        void ListarProdutos()
        {
            foreach (Produto p in produtos) // { { nome: Monitor, preco: 1000} , { nome: Mouse, preco: 50} }
            {
                // p = { nome: Monitor, preco: 1000} // p = { nome: Mouse, preco: 50}
                Console.WriteLine("--");
                Console.WriteLine(p.Descricao);
            }
        }
    }
}
