using System;

namespace CirculoApp
{
    public class Circulo
    {
        private float raio {get; set;}

        public Circulo(float raio)
        {
            this.raio = raio;
        }
        public float Area()
        {
            return (float)(Math.PI * Math.Pow(raio, 2));
        }

        public void Mensagem()
        {   
            float area = Area();
            Console.WriteLine($" a area do circulo é: {area}");
        }
        
    }
}