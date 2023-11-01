﻿namespace JoaoAfonso.Domain.Entities
{
    public class Animacao_trabalhos
    {
        public int ID { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string SoftwareUsado { get; set; }
        public required string Duracao { get; set; }
        public required string? UrlImagem { get; set; }
        public required string TamanhoFicheiro {  get; set; } 
    }
}
