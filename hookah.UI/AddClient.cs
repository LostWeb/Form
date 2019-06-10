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
    public partial class AddClient : Form
    {
        public List<Client> Clients;
        public ListBox ClientListBox;
        public AddClient(List<Client> clients, ListBox clientListBox)
        {
            Clients = clients;
            ClientListBox = clientListBox;
            InitializeComponent();
            dateTimePicker.MaxDate = new DateTime(2000, 12, 31);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "")
            {
                var client = new Client()
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    DateOfBirth = dateTimePicker.Value,
                    Orders = new List<Order>()
                };

                Clients.Add(client);
                ClientListBox.DataSource = null;
                ClientListBox.DataSource = Clients;
                Close();
            }
            else
            {
                exception.Visible = true;
            }
        }
    }
}
