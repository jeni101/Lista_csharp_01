using System;
using PessoaApp;
using CarroApp;
using LivroApp;
using ContaApp;
using RetanguloApp;
using FuncionariosApp;
using AlunoApp;
using CirculoApp;
using TemperaturaApp;
using CadastroApp;
public class Program
{
    public static void Main(string[] args)

    {
        Console.Clear();
        Pessoa pessoa = new Pessoa("cleiton", 30);

        pessoa.Mensagem();

        // teste get e set

        // pessoa.SetNome("Jonas");
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

        //Retangulo
        Retangulo retangulo = new Retangulo(20, 5);
        retangulo.Mensagem();

        // Funcionarios
        Funcionarios funcionarios = new Funcionarios(2000, "cleiton", 500);
        funcionarios.Mensagem();
    
        // aluno 

        Aluno aluno = new Aluno ((float)3.4, (float)9.7);
        aluno.ValorNegativo();
        aluno.Mensagem();

        // circulo 

        Circulo circulo = new Circulo(7);
        circulo.Mensagem();

        //Temperatude
        // parece q n mudou mas da exatamente o msm valor do outro quando faz a conversao kk 

        Temperatura temperatura = new Temperatura((float)27.5, (float)81.5);
        temperatura.Mensagem();
        

        // Cadastro
        CadastroDeUsuarios cadastro = new CadastroDeUsuarios("cleiton", "Root");
        cadastro.Mensagem();
    }

}
