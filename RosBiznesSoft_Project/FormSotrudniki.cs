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
    public partial class FormSotrudniki : Form
    {
        void ShowSotrudniki()
        {
            listViewSotrudniki.Items.Clear();
            foreach (SotrudnikiSet sotrudnikiSet in Program.rbs.SotrudnikiSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sotrudnikiSet.Id.ToString(), sotrudnikiSet.Name,
                    sotrudnikiSet.Dolzhnost, sotrudnikiSet.Dob,
                    sotrudnikiSet.Email
                });
                item.Tag = sotrudnikiSet;
                listViewSotrudniki.Items.Add(item);
            }
            listViewSotrudniki.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormSotrudniki()
        {
            InitializeComponent();
            ShowSotrudniki();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SotrudnikiSet sotrudnikiSet = new SotrudnikiSet();
            sotrudnikiSet.Name = textBoxNames.Text;
            sotrudnikiSet.Dolzhnost = textBoxDolzhnost.Text;
            sotrudnikiSet.Dob = textBoxDob.Text;
            sotrudnikiSet.Email = textBoxEmail.Text;
            Program.rbs.SotrudnikiSet.Add(sotrudnikiSet);
            Program.rbs.SaveChanges();
            ShowSotrudniki();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSotrudniki.SelectedItems.Count == 1)
            {
                SotrudnikiSet sotrudnikiSet = listViewSotrudniki.SelectedItems[0].Tag as SotrudnikiSet;
                sotrudnikiSet.Name = textBoxNames.Text;
                sotrudnikiSet.Dolzhnost = textBoxDolzhnost.Text;
                sotrudnikiSet.Dob = textBoxDob.Text;
                sotrudnikiSet.Email = textBoxEmail.Text;
                Program.rbs.SaveChanges();
                ShowSotrudniki();
            }
        }

        private void listViewSotrudniki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSotrudniki.SelectedItems.Count == 1)
            {
                SotrudnikiSet sotrudnikiSet = listViewSotrudniki.SelectedItems[0].Tag as SotrudnikiSet;
                textBoxNames.Text = sotrudnikiSet.Name;
                textBoxDolzhnost.Text = sotrudnikiSet.Dolzhnost;
                textBoxDob.Text = sotrudnikiSet.Dob;
                textBoxEmail.Text = sotrudnikiSet.Email;
            }
            else
            {
                textBoxNames.Text = "";
                textBoxDolzhnost.Text = "";
                textBoxDob.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSotrudniki.SelectedItems.Count == 1)
                {
                    SotrudnikiSet sotrudnikiSet = listViewSotrudniki.SelectedItems[0].Tag as SotrudnikiSet;
                    Program.rbs.SotrudnikiSet.Remove(sotrudnikiSet);
                    Program.rbs.SaveChanges();
                    ShowSotrudniki();
                }

                textBoxNames.Text = "";
                textBoxDolzhnost.Text = "";
                textBoxDob.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSotrudniki_Load(object sender, EventArgs e)
        {

        }
    }
}
