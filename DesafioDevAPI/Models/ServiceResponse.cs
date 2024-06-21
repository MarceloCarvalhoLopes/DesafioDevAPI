namespace DesafioDevAPI.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Successo { get; set; } = true;
    }
}
