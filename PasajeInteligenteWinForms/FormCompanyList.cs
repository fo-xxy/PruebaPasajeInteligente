using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;
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

namespace PasajeInteligenteWinForms
{
    public partial class FormCompanyList : Form, ICompanyView
    {
        private readonly CompanyPresenter _presenter;
        private readonly CompanyService _service;

        public FormCompanyList(CompanyService service)
        {
            InitializeComponent();
            _presenter = new CompanyPresenter(this, service);
            _service = service;
            configurationDataGrid();
        }

        public void SetCompanies(List<Company> companies)
        {
            dataGridView1.DataSource = companies;

            if (dataGridView1.Columns.Contains("EmpresaId"))
                dataGridView1.Columns["EmpresaId"].Visible = false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public Company GetCompanyInput()
        {
            /*return new Company
            {
                Nombre = txtNombre.Text,
                Codigo = int.Parse(txtCodigo.Text),
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Ciudad = txtCiudad.Text,
                Departamento = txtDepartamento.Text,
                Pais = txtPais.Text
            };*/
            return new Company();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await _presenter.AddCompanyAsync();
        }

        //Se cargan los datos al iniciar el formulario
        private async void FormCompanyList_Load(object sender, EventArgs e)
        { 
            await _presenter.LoadCompaniesAsync();
        }

        //Configuración del DataGridView
        public void configurationDataGrid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Seleccionar",
                HeaderText = "Seleccionar",
                Width = 50
            };

            if (!dataGridView1.Columns.Contains("Seleccionar"))
            {
                dataGridView1.Columns.Insert(0, checkColumn);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }


        //Método para obtener las empresas seleccionadas
        public List<Company> GetSelectedCompanies()
        {
            var selected = new List<Company>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var isChecked = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                if (isChecked && row.DataBoundItem is Company company)
                {
                    selected.Add(company);
                }
            }
            return selected;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        public async void filtro()
        {
            string filter = txtFilter.Text;
            await _presenter.FilterCompaniesAsync(filter);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCompanies();
        }

        //Método para eliminar empresas seleccionadas
        public async void deleteCompanies()
        {
            var selectedCompanies = GetSelectedCompanies();
            if (selectedCompanies.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna empresa.", "Alerta");
                return;
            }

            await _presenter.DeleteCompaniesAsync(selectedCompanies);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var editorForm = new FormCompanyEditor(_service);
            editorForm.ShowDialog();

            _ = _presenter.LoadCompaniesAsync().ContinueWith(t =>
            {
                if (t.Exception != null)
                    MessageBox.Show(t.Exception.Message);
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedCompanies = GetSelectedCompanies();
            if (selectedCompanies.Count != 1)
            {
                MessageBox.Show("Seleccione exactamente una empresa para actualizar.", "Alerta");
                return;
            }

            var companyToEdit = selectedCompanies.First();
            var editorForm = new FormCompanyEditor(_service, companyToEdit);
            editorForm.ShowDialog();

            _presenter.LoadCompaniesAsync();
        }
    }
}
