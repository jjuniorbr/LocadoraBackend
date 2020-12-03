using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.BusinessEntity.Cliente;
using Locadora.BusinessEntity.Filme;

namespace Locadora.BusinessEntity.Locacao
{
    public class LocacaoEntity
    {
        public LocacaoEntity() { }
        
        public LocacaoEntity(int id, ClienteEntity cliente, FilmeEntity filme, DateTime dataLocacao = default, DateTime dataDevolucao = default, decimal valor = default)
        {
            Id = id;
            Cliente = cliente;
            Filme = filme;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
            Valor = valor;
        }             

        public int Id { get; }
        public ClienteEntity Cliente { get; }
        public FilmeEntity Filme { get; }
        public DateTime DataLocacao { get; }
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; }
    }
}
