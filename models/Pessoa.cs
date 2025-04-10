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
    public  int CalculoMeses()
    {
        return Idade * 12;
    }
    public void Mensagem()
    {
        int idadeEmMes = CalculoMeses();
        Console.WriteLine($"Seu nome é: {Nome} e você tem: {Idade} anos.");
        Console.WriteLine($"sua idade comvertida em meses da: {idadeEmMes} meses");
        
    }
    }
}