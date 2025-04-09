using System;

namespace PessoaApp
{
    public class Pessoa
    {
       public string Nome;
       public int Idade;


    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;

    }
    public void Mensagem()
    {
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Nome: {Nome}");
    }
    }
}