using System;

namespace AlunoApp
{
    public class Aluno
    {
        private float nota1 {get; set;}
        private float nota2 {get; set;}

        public Aluno(float nota1, float nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void ValorNegativo()
        
        {
            if (nota1 <0 || nota2 <0)
                Console.WriteLine("Nota nao pode ser negativa.");
        }

        public float Media()
        {
            return (nota1 + nota2)/2;
        }

        public void Mensagem()
        {
            float MediaFinal = Media();
            Console.WriteLine($"Sua media final foi de: {MediaFinal} ");
        }
    }
}