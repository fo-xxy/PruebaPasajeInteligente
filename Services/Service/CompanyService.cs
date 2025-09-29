using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class CompanyService
    {
        private readonly ICompanyRepository _repository;

        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }

        //Envia la petición al repositorio para obtener todas las empresas
        public async Task<List<Company>> GetAllCompanyAsync()
        {
            return await _repository.GetAllAsync();
        }

        //Envia la petición al repositorio para crear una empresa
        public async Task CreateCompmanyAsync(Company empresa)
        {
            await _repository.AddAsync(empresa);
        }

        //Envia la petición al repositorio para actualizar una empresa
        public async Task UpdateCompanyAsync(Company empresa)
        {
            await _repository.UpdateAsync(empresa);
        }

        //Envia la petición al repositorio para eliminar una empresa
        public async Task DeleteCompnayAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        //Envia la petición al repositorio para buscar empresas por nombre
        public async Task<List<Company>> GetCompaniesByNameAsync(string name)
        {
            return await _repository.GetCompaniesByNameAsync(name);
        }
    }
}
