using System;

namespace CarroApp
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;
        public bool estaLigado;

        //costrutor
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            estaLigado = false;
        }


        public void Mensagen()
        {
            Console.WriteLine($"O carro é um {Modelo} da marca {Marca} do ano: {Ano}");
        }

        public void Ligar()
        {
    
            estaLigado = true;
            Console.WriteLine("O carro esta ligado");
            
        }

        public void Desligado()
        {
            estaLigado  =  false;
            Console.WriteLine("O carro esta desligado");
        }

        public void estadoDoCarro()
        {
            if (estaLigado)
            {
                Console.WriteLine("O carro esta ligado.");
            }
            else
            {
                Console.WriteLine("o carro esta desligado");
            }
        }

        public void mudarEstado()
        {
            if (!estaLigado)
            {
                Console.WriteLine("o carro esta desligado\t deseja liga-lo? S/N");
                string? Liga = Console.ReadLine();
                if (Liga != null)
                {
                    Liga = Liga.ToUpper();
                }
                else
                {
                    Liga = string.Empty;
                }
                if (Liga == "S")
                {
                    Ligar();
                }
                else
                    Console.WriteLine("o carro permanece desligdo");
            }
        }
    }
}