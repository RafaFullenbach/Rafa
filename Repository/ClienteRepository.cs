using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Models;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using CadastroClientes.Controllers;
using CadastroClientes.Repository.Context;

namespace CadastroClientes.Repository
{
    public class ClienteRepository
    {
        private readonly DataBaseContext context;

        public ClienteRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Cliente> Listar()
        { 

          IList<Cliente> lista = new List<Cliente>();

          DataBaseContext ctx = new DataBaseContext();

          lista = ctx.Cliente.Where(c => c.IsDeleted == '0').ToList<Cliente>();

          return lista;
        }

        public Cliente Consultar(int id)
        {

            DataBaseContext ctx = new DataBaseContext();

            Cliente cliente = ctx.Cliente.Find(id);

            return cliente;
        }

        public void Inserir(Cliente cliente)
        {
            DataBaseContext ctx = new DataBaseContext();

            ctx.Cliente.Add(cliente);

            ctx.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
                context.Cliente.Update(cliente);
                context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var item = context.Cliente.Find(id);
            item.IsDeleted = '1';
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public IList<Cliente> Filtrar(String select, String input)
        {
            IList<Cliente> lista = new List<Cliente>();

            DataBaseContext ctx = new DataBaseContext();

            if (select == "NR_DOCUMENTO")
            {
                lista = ctx.Cliente.Where(c => c.nr_documento == input && c.IsDeleted == '0').ToList<Cliente>();
            }

            else
            {
                lista = ctx.Cliente.Where(c => c.nm_cliente == input && c.IsDeleted == '0').ToList<Cliente>();
            }

            return lista;
        }
    }
}

