using System;

namespace Locadora.BusinessEntity.Cliente
{
    public class ClienteEntity
    {
        public ClienteEntity() { }
          
        public ClienteEntity(int id, string cpf, string nome, bool ativo = default, DateTime dataCadastro = default)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Ativo = ativo;
        }
        public int Id { get; }
        public string Cpf { get; }
        public string Nome { get; }
        public DateTime DataCadastro { get; }
        public bool Ativo { get; set; } 
    }
}