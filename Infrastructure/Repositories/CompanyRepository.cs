using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DbContextOptions<AppDbContext> _options;


        public CompanyRepository(DbContextOptions<AppDbContext> options)
        {
            _options = options;
        }

        public async Task<List<Company>> GetAllAsync()
        {
            using var _context = new AppDbContext(_options);

            return await _context.Companies.ToListAsync();
        }

        //Obtener una empresa por su Id (no se usa en este contexto, lo quise dejar por si se va a utilizar despues)
        public async Task<Company> GetByIdAsync(int id)
        {
            using var _context = new AppDbContext(_options);

            return await _context.Companies.FindAsync(id);
        }

        //Acá se llama se crea una nueva compañia 
        public async Task AddAsync(Company company)
        {
            using var _context = new AppDbContext(_options);

            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
        }

        //Acá se actualiza la compañia por id
        public async Task UpdateAsync(Company company)
        {
            using var _context = new AppDbContext(_options);

            var existingCompany = await _context.Companies.FindAsync(company.EmpresaId);
            if (existingCompany == null)
                throw new Exception("La empresa no existe.");

            existingCompany.Nombre = company.Nombre;
            existingCompany.Codigo = company.Codigo;
            existingCompany.Direccion = company.Direccion;
            existingCompany.Telefono = company.Telefono;
            existingCompany.Ciudad = company.Ciudad;
            existingCompany.Departamento = company.Departamento;
            existingCompany.Pais = company.Pais;
            existingCompany.FechaActualizacion = DateTime.Now;

            await _context.SaveChangesAsync();
        }

        //Acá se elimina la compañia por id
        public async Task DeleteAsync(int id)
        {
            using var _context = new AppDbContext(_options);

            var entity = await _context.Companies.FindAsync(id);
            if (entity != null)
            {
                _context.Companies.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //Acá se filtra la informacón por nombre
        public async Task<List<Company>> GetCompaniesByNameAsync(string name)
        {
            using var _context = new AppDbContext(_options);

            return await _context.Companies
                .Where(c => c.Nombre.Contains(name))
                .ToListAsync();
        }
    }
}
