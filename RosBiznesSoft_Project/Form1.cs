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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Us.users.type == "spec") buttonOpenSotrudniki.Enabled = false;
            labelHello.Text = "Здравствуй, " + Us.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenSotrudniki_Click(object sender, EventArgs e)
        {
            Form formSotrudniki = new FormSotrudniki();
            formSotrudniki.Show();
        }

        private void buttonOpenUslugi1S_Click(object sender, EventArgs e)
        {
            Form formUslugi1S = new FormUslugi1S();
            formUslugi1S.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpenDelovoyePO_Click(object sender, EventArgs e)
        {
            Form formDelovoePO = new Del();
            formDelovoePO.Show();
        }

        private void buttonOpenKompleksnayaAvtomatizatsiya_Click(object sender, EventArgs e)
        {
            Form formKompleksnaya = new Kompleksnaya();
            formKompleksnaya.Show();
        }

        private void buttonPred_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
