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
    public partial class FireEmployee : Form
    {
        public DateTime TerminationDate { get; set; }

        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public FireEmployee(int id = 0)
        {
            InitializeComponent();
            
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
