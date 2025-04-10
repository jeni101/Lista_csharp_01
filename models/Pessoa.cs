using System;

namespace PessoaApp
{
    public class Pessoa
    {
       private string Nome {get; }
       private int Idade {get; set;}



    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        
    }
    
    public int CalculoDias
    {
        get {return Idade * 365;}

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
        Console.WriteLine($" sua idade em dias é: {CalculoDias}");
        
    }


    public string GetNome()
        {
            return Nome;
        }

        // public void SetNome(string nome)
        // {
        //     Nome = nome;
        // }

       
        public int GetIdade()
        {
            return Idade;
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }

    }


}