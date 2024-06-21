using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDevAPI.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Uf { get; private set; }
        public DateOnly DataNascimento { get; private set; }

        public Cliente(string Nome, string Cpf, string Uf, DateOnly DataNascimento)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Uf = Uf;
            this.DataNascimento = DataNascimento;
        }

        
    }
}
