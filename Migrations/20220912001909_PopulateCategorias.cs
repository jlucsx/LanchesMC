using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMC.Migrations
{
    public partial class PopulateCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [Categorias] (CategoriaNome, Descricao) VALUES('Normal', 'Lanche feito com ingredientes normais.')");
            migrationBuilder.Sql(@"INSERT INTO [Categorias] (CategoriaNome, Descricao) VALUES ('Natural', 'Feito com ingredientes naturais.')");
            migrationBuilder.Sql(@"INSERT INTO [Categorias] (CategoriaNome, Descricao) VALUES ('Artificial', 'Feito com ingredientes artificiais.')");
            migrationBuilder.Sql(@"INSERT INTO [Categorias] (CategoriaNome, Descricao) VALUES('Angelical', 'Feito com ingredientes angelicais.')");
            migrationBuilder.Sql(@"INSERT INTO [Categorias] (CategoriaNome, Descricao) VALUES ('Teatral', 'Feito com ingredientes teatrais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Categorias]");
        }
    }
}
