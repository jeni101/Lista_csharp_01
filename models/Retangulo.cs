using System;

namespace RetanguloApp
{
    public class Retangulo
    {
        private float largura {get; set;}
        private float altura {get; set;}

        public float area
        {
            get{return largura * altura;}
        }

        public Retangulo(float largura, float altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public void Mensagem()
        {
            Console.WriteLine($"a area é {area}");
        }
            
    }
}