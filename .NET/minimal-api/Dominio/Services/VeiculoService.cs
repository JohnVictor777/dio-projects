using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interfaces;
using minimal_api.Infraestrutura.Data;

namespace minimal_api.Dominio.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly MinimalApiDbContext _context;
        public VeiculoService(MinimalApiDbContext context)
        {
            _context = context;
        }

        public void Alterar(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }

        public Veiculo? BuscarPorId(int id)
        {
            return _context.Veiculos.Where(v => v.Id == id).FirstOrDefault();
        }

        public void Excluir(Veiculo veiculo)
        {
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }

        public void Incluir(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public List<Veiculo> Todos(int pagina = 1, string? nome = null, string? marca = null)
        {
            var query = _context.Veiculos.AsQueryable();
            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome.ToLower()}%"));
            }

            int itensPorPagina = 10;
            query = query.Skip((pagina - 1) * itensPorPagina)
                         .Take(itensPorPagina)
                         .OrderBy(v => v.Nome);

            return query.ToList();
        }
    }
}