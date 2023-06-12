using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud_User_WCF.Data.Migrations
{
    public partial class create_view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
             SET ANSI_NULLS ON
			GO

			SET QUOTED_IDENTIFIER ON
			GO

			CREATE VIEW [dbo].[USUARIO_ENDERECO_VW]
			AS
			  SELECT S.Id,
					 S.CPF,
					 s.Nome,
					 S.RG,
					 S.DataExpedicao,
					 S.OrGaoExpedicao,  
					 S.UF UFExpedicao,
					 S.DataNascimento,
					 S.Sexo,
					 S.EstadoCivil,
					 D.CEP,
					 D.Logradouro,
					 D.Numero,
					 D.Complemento,
					 D.Bairro,
					 D.Cidade,
					 D.UF FROM Usuario as S
			  INNER JOIN Endereco AS D on D.IdUsuario = S.Id
			GO");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
