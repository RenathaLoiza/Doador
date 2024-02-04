﻿namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int DoadorID { get; set; }
        public string DoadorNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
