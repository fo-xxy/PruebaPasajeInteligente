using Domain.Entities;
using Presentation.Views;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class CompanyPresenter
    {
        private ICompanyView _view;
        private readonly CompanyService _service;

        public CompanyPresenter(ICompanyView view, CompanyService service)
        {
            _view = view;
            _service = service;
        }

        public void SetView(ICompanyView view)
        {
            _view = view;
        }

        //extrae la infromación de las empresas
        public async Task LoadCompaniesAsync()
        {
            var companies = await _service.GetAllCompanyAsync();
            _view.SetCompanies(companies);
        }

        //Envia la información de la empresa a insertar
        public async Task AddCompanyAsync()
        {
            var company = _view.GetCompanyInput();
            if (company != null)
            {
                await _service.CreateCompmanyAsync(company);
                _view.ShowMessage("Empresa agregada correctamente");
                await LoadCompaniesAsync();
            }
        }

        //Filtrar empresas por nombre
        public async Task FilterCompaniesAsync(string filter)
        {
            List<Company> companies;

            if (string.IsNullOrEmpty(filter))
            {
                companies = await _service.GetAllCompanyAsync();
            }
            else
            {
                companies = await _service.GetCompaniesByNameAsync(filter);
            }

            _view.SetCompanies(companies);
        }

        //Envia la información de la empresa a actualizar
        public async Task UpdateCompanyAsync()
        {
            var company = _view.GetCompanyInput();
            if (company != null)
            {
                await _service.UpdateCompanyAsync(company);
                _view.ShowMessage("Empresa actualizada correctamente");
                await LoadCompaniesAsync();
            }
        }

        //Envia la información de la empresa a eliminar
        public async Task DeleteCompaniesAsync(List<Company> companies)
        {
            foreach (var company in companies)
            {
                await _service.DeleteCompnayAsync(company.EmpresaId);
            }

            _view.ShowMessage($"{companies.Count} empresa(s) eliminadas correctamente.");
            await LoadCompaniesAsync();
        }
    }
}
