using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IdoadorRepository
    {
        Task<string> PostCadastrarAsync(DoadorCommand command);
        Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command);
        Task<string> GetActionAsync();
        Task<string> DeleteAsync(int DoadorID);
        
    }
}
