using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
    class ValidarProgram
    {

        private static bool VerificarUsuario(string? nomeUsuario)
        {
            // Configurar e criar uma instância do contexto do EF Core
            using (var dbContext = new ClientContext())
            {
                // Consultar o banco de dados em busca do usuário
                var usuario = dbContext.Usuario.FirstOrDefault(e => e.nome == nomeUsuario);

                // Verificar se o usuário foi encontrado
                if (usuario != null)
                {
                    return true; // Usuário encontrado
                }
                else
                {
                    return false; // Usuário não encontrado
                }
            }
        }
        public static bool ValidarUsuario(string? nomeUsuario)
        {
            return VerificarUsuario(nomeUsuario);
        }

    }
}