using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week5Lesson27
{
    public partial class AddEditEmployee : Form
    {
        private string _filePath = Program.FilePath;

        private int _employeeId;
        private Employee _employee;

        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);


        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();

            _employeeId = id;

            GetEmployeeData();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);

                if (_employee == null)
                    throw new Exception("Brak pracownika o podanym Id");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            dtpHireDate.Value = _employee.HireDate;            
            tbComments.Text = _employee.Comments;
            tbSalary.Text = _employee.Salary.ToString();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            AddNewEmployeeToList(employees);

            _fileHelper.SerializeToFile(employees);

            Close();
        }

        private void AddNewEmployeeToList(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                HireDate = dtpHireDate.Value,           
                Salary = double.Parse(tbSalary.Text),
                Comments = tbComments.Text,
            };

            employees.Add(employee);
        }

        private void AssignIdToNewEmployee(List<Employee> students)
        {
            var employeeWithHighestId = students
           .OrderByDescending(x => x.Id).FirstOrDefault();

            _employeeId = employeeWithHighestId == null ?
                1 : employeeWithHighestId.Id + 1;
        }
    }
}
