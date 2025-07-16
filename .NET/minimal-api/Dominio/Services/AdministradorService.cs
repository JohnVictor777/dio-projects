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
        public AdministradorService(MinimalApiDbContext context)
        {
            _context = context;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }
    }
}