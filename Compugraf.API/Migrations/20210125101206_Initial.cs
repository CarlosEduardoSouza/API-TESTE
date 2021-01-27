using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compugraf.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 30, nullable: false),
                    Nacionalidade = table.Column<string>(maxLength: 30, nullable: false),
                    CEP = table.Column<string>(maxLength: 9, nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    Estado = table.Column<string>(maxLength: 30, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
