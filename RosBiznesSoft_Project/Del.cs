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
    public partial class Del : Form
    {
        public Del()
        {
            InitializeComponent();
            comboBoxTip.SelectedIndex = 0;
            ShowDel();
        }
        void ShowDel()
        {
            listViewSis.Items.Clear();
            listViewBez.Items.Clear();
            listViewProect.Items.Clear();

            foreach (DelovoePO delovoePO in Program.rbs.DelovoePO)
            {
                if (delovoePO.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        delovoePO.Id.ToString(),delovoePO.Sistem
                    });

                    item.Tag = delovoePO;
                    listViewSis.Items.Add(item);
                }

                else if (delovoePO.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         delovoePO.Id.ToString(),delovoePO.Bezopasn
                    });

                    item.Tag = delovoePO;
                    listViewBez.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         delovoePO.Id.ToString(),delovoePO.Project
                    });

                    item.Tag = delovoePO;
                    listViewProect.Items.Add(item);

                }
                listViewSis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewBez.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewProect.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
            private void comboBoxSistem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Система и офис (индекс 0)
            if (comboBoxTip.SelectedIndex == 0)
            {
                //Видимые элементы
                listViewSis.Visible = true;
                labelSis.Visible = true;
                comboBoxSis.Visible = true;


                //Скрытые элементы
                labelBez.Visible = false;
                comboBoxBez.Visible = false;
                labelProect.Visible = false;
                comboBoxProect.Visible = false;
                listViewBez.Visible = false;
                listViewProect.Visible = false;

              


            }
            //Безопасность и защита
            else if (comboBoxTip.SelectedIndex == 1)
            {
                listViewBez.Visible = true;
                labelBez.Visible = true;
                comboBoxBez.Visible = true;

                listViewSis.Visible = false;
                listViewProect.Visible = false;
                labelSis.Visible = false;
                comboBoxProect.Visible = false;
                labelProect.Visible = false;
                comboBoxProect.Visible = false;
                comboBoxSis.Visible = false;



            }
            //Проектирование и дизаин
            else if (comboBoxTip.SelectedIndex == 2)
            {
                listViewProect.Visible = true;
                labelProect.Visible = true;
                comboBoxProect.Visible = true;



                labelSis.Visible = false;
                comboBoxSis.Visible = false;
                labelBez.Visible = false;
                comboBoxBez.Visible = false;
                listViewSis.Visible = false;
                listViewBez.Visible = false;
              

            }
        }

        private void Del_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DelovoePO delovoePO = new DelovoePO();




            

            if (comboBoxTip.SelectedIndex == 0)
            {
                delovoePO.Type = 0;
                delovoePO.Sistem = comboBoxSis.Text;

            }
            else if (comboBoxTip.SelectedIndex == 1)
            {
                delovoePO.Type = 1;
                delovoePO.Bezopasn = comboBoxBez.Text;

            }
            else
            {
                delovoePO.Type = 2;
                delovoePO.Project = comboBoxProect.Text;
            }
            Program.rbs.DelovoePO.Add(delovoePO);
            Program.rbs.SaveChanges();
            ShowDel();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxTip.SelectedIndex == 0)
            {
                if (listViewSis.SelectedItems.Count == 1)
                {
                    try
                    {
                        DelovoePO delovoePO = listViewSis.SelectedItems[0].Tag as DelovoePO;

                        delovoePO.Sistem = comboBoxSis.Text;
                   

                        if (comboBoxSis.Text != "")
                        {
                            delovoePO.Sistem = comboBoxSis.Text;
                        }
                        else delovoePO.Sistem = null;
                        


                        Program.rbs.SaveChanges();
                        ShowDel();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

            else if (comboBoxTip.SelectedIndex == 1)
            {
                if (listViewBez.SelectedItems.Count == 1)
                {
                    try
                    {
                        DelovoePO delovoePO = listViewBez.SelectedItems[0].Tag as DelovoePO;

                        delovoePO.Bezopasn = comboBoxBez.Text;

                        if (comboBoxBez.Text != "")
                        {
                            delovoePO.Bezopasn = comboBoxBez.Text;
                        }
                        else delovoePO.Bezopasn = null;


                        Program.rbs.SaveChanges();
                        ShowDel();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                if (listViewProect.SelectedItems.Count == 1)
                {
                    try
                    {
                        DelovoePO delovoePO = listViewProect.SelectedItems[0].Tag as DelovoePO;

                        delovoePO.Project = comboBoxProect.Text;
                      

                        if (comboBoxProect.Text != "")
                        {
                            delovoePO.Project = comboBoxProect.Text;
                        }
                        else delovoePO.Project = null;
                        


                        Program.rbs.SaveChanges();
                        ShowDel();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void listViewProect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProect.SelectedItems.Count == 1)
            {
                DelovoePO delovoePO = listViewProect.SelectedItems[0].Tag as DelovoePO;

                comboBoxProect.Text = delovoePO.Sistem;


            }
            else
            {
                comboBoxProect.Text = "";


            }
        }

        private void listViewSis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSis.SelectedItems.Count == 1)
            {
                DelovoePO delovoePO = listViewSis.SelectedItems[0].Tag as DelovoePO;

                comboBoxSis.Text = delovoePO.Sistem;
            

            }
            else
            {
                comboBoxSis.Text = "";
             

            }
        }

        private void listViewBez_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBez.SelectedItems.Count == 1)
            {
                DelovoePO delovoePO = listViewBez.SelectedItems[0].Tag as DelovoePO;

                comboBoxBez.Text = delovoePO.Bezopasn;


            }
            else
            {
                comboBoxBez.Text = "";


            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTip.SelectedIndex == 0)
                {
                    if (listViewSis.SelectedItems.Count == 1)
                    {
                        DelovoePO delovoePO = listViewSis.SelectedItems[0].Tag as DelovoePO;
                        Program.rbs.DelovoePO.Remove(delovoePO);
                        Program.rbs.SaveChanges();
                        ShowDel();
                    }

                    comboBoxSis.Text = "";
                  

                }

                else if (comboBoxTip.SelectedIndex == 1)
                {
                    if (listViewBez.SelectedItems.Count == 1)
                    {
                        DelovoePO delovoePO = listViewBez.SelectedItems[0].Tag as DelovoePO;
                        Program.rbs.DelovoePO.Remove(delovoePO);
                        Program.rbs.SaveChanges();
                        ShowDel();
                    }

                    comboBoxBez.Text = "";

                }

                else
                {
                    if (listViewProect.SelectedItems.Count == 1)
                    {
                        DelovoePO delovoePO = listViewProect.SelectedItems[0].Tag as DelovoePO;
                        Program.rbs.DelovoePO.Remove(delovoePO);
                        Program.rbs.SaveChanges();
                        ShowDel();
                    }

                    comboBoxProect.Text = "";
                   

                }

            }

            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    

