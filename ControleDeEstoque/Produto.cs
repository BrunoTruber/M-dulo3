namespace ControleDeEstoque
{
    public class Produto
    {
        public Produto(string nome, double preco) //construtor
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto() //construtor
        {

        }

        private double _preco;
        //prop + tab + tab
        public string Nome { get; set; }


        // produto.Preco = -100; //0
        // cw(produto.Preco)
        public double Preco { 
            get => _preco;
            set {
                _preco = value > 0 ? value : 0;
            }
        }
        public string Descricao { get => $"Nome: {Nome} - Preco: {Preco:0.00}";}
    }
}
