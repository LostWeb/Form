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
    public partial class EditClient : Form
    {
        public List<Client> Clients;
        public Client Client;
        public ListBox ClientListBox;
        public EditClient(Client client, ListBox clientListBox, List<Client> clients)
        {
            Clients = clients;
            Client = client;
            ClientListBox = clientListBox;
            InitializeComponent();
            NameTextBox.Text = Client.Name;
            SurnameTextBox.Text = Client.Surname;
            dateTimePicker.Value = Client.DateOfBirth;
            dateTimePicker.MaxDate = new DateTime(2000, 12, 31);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (NameTextBox.Text != "" && NameTextBox.Text != Client.Name)
            {
                Client.Name = NameTextBox.Text;
                check = true;
            }

            if (SurnameTextBox.Text != "" && SurnameTextBox.Text != Client.Surname)
            {
                Client.Surname = SurnameTextBox.Text;
                check = true;
            }

            if (dateTimePicker.Value != Client.DateOfBirth)
            {
                Client.DateOfBirth = dateTimePicker.Value;
                check = true;
            }

            if (check)
            {
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
