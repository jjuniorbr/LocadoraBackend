using Locadora.BusinessEntity.Cliente;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.DataAccess.Resources.Database
{
    static class Clientes
    {
        public static List<ClienteEntity> _Clientes;

        static Clientes() { _Clientes = new List<ClienteEntity>(); }

        public static ClienteEntity IncluirCliente(ClienteEntity cliente)
        {
            _Clientes.Add(new ClienteEntity(cliente.Id, cliente.Cpf, cliente.Nome, cliente.Ativo, cliente.DataCadastro));
            return _Clientes.LastOrDefault();
        }

        public static ClienteEntity ObterClientePorCPF(string cpf)
        {
            var _cliente = _Clientes.Where(cli => cli.Cpf.Equals(cpf)).FirstOrDefault();
            return _cliente;
        }

        public static ClienteEntity InativarClientePorCPF(string cpf)
        {
            var _cliente   = _Clientes.FirstOrDefault(cli => cli.Cpf.Equals(cpf));
            _cliente.Ativo = false;

            return _cliente;
        }
    }
}