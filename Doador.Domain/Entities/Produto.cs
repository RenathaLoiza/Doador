﻿namespace Doador.Domain.Entities
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string QuantidadeDisponivelParaDoacao { get; set; }
        public string DoadorId { get; set; }
    }
}
