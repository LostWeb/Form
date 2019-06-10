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
    public partial class AddOrder : Form
    {
        public List<Client> Clients;
        public List<Employee> Employees;
        public Client Client;
        public ListBox OrdersListBox;
        public AddOrder(List<Client> clients, List<Employee> employees, Client client, ListBox ordersListBox)
        {
            Clients = clients;
            Employees = employees;
            Client = client;
            OrdersListBox = ordersListBox;
            InitializeComponent();
            hookahComboBox.DataSource = Employees;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (strengthComboBox.SelectedItem != null && tobaccoComboBox.SelectedItem != null &&
                typeComboBox.SelectedItem != null && hookahComboBox.SelectedItem != null &&
                priceTextBox.Text != "" && CheckDouble(priceTextBox.Text))
            {
                var order = new Order
                {
                    Strength = GetStrength(strengthComboBox.SelectedItem.ToString()),
                    Tobaco = GetTobaco(tobaccoComboBox.SelectedItem.ToString()),
                    Type = GetType(typeComboBox.SelectedItem.ToString()),
                    Price = ParseToDouble(priceTextBox.Text),
                    Employee = (Employee)hookahComboBox.SelectedItem
                };

                Client.Orders.Add(order);
                OrdersListBox.DataSource = null;
                OrdersListBox.DataSource = Client.Orders;
                Close();
            }
            else
                exception.Visible = true;
        }

        private Type GetType(string info)
        {
            switch(info)
            {
                case "На молоке":
                    return Type.milk;
                case "С фруктами":
                    return Type.fruits;
                case "С мятой и льдом":
                    return Type.mint;
                default:
                    throw new Exception();
            }
        }

        private Tobaco GetTobaco(string info)
        {
            switch(info)
            {
                case "ALFAKHER":
                    return Tobaco.ALFAKHER;
                case "NAKHLA":
                    return Tobaco.NAKHLA;
                case "AFZAL":
                    return Tobaco.AFZAL;
                case "ADALYA":
                    return Tobaco.ADALYA;
                case "SERBETLI":
                    return Tobaco.SERBETLI;
                case "DARKSIDE":
                    return Tobaco.DARKSIDE;
                case "TANGIERS":
                    return Tobaco.TANGIERS;
                default:
                    throw new Exception();
            }
        }

        private Strength GetStrength(string info)
        {
            switch(info)
            {
                case "Лёгкая":
                    return Strength.light;
                case "Средняя":
                    return Strength.middle;
                case "Тяжёлая":
                    return Strength.heavy;
                default:
                    throw new Exception();
            }
        }

        private bool CheckDouble(string number)
        {
            if (number.Contains(","))
                number.Replace(",", ".");
            return double.TryParse(number, out double n);
        }

        private double ParseToDouble(string number)
        {
            if (number.Contains(","))
                number.Replace(",", ".");
            return double.Parse(number);
        }
    }
}
