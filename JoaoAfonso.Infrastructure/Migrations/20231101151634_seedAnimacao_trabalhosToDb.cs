using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JoaoAfonso.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedAnimacao_trabalhosToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animacao_Trabalhos",
                columns: new[] { "ID", "Descricao", "Duracao", "Nome", "SoftwareUsado", "TamanhoFicheiro", "UrlImagem" },
                values: new object[,]
                {
                    { 1, "Animação de um cogumelo numa floresta mágica rodeado de borboletas luminosas.", "0.5 segundos", "Magic Mushrooms", "Blender", "10 Mb", "https://placehold.co/600x400" },
                    { 2, "Animação de uma morgue.", "0.5 segundos", "Rigor Mortis", "Blender", "16 Mb", "https://placehold.co/600x400" },
                    { 3, "Animação de eletrico.", "0.5 segundos", "Eletrico", "Blender", "12 Mb", "https://placehold.co/600x400" },
                    { 4, "Animação de Comboio à noite.", "0.5 segundos", "Train to Tokio", "Blender", "15 Mb", "https://placehold.co/600x400" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animacao_Trabalhos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animacao_Trabalhos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animacao_Trabalhos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animacao_Trabalhos",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
