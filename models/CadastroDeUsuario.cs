using System;

namespace CadastroApp
{
    public class CadastroDeUsuarios
    {
        private string nome = string.Empty;
        private string senha = string.Empty;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                if (value.Length >= 8)
                {
                    senha = value;
                }
                else
                {
                    Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
                    senha = "senha_invalida";
                }
            }
        }

        public CadastroDeUsuarios(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public void Mensagem()
        {
            Console.WriteLine($"Usuário: {Nome}");
            Console.WriteLine($"Senha: {(senha != "senha_invalida" ? "Cadastrada com sucesso!" : "Inválida")}");
        }
    }
}
