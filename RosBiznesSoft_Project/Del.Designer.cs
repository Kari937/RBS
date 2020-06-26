namespace RosBiznesSoft_Project
{
    partial class Del
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.comboBoxSis = new System.Windows.Forms.ComboBox();
            this.comboBoxBez = new System.Windows.Forms.ComboBox();
            this.comboBoxProect = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSis = new System.Windows.Forms.Label();
            this.labelBez = new System.Windows.Forms.Label();
            this.labelProect = new System.Windows.Forms.Label();
            this.listViewSis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBez = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProect = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonDel.Location = new System.Drawing.Point(433, 185);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonEdit.Location = new System.Drawing.Point(342, 185);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(251, 185);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Система и офис",
            "Безопасность и защита",
            "Проектирование и дизайн"});
            this.comboBoxTip.Location = new System.Drawing.Point(12, 79);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(218, 29);
            this.comboBoxTip.TabIndex = 15;
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxSistem_SelectedIndexChanged);
            // 
            // comboBoxSis
            // 
            this.comboBoxSis.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxSis.FormattingEnabled = true;
            this.comboBoxSis.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Office",
            "Камин",
            "Инфокрафт",
            "Битрикс24",
            "AmoCRM",
            "Мегаплан",
            "МойСклад "});
            this.comboBoxSis.Location = new System.Drawing.Point(12, 135);
            this.comboBoxSis.Name = "comboBoxSis";
            this.comboBoxSis.Size = new System.Drawing.Size(218, 29);
            this.comboBoxSis.TabIndex = 16;
            // 
            // comboBoxBez
            // 
            this.comboBoxBez.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxBez.FormattingEnabled = true;
            this.comboBoxBez.Items.AddRange(new object[] {
            "Microsoft",
            "Kaspersky",
            "ESET",
            "McAfee",
            "Panda",
            "Trend Micro",
            "Kerio",
            "Dr.Web"});
            this.comboBoxBez.Location = new System.Drawing.Point(12, 135);
            this.comboBoxBez.Name = "comboBoxBez";
            this.comboBoxBez.Size = new System.Drawing.Size(218, 29);
            this.comboBoxBez.TabIndex = 17;
            this.comboBoxBez.Visible = false;
            // 
            // comboBoxProect
            // 
            this.comboBoxProect.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxProect.FormattingEnabled = true;
            this.comboBoxProect.Items.AddRange(new object[] {
            "Adobe",
            "Corel",
            "BCAD",
            "Autodesk",
            "SAP",
            "ACD",
            "Fine Print",
            "Avocode",
            "NiceLabel"});
            this.comboBoxProect.Location = new System.Drawing.Point(12, 135);
            this.comboBoxProect.Name = "comboBoxProect";
            this.comboBoxProect.Size = new System.Drawing.Size(218, 29);
            this.comboBoxProect.TabIndex = 18;
            this.comboBoxProect.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Black;
            this.labelType.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelType.Location = new System.Drawing.Point(12, 55);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 21);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Тип";
            // 
            // labelSis
            // 
            this.labelSis.AutoSize = true;
            this.labelSis.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelSis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSis.Location = new System.Drawing.Point(12, 111);
            this.labelSis.Name = "labelSis";
            this.labelSis.Size = new System.Drawing.Size(105, 21);
            this.labelSis.TabIndex = 20;
            this.labelSis.Text = "Система и офис";
            // 
            // labelBez
            // 
            this.labelBez.AutoSize = true;
            this.labelBez.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelBez.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBez.Location = new System.Drawing.Point(12, 111);
            this.labelBez.Name = "labelBez";
            this.labelBez.Size = new System.Drawing.Size(148, 21);
            this.labelBez.TabIndex = 21;
            this.labelBez.Text = "Безопасность и защита";
            this.labelBez.Visible = false;
            // 
            // labelProect
            // 
            this.labelProect.AutoSize = true;
            this.labelProect.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelProect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProect.Location = new System.Drawing.Point(12, 111);
            this.labelProect.Name = "labelProect";
            this.labelProect.Size = new System.Drawing.Size(163, 21);
            this.labelProect.TabIndex = 22;
            this.labelProect.Text = "Проектирование и дизайн";
            this.labelProect.Visible = false;
            // 
            // listViewSis
            // 
            this.listViewSis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSis.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewSis.FullRowSelect = true;
            this.listViewSis.GridLines = true;
            this.listViewSis.HideSelection = false;
            this.listViewSis.Location = new System.Drawing.Point(261, 55);
            this.listViewSis.MultiSelect = false;
            this.listViewSis.Name = "listViewSis";
            this.listViewSis.Size = new System.Drawing.Size(248, 124);
            this.listViewSis.TabIndex = 23;
            this.listViewSis.UseCompatibleStateImageBehavior = false;
            this.listViewSis.View = System.Windows.Forms.View.Details;
            this.listViewSis.SelectedIndexChanged += new System.EventHandler(this.listViewSis_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Система и офис";
            this.columnHeader2.Width = 178;
            // 
            // listViewBez
            // 
            this.listViewBez.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBez.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewBez.FullRowSelect = true;
            this.listViewBez.GridLines = true;
            this.listViewBez.HideSelection = false;
            this.listViewBez.Location = new System.Drawing.Point(251, 55);
            this.listViewBez.MultiSelect = false;
            this.listViewBez.Name = "listViewBez";
            this.listViewBez.Size = new System.Drawing.Size(267, 124);
            this.listViewBez.TabIndex = 24;
            this.listViewBez.UseCompatibleStateImageBehavior = false;
            this.listViewBez.View = System.Windows.Forms.View.Details;
            this.listViewBez.Visible = false;
            this.listViewBez.SelectedIndexChanged += new System.EventHandler(this.listViewBez_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Безопасность и защита";
            this.columnHeader4.Width = 176;
            // 
            // listViewProect
            // 
            this.listViewProect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewProect.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewProect.FullRowSelect = true;
            this.listViewProect.GridLines = true;
            this.listViewProect.HideSelection = false;
            this.listViewProect.Location = new System.Drawing.Point(251, 55);
            this.listViewProect.MultiSelect = false;
            this.listViewProect.Name = "listViewProect";
            this.listViewProect.Size = new System.Drawing.Size(267, 124);
            this.listViewProect.TabIndex = 25;
            this.listViewProect.UseCompatibleStateImageBehavior = false;
            this.listViewProect.View = System.Windows.Forms.View.Details;
            this.listViewProect.Visible = false;
            this.listViewProect.SelectedIndexChanged += new System.EventHandler(this.listViewProect_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Проектирование и дизайн";
            this.columnHeader6.Width = 170;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProect);
            this.Controls.Add(this.listViewBez);
            this.Controls.Add(this.listViewSis);
            this.Controls.Add(this.labelProect);
            this.Controls.Add(this.labelBez);
            this.Controls.Add(this.labelSis);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxProect);
            this.Controls.Add(this.comboBoxBez);
            this.Controls.Add(this.comboBoxSis);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Del";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Деловое ПО";
            this.Load += new System.EventHandler(this.Del_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.ComboBox comboBoxSis;
        private System.Windows.Forms.ComboBox comboBoxBez;
        private System.Windows.Forms.ComboBox comboBoxProect;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSis;
        private System.Windows.Forms.Label labelBez;
        private System.Windows.Forms.Label labelProect;
        private System.Windows.Forms.ListView listViewSis;
        private System.Windows.Forms.ListView listViewBez;
        private System.Windows.Forms.ListView listViewProect;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}