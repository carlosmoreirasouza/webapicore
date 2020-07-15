using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_squadra.Models
{
    public class Sistemas
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="varchar(100)")]
        public string Descricao { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Sigla { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Url { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }
    }
}
