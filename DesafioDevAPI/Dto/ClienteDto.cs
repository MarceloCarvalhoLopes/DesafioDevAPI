﻿namespace DesafioDevAPI.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Uf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
