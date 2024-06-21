using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDevAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email {  get; private set; }

        public Usuario(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;
            
        }



    }
}
