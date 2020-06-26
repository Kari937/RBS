namespace RosBiznesSoft_Project
{
    partial class FormUslugi1S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUslugi1S));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewProdazha = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNastroyka = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewObsluzhivaniye = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxTip_uslugi = new System.Windows.Forms.ComboBox();
            this.comboBoxNazvaniyeProgrammy = new System.Windows.Forms.ComboBox();
            this.comboBoxTipZadachi = new System.Windows.Forms.ComboBox();
            this.comboBoxTipObsluzhivaniya = new System.Windows.Forms.ComboBox();
            this.labelTip_uslugi = new System.Windows.Forms.Label();
            this.labelNazvaniyeProgrammy = new System.Windows.Forms.Label();
            this.labelTipZadachi = new System.Windows.Forms.Label();
            this.labelTipObsluzhivaniya = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonDel.Location = new System.Drawing.Point(505, 289);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonEdit.Location = new System.Drawing.Point(414, 289);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(323, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewProdazha
            // 
            this.listViewProdazha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewProdazha.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewProdazha.FullRowSelect = true;
            this.listViewProdazha.GridLines = true;
            this.listViewProdazha.HideSelection = false;
            this.listViewProdazha.Location = new System.Drawing.Point(248, 70);
            this.listViewProdazha.MultiSelect = false;
            this.listViewProdazha.Name = "listViewProdazha";
            this.listViewProdazha.Size = new System.Drawing.Size(403, 212);
            this.listViewProdazha.TabIndex = 29;
            this.listViewProdazha.UseCompatibleStateImageBehavior = false;
            this.listViewProdazha.View = System.Windows.Forms.View.Details;
            this.listViewProdazha.SelectedIndexChanged += new System.EventHandler(this.listViewProdazha_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 24;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Название программы";
            this.columnHeader8.Width = 169;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена";
            this.columnHeader9.Width = 119;
            // 
            // listViewNastroyka
            // 
            this.listViewNastroyka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewNastroyka.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewNastroyka.FullRowSelect = true;
            this.listViewNastroyka.GridLines = true;
            this.listViewNastroyka.HideSelection = false;
            this.listViewNastroyka.Location = new System.Drawing.Point(248, 70);
            this.listViewNastroyka.MultiSelect = false;
            this.listViewNastroyka.Name = "listViewNastroyka";
            this.listViewNastroyka.Size = new System.Drawing.Size(403, 212);
            this.listViewNastroyka.TabIndex = 30;
            this.listViewNastroyka.UseCompatibleStateImageBehavior = false;
            this.listViewNastroyka.View = System.Windows.Forms.View.Details;
            this.listViewNastroyka.Visible = false;
            this.listViewNastroyka.SelectedIndexChanged += new System.EventHandler(this.listViewNastroyka_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип задачи";
            this.columnHeader2.Width = 282;
            // 
            // listViewObsluzhivaniye
            // 
            this.listViewObsluzhivaniye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader10});
            this.listViewObsluzhivaniye.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewObsluzhivaniye.FullRowSelect = true;
            this.listViewObsluzhivaniye.GridLines = true;
            this.listViewObsluzhivaniye.HideSelection = false;
            this.listViewObsluzhivaniye.Location = new System.Drawing.Point(248, 70);
            this.listViewObsluzhivaniye.MultiSelect = false;
            this.listViewObsluzhivaniye.Name = "listViewObsluzhivaniye";
            this.listViewObsluzhivaniye.Size = new System.Drawing.Size(403, 212);
            this.listViewObsluzhivaniye.TabIndex = 31;
            this.listViewObsluzhivaniye.UseCompatibleStateImageBehavior = false;
            this.listViewObsluzhivaniye.View = System.Windows.Forms.View.Details;
            this.listViewObsluzhivaniye.Visible = false;
            this.listViewObsluzhivaniye.SelectedIndexChanged += new System.EventHandler(this.listViewObsluzhivaniye_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 29;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип обслуживания";
            this.columnHeader6.Width = 269;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Цена";
            this.columnHeader10.Width = 99;
            // 
            // comboBoxTip_uslugi
            // 
            this.comboBoxTip_uslugi.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxTip_uslugi.FormattingEnabled = true;
            this.comboBoxTip_uslugi.Items.AddRange(new object[] {
            "Продажа 1С",
            "Настройка 1С",
            "Обслуживание 1С"});
            this.comboBoxTip_uslugi.Location = new System.Drawing.Point(10, 96);
            this.comboBoxTip_uslugi.Name = "comboBoxTip_uslugi";
            this.comboBoxTip_uslugi.Size = new System.Drawing.Size(232, 29);
            this.comboBoxTip_uslugi.TabIndex = 32;
            this.comboBoxTip_uslugi.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_uslugi_SelectedIndexChanged);
            // 
            // comboBoxNazvaniyeProgrammy
            // 
            this.comboBoxNazvaniyeProgrammy.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxNazvaniyeProgrammy.FormattingEnabled = true;
            this.comboBoxNazvaniyeProgrammy.Items.AddRange(new object[] {
            "1С: Бухгалтерия 8",
            "1С: Розница",
            "1С: Управление нашей фирмой 8",
            "1С: Управление торговлей 8",
            "1С-Камин\t",
            "1С: Зарплата и Управление Персоналом 8"});
            this.comboBoxNazvaniyeProgrammy.Location = new System.Drawing.Point(12, 156);
            this.comboBoxNazvaniyeProgrammy.Name = "comboBoxNazvaniyeProgrammy";
            this.comboBoxNazvaniyeProgrammy.Size = new System.Drawing.Size(232, 29);
            this.comboBoxNazvaniyeProgrammy.TabIndex = 33;
            // 
            // comboBoxTipZadachi
            // 
            this.comboBoxTipZadachi.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxTipZadachi.FormattingEnabled = true;
            this.comboBoxTipZadachi.Items.AddRange(new object[] {
            "Печатные формы и обработки",
            "Разграничение доступа",
            "Восстановление баз данных",
            "Интеграция"});
            this.comboBoxTipZadachi.Location = new System.Drawing.Point(12, 156);
            this.comboBoxTipZadachi.Name = "comboBoxTipZadachi";
            this.comboBoxTipZadachi.Size = new System.Drawing.Size(232, 29);
            this.comboBoxTipZadachi.TabIndex = 34;
            this.comboBoxTipZadachi.Visible = false;
            this.comboBoxTipZadachi.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipZadachi_SelectedIndexChanged);
            // 
            // comboBoxTipObsluzhivaniya
            // 
            this.comboBoxTipObsluzhivaniya.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxTipObsluzhivaniya.FormattingEnabled = true;
            this.comboBoxTipObsluzhivaniya.Items.AddRange(new object[] {
            "ИТС ТЕХНО",
            "ИТС ПРОФ"});
            this.comboBoxTipObsluzhivaniya.Location = new System.Drawing.Point(12, 156);
            this.comboBoxTipObsluzhivaniya.Name = "comboBoxTipObsluzhivaniya";
            this.comboBoxTipObsluzhivaniya.Size = new System.Drawing.Size(232, 29);
            this.comboBoxTipObsluzhivaniya.TabIndex = 35;
            this.comboBoxTipObsluzhivaniya.Visible = false;
            // 
            // labelTip_uslugi
            // 
            this.labelTip_uslugi.AutoSize = true;
            this.labelTip_uslugi.BackColor = System.Drawing.Color.Black;
            this.labelTip_uslugi.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelTip_uslugi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTip_uslugi.Location = new System.Drawing.Point(11, 70);
            this.labelTip_uslugi.Name = "labelTip_uslugi";
            this.labelTip_uslugi.Size = new System.Drawing.Size(69, 21);
            this.labelTip_uslugi.TabIndex = 36;
            this.labelTip_uslugi.Text = "Тип услуги";
            // 
            // labelNazvaniyeProgrammy
            // 
            this.labelNazvaniyeProgrammy.AutoSize = true;
            this.labelNazvaniyeProgrammy.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelNazvaniyeProgrammy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNazvaniyeProgrammy.Location = new System.Drawing.Point(11, 130);
            this.labelNazvaniyeProgrammy.Name = "labelNazvaniyeProgrammy";
            this.labelNazvaniyeProgrammy.Size = new System.Drawing.Size(137, 21);
            this.labelNazvaniyeProgrammy.TabIndex = 37;
            this.labelNazvaniyeProgrammy.Text = "Название программы";
            // 
            // labelTipZadachi
            // 
            this.labelTipZadachi.AutoSize = true;
            this.labelTipZadachi.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelTipZadachi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTipZadachi.Location = new System.Drawing.Point(12, 130);
            this.labelTipZadachi.Name = "labelTipZadachi";
            this.labelTipZadachi.Size = new System.Drawing.Size(74, 21);
            this.labelTipZadachi.TabIndex = 38;
            this.labelTipZadachi.Text = "Тип задачи";
            this.labelTipZadachi.Visible = false;
            // 
            // labelTipObsluzhivaniya
            // 
            this.labelTipObsluzhivaniya.AutoSize = true;
            this.labelTipObsluzhivaniya.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelTipObsluzhivaniya.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTipObsluzhivaniya.Location = new System.Drawing.Point(11, 130);
            this.labelTipObsluzhivaniya.Name = "labelTipObsluzhivaniya";
            this.labelTipObsluzhivaniya.Size = new System.Drawing.Size(117, 21);
            this.labelTipObsluzhivaniya.TabIndex = 39;
            this.labelTipObsluzhivaniya.Text = "Тип обслуживания";
            this.labelTipObsluzhivaniya.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxPrice.Location = new System.Drawing.Point(10, 216);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(232, 30);
            this.textBoxPrice.TabIndex = 40;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(11, 191);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 21);
            this.labelPrice.TabIndex = 41;
            this.labelPrice.Text = "Цена";
            this.labelPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FormUslugi1S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelTipObsluzhivaniya);
            this.Controls.Add(this.labelTipZadachi);
            this.Controls.Add(this.labelNazvaniyeProgrammy);
            this.Controls.Add(this.labelTip_uslugi);
            this.Controls.Add(this.comboBoxTipObsluzhivaniya);
            this.Controls.Add(this.comboBoxTipZadachi);
            this.Controls.Add(this.comboBoxNazvaniyeProgrammy);
            this.Controls.Add(this.comboBoxTip_uslugi);
            this.Controls.Add(this.listViewObsluzhivaniye);
            this.Controls.Add(this.listViewNastroyka);
            this.Controls.Add(this.listViewProdazha);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUslugi1S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги 1С";
            this.Load += new System.EventHandler(this.FormUslugi1S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewProdazha;
        private System.Windows.Forms.ListView listViewNastroyka;
        private System.Windows.Forms.ListView listViewObsluzhivaniye;
        private System.Windows.Forms.ComboBox comboBoxTip_uslugi;
        private System.Windows.Forms.ComboBox comboBoxNazvaniyeProgrammy;
        private System.Windows.Forms.ComboBox comboBoxTipZadachi;
        private System.Windows.Forms.ComboBox comboBoxTipObsluzhivaniya;
        private System.Windows.Forms.Label labelTip_uslugi;
        private System.Windows.Forms.Label labelNazvaniyeProgrammy;
        private System.Windows.Forms.Label labelTipZadachi;
        private System.Windows.Forms.Label labelTipObsluzhivaniya;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}