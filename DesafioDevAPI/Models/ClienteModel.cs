using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDevAPI.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get;  set; }
        [Required(ErrorMessage ="Informe o nome")]
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Uf { get;  set; }
        public DateTime DataNascimento { get;  set; }

        
    }
}
