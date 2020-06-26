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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();

            ShowClient();
            ShowUslugi1c();
            DelovoePO();
            showKompleksnayaAvtomatizatsiya();
            ShowSupplySet();

        }

        void ShowClient()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.rbs.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ". ", clientsSet.Name, clientsSet.Address, clientsSet.INN, clientsSet.Phone };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowUslugi1c()
        {
            comboBoxUslugi1c.Items.Clear();
            foreach (Table_1 table_1 in Program.rbs.Table_1)
            {
                string[] item = { table_1.Id.ToString() + ". ", table_1.NazvaniyeProgrammy, table_1.TipZadachi, table_1.TipObsluzhivaniya, table_1.Price.ToString() };
                comboBoxUslugi1c.Items.Add(string.Join(" ", item));
            }
        }
        void DelovoePO()
        {
            comboBoxDelovoePO.Items.Clear();
            foreach (DelovoePO delovoePO in Program.rbs.DelovoePO)
            {
                string[] item = { delovoePO.Id.ToString() + ". ", delovoePO.Sistem, delovoePO.Bezopasn, delovoePO.Project };
                comboBoxDelovoePO.Items.Add(string.Join(" ", item));
            }
        }
        void showKompleksnayaAvtomatizatsiya()
        {
            comboBoxKA.Items.Clear();
            foreach (KompleksnayaAvtomatizatsiya kompleksnayaAvtomatizatsiya in Program.rbs.KompleksnayaAvtomatizatsiya)
            {
                string[] item = { kompleksnayaAvtomatizatsiya.Id.ToString() + ". ", kompleksnayaAvtomatizatsiya.leevel, kompleksnayaAvtomatizatsiya.SrokRealizatsii, kompleksnayaAvtomatizatsiya.Price.ToString(), kompleksnayaAvtomatizatsiya.PO, kompleksnayaAvtomatizatsiya.KolichestvoChelovek };
                comboBoxKA.Items.Add(string.Join(" ", item));
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem!= null && comboBoxUslugi1c.SelectedItem!= null && comboBoxDelovoePO.SelectedItem!= null && comboBoxKA.SelectedItem != null)
            {
                SupplySet supply = new SupplySet();



                supply.IdClient= Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdTable_1 = Convert.ToInt32(comboBoxUslugi1c.SelectedItem.ToString().Split('.')[0]);
                supply.IdDelovoePO = Convert.ToInt32(comboBoxDelovoePO.SelectedItem.ToString().Split('.')[0]);
                supply.IdKompleksnayaAvtomatizasia = Convert.ToInt32(comboBoxKA.SelectedItem.ToString().Split('.')[0]);
        
                Program.rbs.SupplySet.Add(supply);
                Program.rbs.SaveChanges();
                ShowSupplySet();

            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowSupplySet()
        {
            listViewSuppy.Items.Clear();
            foreach (SupplySet supply in Program.rbs.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {


supply.IdClient.ToString(),
supply.ClientsSet.Name+" "+ supply.ClientsSet.Address+ " "+ supply.ClientsSet.INN+" "+supply.ClientsSet.Phone,

supply.IdTable_1.ToString(),
supply.Table_1.NazvaniyeProgrammy+" "+supply.Table_1.TipZadachi+" "+supply.Table_1.TipObsluzhivaniya,

supply.IdDelovoePO.ToString(),
supply.DelovoePO.Sistem + " " +supply.DelovoePO.Bezopasn+ " "+ supply.DelovoePO.Project,

supply.IdKompleksnayaAvtomatizasia.ToString(),
supply.KompleksnayaAvtomatizatsiya.leevel+" "+supply.KompleksnayaAvtomatizatsiya.SrokRealizatsii +"дней"+supply.KompleksnayaAvtomatizatsiya.PO+"ПО:"+supply.KompleksnayaAvtomatizatsiya.KolichestvoChelovek+"количество человек"+supply.KompleksnayaAvtomatizatsiya.Price+"цена:",
                });
                ;
                item.Tag = supply;
                listViewSuppy.Items.Add(item);

            }
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSuppy.SelectedItems.Count == 1)
            {
                try
                {
                    if (comboBoxClients.Text == "" || comboBoxUslugi1c.Text == "" || comboBoxDelovoePO.Text == "" || comboBoxKA.Text == "")
                        
                    {
                        throw new Exception("Заполните все поля!");
                    }

                    SupplySet supply = listViewSuppy.SelectedItems[0].Tag as SupplySet;
                    supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    supply.IdTable_1 = Convert.ToInt32(comboBoxUslugi1c.SelectedItem.ToString().Split('.')[0]);
                    supply.IdDelovoePO = Convert.ToInt32(comboBoxDelovoePO.SelectedItem.ToString().Split('.')[0]);
                    supply.IdKompleksnayaAvtomatizasia = Convert.ToInt32(comboBoxKA.SelectedItem.ToString().Split('.')[0]);

                    
                    Program.rbs.SaveChanges();
                    ShowSupplySet();
                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void listViewSuppy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSuppy.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSuppy.SelectedItems[0].Tag as SupplySet;
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxUslugi1c.SelectedIndex = comboBoxUslugi1c.FindString(supply.IdTable_1.ToString());
                comboBoxDelovoePO.SelectedIndex = comboBoxDelovoePO.FindString(supply.IdDelovoePO.ToString());
                comboBoxKA.SelectedIndex = comboBoxKA.FindString(supply.IdKompleksnayaAvtomatizasia.ToString());

            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxUslugi1c.SelectedItem = null;
                comboBoxDelovoePO.SelectedItem = null;
                comboBoxKA.SelectedItem = null;


            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSuppy.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSuppy.SelectedItems[0].Tag as SupplySet;
                    Program.rbs.SupplySet.Remove(supply);
                    Program.rbs.SaveChanges();
                    ShowSupplySet();
                }

                comboBoxUslugi1c.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxDelovoePO.SelectedItem = null;
                comboBoxKA.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}