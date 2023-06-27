using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Problema : Feedback
    {
        
        public DateTime data { get; set; }
        public int id_usuario_problema { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

}