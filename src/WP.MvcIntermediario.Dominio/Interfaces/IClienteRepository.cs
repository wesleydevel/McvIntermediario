using System.Collections.Generic;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Dominio.Interfaces
{
    public interface IClienteRepository: IRepository<Cliente>, IRepositoryWrite<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        IEnumerable<Cliente> ObterAtivos();
        //Cliente ObterClienteUnico(Cliente cliente);
    }
}
