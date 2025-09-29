using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    //Interfaces de los metodos del repositorio
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task AddAsync(Company company);
        Task UpdateAsync(Company company);
        Task DeleteAsync(int id);
        Task<List<Company>> GetCompaniesByNameAsync(string name);
    }
}
