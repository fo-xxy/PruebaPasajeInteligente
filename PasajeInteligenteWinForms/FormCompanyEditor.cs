using Domain.Entities;
using Presentation.Presenters;
using Presentation.Views;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PasajeInteligenteWinForms
{
    public partial class FormCompanyEditor : Form, ICompanyView
    {
        private readonly CompanyPresenter _presenter;
        private readonly Company _companyToEdit;

        public FormCompanyEditor(CompanyService service, Company company = null)
        {
            InitializeComponent();
            _presenter = new CompanyPresenter(this, service);

            if (company != null)
            {
                lblMessage.Text = "Editando Empresa";
                _companyToEdit = company;

                LoadCompanyData();
            }
            else
            {
                lblMessage.Text = "Creando nueva Empresa";

            }
        }

        // Cargar los datos de la empresa en los campos del formulario y lo llamamos en el constructor
        private void LoadCompanyData()
        {
            txtName.Text = _companyToEdit.Nombre;
            txtCode.Text = _companyToEdit.Codigo.ToString();
            txtAddress.Text = _companyToEdit.Direccion;
            txtPhone.Text = _companyToEdit.Telefono.ToString();
            txtCity.Text = _companyToEdit.Ciudad;
            txtDepartment.Text = _companyToEdit.Departamento;
            txtCountry.Text = _companyToEdit.Pais;
        }

        //Muestra las empresas en un DataGridView pero en este caso no se usa, pero se debe instanciar sino presenta fallas
        public void SetCompanies(List<Company> companies)
        {
            // Mostrar las empresas en un DataGridView
            //dataGridViewCompanies.DataSource = companies;
        }

        // Mostrar mensajes al usuario
        public void ShowMessage(string message)
        {
            // Mostrar un mensaje al usuario
            MessageBox.Show(message);
        }
        //Obtiene los datos del usuario desde los campos del formulario
        public Company GetCompanyInput()
        {
            return new Company
            {
                EmpresaId = _companyToEdit?.EmpresaId ?? 0,
                Nombre = txtName.Text,
                Codigo = Convert.ToInt16(txtCode.Text),
                Direccion = txtAddress.Text,
                Telefono = Convert.ToInt16(txtPhone.Text),
                Ciudad = txtCity.Text,
                Departamento = txtDepartment.Text,
                Pais = txtCountry.Text
            };
        }

        //Método para crear o actualizar una empresa
        private async void createCompany()
        {
            if (ValidateInput() == true )
            {
                if (_companyToEdit != null)
                {
                    if (ValidateInput() == true) { }
                    await this._presenter.UpdateCompanyAsync();
                    
                    this.Close();
                }
                else
                { 
                    await this._presenter.AddCompanyAsync();

                    this.Close();

                }
            }  
        }

        //Boton para crear o actualizar una empresa
        private void btnCreate_Click(object sender, EventArgs e)
        {
            createCompany();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio.", "Alerta");
                txtName.Focus();
                return false;
            }
            else if (txtCode.Text == string.Empty)
            {
                MessageBox.Show("El código es obligatorio.", "Alerta");
                txtCode.Focus();
                return false;

            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("La dirección es obligatoria.", "Alerta");
                txtAddress.Focus();
               return false;

            }
            else if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("El teléfono es obligatorio.", "Alerta");
                txtPhone.Focus();
                return false;

            }
            else if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("La ciudad es obligatoria.", "Alerta");
                txtCity.Focus();
                return false;

            }
            else if (txtDepartment.Text == string.Empty)
            {
                MessageBox.Show("El departamento es obligatorio.", "Alerta");
                txtDepartment.Focus();
                return false;

            }
            else if (txtCountry.Text == string.Empty)
            {
                MessageBox.Show("El país es obligatorio.", "Alerta");
                txtCountry.Focus();
                return false;

            }
            else
            {
                return true;
            }
        }

        //Validacion tipo de dato
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
