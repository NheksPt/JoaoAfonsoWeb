using JoaoAfonso.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JoaoAfonso.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Animacao_trabalhos> Animacao_Trabalhos { get; set; }


        public DbSet<Escultura_trabalhos> Escultura_Trabalhos { get; set; }

        public DbSet<Modelacao_trabalhos> Modelacao_Trabalhos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Animacao_trabalhos>().HasData(
                new Animacao_trabalhos
                {
                    ID = 1,
                    Nome = "Magic Mushrooms",
                    Descricao = "Animação de um cogumelo numa floresta mágica rodeado de borboletas luminosas.",
                    SoftwareUsado = "Blender",
                    Duracao = "0.5 segundos",
                    UrlImagem = "https://placehold.co/600x400",
                    TamanhoFicheiro = "10 Mb",

                },
                new Animacao_trabalhos
                {
                    ID = 2,
                    Nome = "Rigor Mortis",
                    Descricao = "Animação de uma morgue.",
                    SoftwareUsado = "Blender",
                    Duracao = "0.5 segundos",
                    UrlImagem = "https://placehold.co/600x400",
                    TamanhoFicheiro = "16 Mb",
                },
                new Animacao_trabalhos
                {
                    ID = 3,
                    Nome = "Eletrico",
                    Descricao = "Animação de eletrico.",
                    SoftwareUsado = "Blender",
                    Duracao = "0.5 segundos",
                    UrlImagem = "https://placehold.co/600x400",
                    TamanhoFicheiro = "12 Mb",
                },
                new Animacao_trabalhos
                {
                    ID = 4,
                    Nome = "Train to Tokio",
                    Descricao = "Animação de Comboio à noite.",
                    SoftwareUsado = "Blender",
                    Duracao = "0.5 segundos",
                    UrlImagem = "https://placehold.co/600x400",
                    TamanhoFicheiro = "15 Mb",
                });
        }
    }
}
