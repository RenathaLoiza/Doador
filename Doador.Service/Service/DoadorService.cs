using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Service.Service
{
    public class DoadorService : IdoadorService
    {
        private readonly IdoadorRepository _Repository;

        public DoadorService(IdoadorRepository repository)
        {
            _Repository = repository;
        }
        public async Task<string> DeleteAsync(int DoadorID)
        {
            return await _Repository.DeleteAsync(DoadorID);
        }

        public async Task<string> GetActionAsync()
        {
            return await _Repository.GetActionAsync();
        }

        public async Task<string> PostCadastrarAsync(DoadorCommand command)
        {

            return await _Repository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command)
        {

            return await _Repository.PutAtualizarAsync(DoadorID , command);
        }
    }
}
