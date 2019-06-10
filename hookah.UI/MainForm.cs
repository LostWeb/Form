using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hookah;

namespace hookah.UI
{
    public partial class MainForm : Form
    {
        public List<Employee> Employees;
        public List<Client> Clients;
        public MainForm()
        {
            InitializeComponent();
            Clients = new List<Client>();
            Employees = new List<Employee>();
            Employees.Add(new Employee { FullName = "Владислав Долболоб", Experience = 5 });
            Employees.Add(new Employee { FullName = "Ярослав Дым", Experience = 2 });
            Employees.Add(new Employee { FullName = "Генадий Пар", Experience = 4 });
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = ClientsListBox.SelectedIndex;
            if (ClientsListBox.SelectedItem is Client)
            {
                var form = new EditClient(Clients[index], ClientsListBox, Clients);
                form.ShowDialog();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddClient(Clients, ClientsListBox);
            form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var index = ClientsListBox.SelectedIndex;
            if (ClientsListBox.SelectedItem is Client)
            {
                Clients.Remove(Clients[index]);
                ClientsListBox.DataSource = null;
                ClientsListBox.DataSource = Clients;
                OrdersListBox.DataSource = null;
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var index = ClientsListBox.SelectedIndex;
            if (ClientsListBox.SelectedItem is Client)
            {
                var form = new AddOrder(Clients, Employees, Clients[index], OrdersListBox);
                form.ShowDialog();
            }
        }

        private void ClientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ClientsListBox.SelectedIndex;
            if (ClientsListBox.SelectedItem is Client)
            {
                OrdersListBox.DataSource = null;
                OrdersListBox.DataSource = Clients[index].Orders;
            }
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            var clientIndex = ClientsListBox.SelectedIndex;
            var orderIndex = OrdersListBox.SelectedIndex;

            if (OrdersListBox.SelectedItem is Order)
            {
                var form = new EditOrder(Clients[clientIndex].Orders[orderIndex], Employees, OrdersListBox, Clients[clientIndex].Orders);
                form.ShowDialog();
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            var clientIndex = ClientsListBox.SelectedIndex;
            var orderIndex = OrdersListBox.SelectedIndex;

            if (OrdersListBox.SelectedItem is Order)
            {
                var order = Clients[clientIndex].Orders[orderIndex];
                Clients[clientIndex].Orders.Remove(order);

                OrdersListBox.DataSource = null;
                OrdersListBox.DataSource = Clients[clientIndex].Orders;
            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Employees(Employees);
            form.ShowDialog();
        }
    }
}
