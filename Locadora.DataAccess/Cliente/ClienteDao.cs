using Locadora.BusinessEntity.Cliente;
using Locadora.DataAccess.Resources.Database;

namespace Locadora.DataAccess.Cliente
{
    public class ClienteDao
    {
        public ClienteEntity IncluirCliente(ClienteEntity cliente)
        {   
            return Clientes.IncluirCliente(cliente);
        }

        public ClienteEntity ObterClientePorCPF(string cpf)
        {
            return Clientes.ObterClientePorCPF(cpf);
        }

        public ClienteEntity InativarClientePorCPF(string cpf)
        {
            return Clientes.InativarClientePorCPF(cpf);
        }
    }
}