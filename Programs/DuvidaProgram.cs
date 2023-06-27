using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
    class DuvidaProgram
    {
        static void Main(string[] args, string nomeUsuario, string desc)
        {
            InsertData(nomeUsuario, desc);
            PrintData();
        }

        public static void InsertData(string? nomeUsuario, string? desc)
        {
            using (var context = new ClientContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds a publisher
                var usuario = new Usuario
                {
                    nome = nomeUsuario
                };

                context.Usuario?.Add(usuario);
                context.SaveChanges();

                var duvida = new Duvida
                {
                    desc = desc,
                    Usuario = usuario,
                    id_usuario_duvida = usuario.id
                };

                context.Duvida?.Add(duvida);
                context.SaveChanges();
            }
        }

        public static void PrintData()
        {

            // Gets and prints all books in database
            using (var context = new ClientContext())
            {
                var duvidas = context.Duvida?
                  .Include(p => p.Usuario);
                foreach (var duvida in duvidas ?? Enumerable.Empty<Duvida>())
                {
                    var data = new StringBuilder();
                    data.AppendLine($"--------------------\\---------------------");
                    data.AppendLine($"desc: {duvida.desc}");
                    data.AppendLine($"Usuario: {duvida.Usuario?.nome}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}