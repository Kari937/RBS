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
    public partial class Kompleksnaya : Form
    {
        void ShowKomp()
        {
            listViewKomp.Items.Clear();
            foreach (KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya in Program.rbs.KompleksnayaAvtomatizatsiya)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    kompleksnayaAvtomatizatsiya.Id.ToString(), kompleksnayaAvtomatizatsiya.leevel,
                    kompleksnayaAvtomatizatsiya.SrokRealizatsii, kompleksnayaAvtomatizatsiya.PO,
                    kompleksnayaAvtomatizatsiya.KolichestvoChelovek,kompleksnayaAvtomatizatsiya.Price.ToString()
                });
                item.Tag = kompleksnayaAvtomatizatsiya;
                listViewKomp.Items.Add(item);
            }
            listViewKomp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public Kompleksnaya()
        {
            InitializeComponent();
            ShowKomp();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya = new KompleksnayaAvtomatizatsiya();
            kompleksnayaAvtomatizatsiya.leevel = comboBoxLevel.Text;
            kompleksnayaAvtomatizatsiya.SrokRealizatsii = textBoxSrok.Text;
            kompleksnayaAvtomatizatsiya.PO = textBoxPO.Text;
            kompleksnayaAvtomatizatsiya.KolichestvoChelovek = textBoxMachtab.Text;
            kompleksnayaAvtomatizatsiya.Price = Convert.ToInt64(textBoxPrice.Text);
            Program.rbs.KompleksnayaAvtomatizatsiya.Add(kompleksnayaAvtomatizatsiya);
            Program.rbs.SaveChanges();
            ShowKomp();


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewKomp.SelectedItems.Count == 1)
            {
                KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya = listViewKomp.SelectedItems[0].Tag as KompleksnayaAvtomatizatsiya;
                kompleksnayaAvtomatizatsiya.leevel = comboBoxLevel.Text;
                kompleksnayaAvtomatizatsiya.SrokRealizatsii = textBoxSrok.Text;
                kompleksnayaAvtomatizatsiya.PO = textBoxPO.Text;
                kompleksnayaAvtomatizatsiya.KolichestvoChelovek = textBoxMachtab.Text;
                kompleksnayaAvtomatizatsiya.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.rbs.SaveChanges();
                ShowKomp();
            }
        }

        private void listViewKomp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKomp.SelectedItems.Count == 1)
            {
                KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya = listViewKomp.SelectedItems[0].Tag as KompleksnayaAvtomatizatsiya;
                comboBoxLevel.Text = kompleksnayaAvtomatizatsiya.leevel;
                textBoxSrok.Text = kompleksnayaAvtomatizatsiya.SrokRealizatsii;
                textBoxPO.Text = kompleksnayaAvtomatizatsiya.PO;
               textBoxMachtab.Text = kompleksnayaAvtomatizatsiya.KolichestvoChelovek;
                textBoxPrice.Text = kompleksnayaAvtomatizatsiya.Price.ToString();

            }
            else
            {
                comboBoxLevel.Text = "";
                textBoxSrok.Text = "";
                textBoxPO.Text = "";
                textBoxMachtab.Text = "";
                textBoxPrice.Text = "";

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewKomp.SelectedItems.Count == 1)
                {
                    KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya = listViewKomp.SelectedItems[0].Tag as KompleksnayaAvtomatizatsiya;
                    Program.rbs.KompleksnayaAvtomatizatsiya.Remove(kompleksnayaAvtomatizatsiya);
                    Program.rbs.SaveChanges();
                    ShowKomp();
                }
                comboBoxLevel.Text = "";
                textBoxSrok.Text = "";
                textBoxPO.Text = "";
                textBoxMachtab.Text = "";
                textBoxPrice.Text = "";


            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kompleksnaya_Load(object sender, EventArgs e)
        {

        }
    }
    }

