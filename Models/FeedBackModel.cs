using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Feedback
    {
        [Key]
        public int id { get; set; }
        public string? desc { get; set; }

    }

}