using System;


namespace ContaApp
{
    public class ContaBancaria
    {
        private float saldo;
        public float Saldo
        {
            get {return saldo;}
            set
            {
                if (value >=0 )
                    saldo = value;
                else
                    Console.WriteLine("o saldo n pode ser negativo.");

            }

        }

        public float ValorDepositado;

        public float ValorRetirado;

       public ContaBancaria(float saldo,float valorDepositado, float valorRetirado)
       {
            Saldo = saldo;
            ValorDepositado = valorDepositado;
            ValorRetirado = valorRetirado;
       } 


       public float Depositar()
       {
            Saldo += ValorDepositado;
            return Saldo;
        }
    

        public float Sacar()
        {
            if (Saldo>= ValorRetirado)
            {
                Saldo -= ValorRetirado;
            }
            else
            {
                Console.WriteLine("O valor exede seu saldo.");
            }
            return Saldo;
        }


       public void MensagemDeposito()
       {    
            Console.WriteLine($"Seu saldo inicial é: {Saldo}");

            Console.WriteLine("Digite o valor a se depositado: ");
            if (float.TryParse(Console.ReadLine(), out float valorDepositado))
            {
                ValorDepositado = valorDepositado; 
                float saldoAtualizado = Depositar();
                Console.WriteLine($"Depósito realizado! Seu saldo agora é: {saldoAtualizado}");
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número.");
            }
        
       }

        public void MensagemSaque()
        {
            Console.WriteLine($"seu saldo inicial era de: {Saldo}");

            Console.WriteLine("digite o valor do saque: ");
            if (float.TryParse(Console.ReadLine(), out float valorRetirado))
            {
                ValorRetirado = valorRetirado;
                float saldoAtualizado = Sacar();
                Console.WriteLine($"Seu saldo agora é {saldoAtualizado}");
            }

            else
            {
                Console.WriteLine("valor invalido. Por favor insira um numero.");
            }
            
        }

    }
}