namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Resumo { get; set; }
        public string Ano { get; set; }
        public string Genero { get; set; }
        public string? CapaUrl { get; set; }
    }
}