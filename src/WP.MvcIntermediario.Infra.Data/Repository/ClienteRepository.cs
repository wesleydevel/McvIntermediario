using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WP.MvcIntermediario.Dominio.Interfaces;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> ObterAtivos()
        {

            //throw new Exception("THE TRETA HAS BEEN PLANTED");
            var sql = @"SELECT * FROM CLIENTES C " +
                       "WHERE C.EXCLUIDO = 0 AND ATIVO = 1";

            return Db.Database.Connection.Query<Cliente>(sql);

            //return Buscar(c => c.Ativo && !c.Excluido);
        }
        public override Cliente ObterPorId(Guid id)
        {
            var sql = @"SELECT * FROM Clientes c " +
                       "LEFT JOIN Enderecos e " +
                       "on c.id = e.clienteId" +
                       " where c.id = @uid and c.Exluido = 0 and C.Ativo = 1 ";
            return Db.Database.Connection.Query<Cliente, Endereco, Cliente>(sql,
                (c, e) =>
                {
                    c.Enderecos.Add(e);
                    return c;
                }, new {uid = id }).FirstOrDefault();
        }
        public Cliente ObterPorCpf(string cpf) => Buscar(c => c.CPF == cpf && !c.Excluido).FirstOrDefault();

        public Cliente ObterPorEmail(string email) => Buscar(c => c.Email == email && !c.Excluido).FirstOrDefault();

        public override void Remover(Guid id)
        {
            var cliente = ObterPorId(id);
            cliente.Excluir();
            Atualizar(cliente);
        }
    }
}
