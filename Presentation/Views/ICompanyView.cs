using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ICompanyView
    {
        //Interface para la vista de empresas
        void SetCompanies(List<Company> companies);

        //Mostrar mensajes en la vista
        void ShowMessage(string message);

        //Obtener la información del formulario
        Company GetCompanyInput();
    }
}
