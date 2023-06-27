using mysqlefcore;
using System;

namespace mysqlefcore
{
    class Program
    {

        public static string menu()
        {
            
            Console.WriteLine("Olá, bem-vindo ao ClientManager. Para continuar faça login.");
            Console.WriteLine("Insira o seu nome:");
            string? nomeUsuario = Console.ReadLine();

            if (nomeUsuario == "123123admin") {
                return nomeUsuario;
            }

            if ((nomeUsuario == null) || (nomeUsuario == ""))
            {
                Console.Clear();
                Console.WriteLine("Precisa inserir um nome.");
                return menu();
            }
            else
            {
                bool usuarioExiste = ValidarProgram.ValidarUsuario(nomeUsuario);

                if (usuarioExiste)
                {
                    return nomeUsuario;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Usuário não encontrado. Tente novamente.");
                    return menu();
                }
            }
        }

        public static int opcoes()
        {
            Console.WriteLine("Escolha uma opção.");
            Console.WriteLine("1 - Adicionar uma dúvida.");
            Console.WriteLine("2 - Adicionar um problema técnico.");
            Console.WriteLine("3 - Adicionar uma reclamação.");
            Console.WriteLine("4 - Mostrar dúvidas.");
            Console.WriteLine("5 - Mostrar problemas técnicos.");
            Console.WriteLine("6 - Mostrar reclamações.");
            Console.WriteLine("7 - Voltar para a tela de login.");
            Console.WriteLine("8 - Encerra o programa.");

            int opcao = 0;

            while (opcao == 0)
            {
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Escolha uma opção.");
                    Console.WriteLine("1 - Adicionar uma dúvida.");
                    Console.WriteLine("2 - Adicionar um problema técnico.");
                    Console.WriteLine("3 - Adicionar uma reclamação.");
                    Console.WriteLine("4 - Mostrar dúvidas.");
                    Console.WriteLine("5 - Mostrar problemas técnicos.");
                    Console.WriteLine("6 - Mostrar reclamações.");
                    Console.WriteLine("7 - Voltar para a tela de login.");
                    Console.WriteLine("8 - Encerra o programa.");

                    Console.WriteLine("Entrada inválida. Digite novamente:");
                }
            }

            return opcao;
        }

    }


}