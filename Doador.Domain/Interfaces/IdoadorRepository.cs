using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IdoadorRepository
    {
        Task<string> PostCadastrarAsync(DoadorCommand command);
        Task<String> PutAtualizarAsync(int DoadorID, DoadorCommand command);
        Task<string> GetActionAsync();
        Task<String> DeleteAsync(int DoadorID);
    }
}
