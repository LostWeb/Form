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
    public partial class EditOrder : Form
    {
        public List<Order> Orders;
        public Order Order;
        public List<Employee> Employees;
        public ListBox OrdersListBox;
        public EditOrder(Order order, List<Employee> employees, ListBox ordersListBox, List<Order> orders)
        {
            Orders = orders;
            Order = order;
            Employees = employees;
            OrdersListBox = ordersListBox;
            InitializeComponent();
            hookahComboBox.DataSource = Employees;
            strengthComboBox.SelectedItem = GetStringStrength(Order.Strength);
            tobaccoComboBox.SelectedItem = GetStringTobaco(Order.Tobaco);
            typeComboBox.SelectedItem = GetTypeString(Order.Type);
            priceTextBox.Text = Order.Price.ToString();
            hookahComboBox.SelectedItem = Order.Employee;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (GetStrength(strengthComboBox.SelectedItem.ToString()) != Order.Strength)
            {
                Order.Strength = GetStrength(strengthComboBox.SelectedItem.ToString());
                check = true;
            }

            if (GetTobaco(tobaccoComboBox.SelectedItem.ToString()) != Order.Tobaco)
            {
                Order.Tobaco = GetTobaco(tobaccoComboBox.SelectedItem.ToString());
                check = true;
            }

            if (GetType(typeComboBox.SelectedItem.ToString()) != Order.Type)
            {
                Order.Type = GetType(typeComboBox.SelectedItem.ToString());
                check = true;
            }

            if (priceTextBox.Text != "" && CheckDouble(priceTextBox.Text) &&
                ParseToDouble(priceTextBox.Text) != Order.Price)
            {
                Order.Price = ParseToDouble(priceTextBox.Text);
                check = true;
            }

            if (hookahComboBox.SelectedItem != Order.Employee)
            {
                Order.Employee = (Employee)hookahComboBox.SelectedItem;
                check = true;
            }

            if (check)
            {
                OrdersListBox.DataSource = null;
                OrdersListBox.DataSource = Orders;
                Close();
            }
            else
                exception.Visible = true;
        }

        private Type GetType(string info)
        {
            switch (info)
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

        private string GetTypeString(Type info)
        {
            switch (info)
            {
                case Type.milk:
                    return "На молоке";
                case Type.fruits:
                    return "С фруктами";
                case Type.mint:
                    return "С мятой и льдом";
                default:
                    throw new Exception();
            }
        }

        private Tobaco GetTobaco(string info)
        {
            switch (info)
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

        private string GetStringTobaco(Tobaco info)
        {
            switch (info)
            {
                case Tobaco.ALFAKHER:
                    return "ALFAKHER";
                case Tobaco.NAKHLA:
                    return "NAKHLA";
                case Tobaco.AFZAL:
                    return "AFZAL";
                case Tobaco.ADALYA:
                    return "ADALYA";
                case Tobaco.SERBETLI:
                    return "SERBETLI";
                case Tobaco.DARKSIDE:
                    return "DARKSIDE";
                case Tobaco.TANGIERS:
                    return "TANGIERS";
                default:
                    throw new Exception();
            }
        }

        private Strength GetStrength(string info)
        {
            switch (info)
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

        private string GetStringStrength(Strength info)
        {
            switch (info)
            {
                case Strength.light:
                    return "Лёгкая";
                case Strength.middle:
                    return "Средняя";
                case Strength.heavy:
                    return "Тяжёлая";
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
