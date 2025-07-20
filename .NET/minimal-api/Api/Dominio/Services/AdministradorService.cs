using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interfaces;
using minimal_api.Infraestrutura.Data;

namespace minimal_api.Dominio.Services
{
    public class AdministradorService : IAdministradorService
    {
        private readonly MinimalApiDbContext _context;
        // Construtor que recebe o DbContext via injeção de dependência.
        public AdministradorService(MinimalApiDbContext context)
        {
            _context = context;
        }
        // Busca um administrador pelo ID.
        public Administrador? BuscarPorId(int id)
        {
            return _context.Administradores.Where(a => a.Id == id).FirstOrDefault();
        }
        // Adiciona um novo administrador ao banco de dados
        public Administrador Incluir(Administrador administrador)
        {
            _context.Administradores.Add(administrador);
            _context.SaveChanges();
            return administrador;
        }
        // Realiza o login de um administrador verificando email e senha 
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }
        // Retorna uma lista de todos os administradores, com opção de paginação
        public List<Administrador> Todos(int? pagina)
        {
            var query = _context.Administradores.AsQueryable();

            int itensPorPagina = 10;
            // Aplica a paginação se um número de página for fornecido.
            if (pagina != null)
                query = query.Skip((pagina.Value - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }
    }
}