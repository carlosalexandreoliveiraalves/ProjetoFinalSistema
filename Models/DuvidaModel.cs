using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Duvida : Feedback
    {
        public int id_usuario_duvida { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

}
