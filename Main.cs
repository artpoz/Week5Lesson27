﻿using System;
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

        private List<Group> _groups;

        public Main()
        {
            InitializeComponent();

            _groups = GroupsHelper.GetGroups();

            cbFilter.DataSource = _groups;
            cbFilter.DisplayMember = "Name";
            cbFilter.ValueMember = "Id";

            RefreshDatabase();
            SetColumnHeader();
            HideColumns();
        }

        private void SetColumnHeader()
        {
            dgvEmployeeDatabase.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
            dgvEmployeeDatabase.Columns[nameof(Employee.FirstName)].ReadOnly = true;
            dgvEmployeeDatabase.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dgvEmployeeDatabase.Columns[nameof(Employee.LastName)].ReadOnly = true;
            dgvEmployeeDatabase.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
            dgvEmployeeDatabase.Columns[nameof(Employee.Comments)].ReadOnly = true;
            dgvEmployeeDatabase.Columns[nameof(Employee.Salary)].HeaderText = "Pensja";
            dgvEmployeeDatabase.Columns[nameof(Employee.Salary)].ReadOnly = true;
            dgvEmployeeDatabase.Columns[nameof(Employee.HireDate)].HeaderText = "Data zatrudnienia";
            dgvEmployeeDatabase.Columns[nameof(Employee.HireDate)].ReadOnly = true;
            dgvEmployeeDatabase.Columns[nameof(Employee.TerminationDate)].HeaderText = "Data zwolnienia";
            dgvEmployeeDatabase.Columns[nameof(Employee.TerminationDate)].ReadOnly = true;
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
            var selectedGroupId = (cbFilter.SelectedItem as Group).Id;          

            if (selectedGroupId != 0)
            {
                if (selectedGroupId == 1)
                    employees = employees.Where(x => x.TerminationDate.ToString() == "01.01.0001 00:00:00").ToList();

                if (selectedGroupId == 2)
                    employees = employees.Where(x => x.TerminationDate.ToString() != "01.01.0001 00:00:00").ToList();
            }
            dgvEmployeeDatabase.DataSource = employees;
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeDatabase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego chcesz zwolnić");
                return;
            }
            
            int employeeId = Convert.ToInt32(dgvEmployeeDatabase.SelectedRows[0].Cells["Id"].Value);

            var employees = _fileHelper.DeserializeFromFile();
            var employee = employees.FirstOrDefault(x => x.Id == employeeId);

            var fireEmployee = new FireEmployee(employeeId);
            var result = fireEmployee.ShowDialog();

            if (result == DialogResult.OK)
            {

                employee.TerminationDate = fireEmployee.TerminationDate;

                _fileHelper.SerializeToFile(employees);

                RefreshDatabase();

                MessageBox.Show($"Pracownik {employee.FirstName} {employee.LastName} został zwolniony.", "Zwolniony", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
