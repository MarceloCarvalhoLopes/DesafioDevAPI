namespace DesafioDevAPI.Dto
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Uf { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
