using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Reclamacao : Feedback
    {
        
        public DateTime data { get; set; }
        public int id_usuario_reclamacoes { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

}