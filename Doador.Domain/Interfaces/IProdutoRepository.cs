﻿using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<string> PostCadastrarAsync(ProdutoCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command);
        Task<string> DeleteAsync(int ProdutoID);
    }
}
