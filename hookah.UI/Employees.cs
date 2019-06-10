using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hookah.UI
{
    public partial class Employees : Form
    {
        public List<Employee> EmployeesList;
        public Employees(List<Employee> list)
        {
            EmployeesList = list;
            InitializeComponent();
            employeesListBox.DataSource = null;
            employeesListBox.DataSource = list;
        }
    }
}
