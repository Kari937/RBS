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
    public partial class FormUslugi1S : Form
    {
        public FormUslugi1S()
        {
            InitializeComponent();
            comboBoxTip_uslugi.SelectedIndex = 0;
            Show1();
        }

        void Show1()
        {
            listViewProdazha.Items.Clear();
            listViewNastroyka.Items.Clear();
            listViewObsluzhivaniye.Items.Clear();

            foreach (Table_1 table_1 in Program.rbs.Table_1)
            {
                if (table_1.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        table_1.Id.ToString(),table_1.NazvaniyeProgrammy, table_1.Price.ToString()
                    });

                    item.Tag = table_1;
                    listViewProdazha.Items.Add(item);
                }

                else if (table_1.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         table_1.Id.ToString(),table_1.TipZadachi
                    });

                    item.Tag = table_1;
                    listViewNastroyka.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         table_1.Id.ToString(),table_1.TipObsluzhivaniya, table_1.Price.ToString()
                    });

                    item.Tag = table_1;
                    listViewObsluzhivaniye.Items.Add(item);

                }
                listViewProdazha.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewNastroyka.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewObsluzhivaniye.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormUslugi1S_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTip_uslugi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Продажа (индекс 0)
            if (comboBoxTip_uslugi.SelectedIndex == 0)
            {
                //Видимые элементы
                listViewProdazha.Visible = true;
                labelNazvaniyeProgrammy.Visible = true;
                comboBoxNazvaniyeProgrammy.Visible = true;
                labelPrice.Visible = true;
                textBoxPrice.Visible = true;

                //Скрытые элементы
                labelTipZadachi.Visible = false;
                comboBoxTipZadachi.Visible = false;
                labelTipObsluzhivaniya.Visible = false;
                comboBoxTipObsluzhivaniya.Visible = false;
                listViewNastroyka.Visible = false;
                listViewObsluzhivaniye.Visible = false;

               


            }
            //Настройка
            else if (comboBoxTip_uslugi.SelectedIndex == 1)
            {
                listViewNastroyka.Visible = true;
                labelTipZadachi.Visible = true;
                comboBoxTipZadachi.Visible = true;

                listViewProdazha.Visible = false;
                listViewObsluzhivaniye.Visible = false;
                labelNazvaniyeProgrammy.Visible = false;
                comboBoxNazvaniyeProgrammy.Visible = false;
                labelTipObsluzhivaniya.Visible = false;
                comboBoxTipObsluzhivaniya.Visible = false;
                labelPrice.Visible = false;
                textBoxPrice.Visible = false;


            }
            //Обслуживание 1С
            else if (comboBoxTip_uslugi.SelectedIndex == 2)
            {
                listViewObsluzhivaniye.Visible = true;
                labelTipObsluzhivaniya.Visible = true;
                comboBoxTipObsluzhivaniya.Visible = true;
                labelPrice.Visible = true;
                textBoxPrice.Visible = true;


                labelNazvaniyeProgrammy.Visible = false;
                comboBoxNazvaniyeProgrammy.Visible = false;
                labelTipZadachi.Visible = false;
                comboBoxTipZadachi.Visible = false;
                listViewProdazha.Visible = false;
                listViewNastroyka.Visible = false;

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Table_1 table_1 = new Table_1();




            

            if (comboBoxTip_uslugi.SelectedIndex == 0)
            {
                table_1.Type = 0;
                table_1.NazvaniyeProgrammy = comboBoxNazvaniyeProgrammy.Text;
                table_1.Price = Convert.ToInt64(textBoxPrice.Text);

            }
            else if (comboBoxTip_uslugi.SelectedIndex == 1)
            {
                table_1.Type = 1;
                table_1.TipZadachi = comboBoxTipZadachi.Text;

            }
            else
            {
                table_1.Type = 2;
                table_1.TipObsluzhivaniya = comboBoxTipObsluzhivaniya.Text;
                table_1.Price = Convert.ToInt64(textBoxPrice.Text);
            }
            Program.rbs.Table_1.Add(table_1);
            Program.rbs.SaveChanges();
            Show1();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxTip_uslugi.SelectedIndex == 0)
            {
                if (listViewProdazha.SelectedItems.Count == 1)
                {
                    try
                    {
                        Table_1 table_1 = listViewProdazha.SelectedItems[0].Tag as Table_1;

                        table_1.NazvaniyeProgrammy = comboBoxNazvaniyeProgrammy.Text;
                        table_1.Price = Convert.ToInt64(textBoxPrice.Text);

                        if (comboBoxNazvaniyeProgrammy.Text != "")
                        {
                            table_1.NazvaniyeProgrammy = comboBoxNazvaniyeProgrammy.Text;
                        }
                        else table_1.NazvaniyeProgrammy = null;
                        if (comboBoxNazvaniyeProgrammy.Text != "")
                        {
                            table_1.Price = Convert.ToInt64(textBoxPrice.Text);
                        }
                        else table_1.Price = null;


                        Program.rbs.SaveChanges();
                        Show1();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

            else if (comboBoxTip_uslugi.SelectedIndex == 1)
            {
                if (listViewNastroyka.SelectedItems.Count == 1)
                {
                    try
                    {
                        Table_1 table_1 = listViewNastroyka.SelectedItems[0].Tag as Table_1;

                        table_1.TipZadachi = comboBoxTipZadachi.Text;

                        if (comboBoxTipZadachi.Text != "")
                        {
                            table_1.TipZadachi = comboBoxTipZadachi.Text;
                        }
                        else table_1.TipZadachi = null;


                        Program.rbs.SaveChanges();
                        Show1();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                if (listViewObsluzhivaniye.SelectedItems.Count == 1)
                {
                    try
                    {
                        Table_1 table_1 = listViewObsluzhivaniye.SelectedItems[0].Tag as Table_1;

                        table_1.TipObsluzhivaniya = comboBoxTipObsluzhivaniya.Text;
                        table_1.Price = Convert.ToInt64(textBoxPrice.Text);

                        if (comboBoxTipObsluzhivaniya.Text != "")
                        {
                            table_1.TipObsluzhivaniya = comboBoxTipObsluzhivaniya.Text;
                        }
                        else table_1.TipObsluzhivaniya = null;
                        if (comboBoxTipObsluzhivaniya.Text != "")
                        {
                            table_1.Price = Convert.ToInt64(textBoxPrice.Text);
                        }
                        else table_1.Price = null;
                        

                        Program.rbs.SaveChanges();
                        Show1();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    

                    
                
           
        
    
        private void listViewNastroyka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNastroyka.SelectedItems.Count == 1)
            {
                Table_1 table_1 = listViewNastroyka.SelectedItems[0].Tag as Table_1;

               comboBoxTipZadachi.Text = table_1.TipZadachi;
                

            }
            else
            {
                comboBoxTipZadachi.Text = "";
            

            }
        }

        private void listViewProdazha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProdazha.SelectedItems.Count == 1)
            {
                Table_1 table_1 = listViewProdazha.SelectedItems[0].Tag as Table_1;

                comboBoxNazvaniyeProgrammy.Text = table_1.NazvaniyeProgrammy;
                textBoxPrice.Text = table_1.Price.ToString();
                
            }
            else
            {
                comboBoxNazvaniyeProgrammy.Text = "";
                textBoxPrice.Text = "";
             
            }
        }

        private void listViewObsluzhivaniye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewObsluzhivaniye.SelectedItems.Count == 1)
            {
                Table_1 table_1 = listViewObsluzhivaniye.SelectedItems[0].Tag as Table_1;

               comboBoxTipObsluzhivaniya.Text = table_1.TipObsluzhivaniya;
                textBoxPrice.Text = table_1.Price.ToString();

            }
            else
            {
                comboBoxTipObsluzhivaniya.Text = "";
                textBoxPrice.Text = "";

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTip_uslugi.SelectedIndex == 0)
                {
                    if (listViewProdazha.SelectedItems.Count == 1)
                    {
                        Table_1 table_1 = listViewProdazha.SelectedItems[0].Tag as Table_1;
                        Program.rbs.Table_1.Remove(table_1);
                        Program.rbs.SaveChanges();
                        Show1();
                    }

                    comboBoxNazvaniyeProgrammy.Text = "";
                    textBoxPrice.Text = "";
                    
                }

                else if (comboBoxTip_uslugi.SelectedIndex == 1)
                {
                    if (listViewNastroyka.SelectedItems.Count == 1)
                    {
                        Table_1 table_1 = listViewNastroyka.SelectedItems[0].Tag as Table_1;
                        Program.rbs.Table_1.Remove(table_1);
                        Program.rbs.SaveChanges();
                        Show1();
                    }

                    comboBoxTipZadachi.Text = "";
                   
                }

                else
                {
                    if (listViewObsluzhivaniye.SelectedItems.Count == 1)
                    {
                        Table_1 table_1 = listViewObsluzhivaniye.SelectedItems[0].Tag as Table_1;
                        Program.rbs.Table_1.Remove(table_1);
                        Program.rbs.SaveChanges();
                        Show1();
                    }

                    comboBoxTipObsluzhivaniya.Text = "";
                    textBoxPrice.Text = "";

                }

            }

            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTipZadachi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } }



