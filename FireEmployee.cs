using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Week5Lesson27
{
    public partial class FireEmployee : Form
    {
        public DateTime TerminationDate { get; set; }

        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public FireEmployee(int id = 0)
        {
            InitializeComponent();
                      
            var employees = _fileHelper.DeserializeFromFile();
            var employee = employees.FirstOrDefault(x => x.Id == id);

            if (employee.TerminationDate.ToString() != "01.01.0001 00:00:00")
                dtpTerminationDate.Value = employee.TerminationDate;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            TerminationDate = dtpTerminationDate.Value;
            DialogResult = DialogResult.OK;

            _fileHelper.SerializeToFile(employees);

            Close();
        }
    }
}
