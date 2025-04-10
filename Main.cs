using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Lesson27
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();
            RefreshDatabase();
            SetColumnHeader();
            HideColumns();
        }

        private void SetColumnHeader()
        {
            dgvEmployeeDatabase.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
            dgvEmployeeDatabase.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dgvEmployeeDatabase.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
            dgvEmployeeDatabase.Columns[nameof(Employee.Salary)].HeaderText = "Pensja";
            dgvEmployeeDatabase.Columns[nameof(Employee.HireDate)].HeaderText = "Data zatrudnienia";
            dgvEmployeeDatabase.Columns[nameof(Employee.TerminationDate)].HeaderText = "Data zwolnienia";
        }

        private void HideColumns()
        {
            dgvEmployeeDatabase.Columns[nameof(Employee.Id)].Visible = false;       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeDatabase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego dane chcesz edytować");
                return;
            }

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployeeDatabase.SelectedRows[0].Cells[0].Value));

            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDatabase();
        }



        public void RefreshDatabase()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvEmployeeDatabase.DataSource = employees;
        }
    }
}
