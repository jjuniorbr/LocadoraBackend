using Locadora.BusinessEntity.Cliente;
using Locadora.DataAccess.Cliente;
using System;

namespace Locadora.BusinessLogic.Cliente
{
    public class ClienteBusinessLogic
    {
        private readonly ClienteDao _clienteDao;

        public ClienteBusinessLogic()
        {
            _clienteDao = new ClienteDao();
        }

        public ClienteEntity IncluirCliente(ClienteEntity cliente)
        {
            ClienteEntity _cliente = ObterClientePorCPF(cliente.Cpf);
            
            if (_cliente != null )
                throw new Exception("Cliente já existe");
            
            return _clienteDao.IncluirCliente(cliente);

        }

        public ClienteEntity ObterClientePorCPF(string cpf)
        {
            return _clienteDao.ObterClientePorCPF(cpf);
        }

        public ClienteEntity InativarClientePorCPF(string cpf)
        {
           return _clienteDao.InativarClientePorCPF(cpf);
        }
    }
}