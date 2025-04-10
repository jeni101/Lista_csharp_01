using System;


namespace LivroApp
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int Ano;

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public void Mensagem()
        {
            Console.WriteLine("Os dados que vc forneceu informam: ");
            Console.WriteLine($"Titulo: {Titulo} \t Autor: {Autor} \t Ano: {Ano}");
        }

    }
}