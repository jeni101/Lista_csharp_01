using System;

namespace TemperaturaApp
{
    public class Temperatura
    {
        public float Celsius {get; set;}
        public float Fahrenheit { get; set;}

        public Temperatura(float celcios, float fahrenheit)
        {
            Celsius = celcios;
            Fahrenheit = fahrenheit;
        }

        public float ConversaoFahrenToCelcio()
        {
            return (float)(Fahrenheit - 32) * 5 / 9;
        }

        public float ConversaoCelcioToFahren()
        {
            return (float)(Celsius * 9 / 5) + 32;
        }


        public void Mensagem()
        {
            float celsiusToFahren =  ConversaoCelcioToFahren();
            float fahrenToCelsius = ConversaoFahrenToCelcio();
            Console.WriteLine($"a conversao de Celsius para Fahrenheit da: {celsiusToFahren}");
            Console.WriteLine($"a conversao de Fahrenheit para Celsius da: {fahrenToCelsius}");
        }
    }
}