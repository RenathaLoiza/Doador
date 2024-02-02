using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Service.Service
{
    public class DoadorService : IdoadorService
    {
        public Task<string> DeleteAsync(int DoadorID)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> PostCadastrarAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
