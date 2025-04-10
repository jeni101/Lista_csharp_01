using System;
using PessoaApp;
using CarroApp;
using LivroApp;
using ContaApp;

public class Program
{
    public static void Main(string[] args)

    {
        Console.Clear();
        Pessoa pessoa = new Pessoa("cleiton", 30);

        pessoa.Mensagem();

        // teste get e set

        pessoa.SetNome("Jonas");
        pessoa.SetIdade(13);
        Console.WriteLine(pessoa.GetNome());
        Console.WriteLine(pessoa.GetIdade());
        pessoa.Mensagem();

        

        // carro 

        Carro carro = new Carro("Ford", "Mustang", 2020);
        carro.Mensagen();
        Carro segundoCarro = new Carro("Chevrolet", "Onix", 2023);
        segundoCarro.Mensagen();
        
        
        carro.mudarEstado();


        //Livro

        Livro livro = new Livro("Python e django", "alguem", 2);
        livro.Mensagem();

        // conta 
        ContaBancaria conta = new ContaBancaria(45.21f, 0f, 0f);
        conta.Depositar();
        conta.MensagemDeposito();
        conta.MensagemSaque();

        

    }
}
