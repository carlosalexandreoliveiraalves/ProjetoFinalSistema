using mysqlefcore;
using System;

namespace insercao
{
    class Program
    {

        public static void duvida(string nomeUsuario)
        {
            Console.Clear();

            Console.WriteLine("Insira sua dúvida:");
            string? desc = Console.ReadLine();

            mysqlefcore.DuvidaProgram.InsertData(nomeUsuario, desc);
        }

        public static void problema(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine("Insira a descrição do problema:");
            string? desc = Console.ReadLine();

            Console.WriteLine("Digite uma data no formato dd/MM/yyyy:");
            string? input = Console.ReadLine();

            DateTime parsedDateTime;

            while (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDateTime))
            {
                Console.WriteLine("Formato de data inválido. Digite novamente:");
                input = Console.ReadLine();
            }

            mysqlefcore.ProblemaProgram.InsertData(nomeUsuario, desc, parsedDateTime);

        }


        public static void reclamacao(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine("Insira sua reclamação:");
            string? desc = Console.ReadLine();

            Console.WriteLine("Digite uma data no formato dd/MM/yyyy:");
            string? input = Console.ReadLine();

            DateTime parsedDateTime;

            while (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDateTime))
            {
                Console.WriteLine("Formato de data inválido. Digite novamente:");
                input = Console.ReadLine();
            }

            mysqlefcore.ReclamacaoProgram.InsertData(nomeUsuario, desc, parsedDateTime);

        }

    }

}