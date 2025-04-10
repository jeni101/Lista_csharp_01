using System;

namespace FuncionariosApp
{
    public class Funcionarios
    {
        private float salario {get; set;}
        private string nome {get; set;}
        private float desconto {get; set;}
        public Funcionarios(float salario, string nome, float desconto)
        {
            this.salario = salario;
            this.nome = nome;
            this.desconto = desconto;
        }

        public float SalarioLiquido()
        {
            salario = salario - desconto;
            return salario;
        }

        public void Mensagem()
        {
            float salarioAguado = SalarioLiquido();
            Console.WriteLine($"senhor(a) {nome}, seu salario aguado é de: {salarioAguado}");
        }

    }

}