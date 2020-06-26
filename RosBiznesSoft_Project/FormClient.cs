using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosBiznesSoft_Project
{
    public partial class FormClient : Form
    {
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.rbs.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.Name,
                    clientsSet.Address, clientsSet.INN,
                    clientsSet.Phone
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsSet clientsSet = new ClientsSet();
            clientsSet.Name = textBoxName.Text;
            clientsSet.Address = textBoxAddress.Text;
            clientsSet.INN = textBoxINN.Text;
            clientsSet.Phone = textBoxPhone.Text;
            Program.rbs.ClientsSet.Add(clientsSet);
            Program.rbs.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                clientsSet.Name = textBoxName.Text;
                clientsSet.Address = textBoxAddress.Text;
                clientsSet.INN = textBoxINN.Text;
                clientsSet.Phone = textBoxPhone.Text;
                Program.rbs.SaveChanges();
                ShowClient();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxName.Text = clientsSet.Name;
                textBoxAddress.Text = clientsSet.Address;
                textBoxINN.Text = clientsSet.INN;
                textBoxPhone.Text = clientsSet.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxINN.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.rbs.ClientsSet.Remove(clientsSet);
                    Program.rbs.SaveChanges();
                    ShowClient();
                }

                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxINN.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
