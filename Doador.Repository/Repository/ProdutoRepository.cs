using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroDoador;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> DeleteAsync(int ProdutoID)
        {
            string queryDeleteProduto = "DELETE FROM Produto WHERE ProdutoID = @ProdutoID";
            using (SqlConnection conn = new SqlConnection(banco))

                await conn.ExecuteAsync(queryDeleteProduto, new { ProdutoID = ProdutoID });

            return "Exclusão realizada com sucesso";

        }
        //bucar algo
        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostCadastrarAsync(ProdutoCommand command)
        {
            string queryInsertDoador = @"
            insert into Doador (produtoNome ,descricao ,categoria,QuantidadeDisponivelParaDoacao,DoadorId ) 
            values (@produtoNome ,@descricao ,@categoria,@QuantidadeDisponivelParaDoacao,@DoadorId ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryInsertDoador, new
                {
                    ProdutoNome = command.ProdutoNome,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                    DoadorId = command.DoadorId,
                    

                });

                return "Cadastro realizado com sucesso";
            }
        }

        public async Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            string queryUpdateDoador = "UPDATE Produto SET  (produtoNome ,descricao ,categoria,QuantidadeDisponivelParaDoacao,DoadorId )" +
                 "WHERE (@produtoNome ,@descricao ,@categoria,@QuantidadeDisponivelParaDoacao,@DoadorId)";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryUpdateDoador, new
                {
                    ProdutoNome = command.ProdutoNome,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                    DoadorId = command.DoadorId,

                });
                return "Atualização realizado com sucesso";

            }
        }
    }
}
