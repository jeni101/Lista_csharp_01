using System;

namespace ProdutoApp
{
    public class Produto
    {
        private string nome;
        private double preco;
        private string estoque;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public Produto(string nome, double preco, string estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }
    }

}