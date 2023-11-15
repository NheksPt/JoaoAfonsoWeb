using System.ComponentModel.DataAnnotations;

namespace JoaoAfonso.Domain.Entities
{
    public class Animacao_trabalhos
    {
        public int ID { get; set; }
         
        [MaxLength(45)]
        public required string Nome { get; set; }

        [Display(Name = "Descrição")]
        public required string Descricao { get; set; }

        [Display(Name = "Software Usado")]
        public required string SoftwareUsado { get; set; }

        [Display(Name = "Duração")]
        public required string Duracao { get; set; }

        [Display(Name = "Url da Imagem")]
        public required string? UrlImagem { get; set; }

        [Display(Name = "Tamanho do Ficheiro")]
        public required string TamanhoFicheiro {  get; set; } 
    }
}
