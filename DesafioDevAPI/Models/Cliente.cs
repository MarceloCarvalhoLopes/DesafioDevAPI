using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDevAPI.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get;  set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Uf { get;  set; }
        public DateOnly DataNascimento { get;  set; }

        
    }
}
