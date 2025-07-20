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
        // Construtor que recebe o DbContext via injeção de dependência
        public VeiculoService(MinimalApiDbContext context)
        {
            _context = context;
        }
        // Atualiza um veículo existente no banco de dados
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
        // Retorna uma lista de veículos, com opções de paginação e filtro por nome/marca
        public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
        {

            var query = _context.Veiculos.AsQueryable();
            // Aplica filtro por nome se fornecido (case-insensitive e busca parcial)
            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome.ToLower()}%"));
            }

            int itensPorPagina = 10;
            // Aplica paginação e ordenação se um número de página for fornecido.
            if (pagina != null)
                query = query.Skip(((int)pagina - 1) * itensPorPagina)
                             .Take(itensPorPagina)
                             .OrderBy(v => v.Nome);


            return query.ToList();
        }
    }
}