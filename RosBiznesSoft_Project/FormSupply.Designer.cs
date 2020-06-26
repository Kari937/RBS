namespace RosBiznesSoft_Project
{
    partial class FormSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupply));
            this.labelClients = new System.Windows.Forms.Label();
            this.labelUslugi1c = new System.Windows.Forms.Label();
            this.labelDelovoePO = new System.Windows.Forms.Label();
            this.labelKA = new System.Windows.Forms.Label();
            this.listViewSuppy = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxUslugi1c = new System.Windows.Forms.ComboBox();
            this.comboBoxDelovoePO = new System.Windows.Forms.ComboBox();
            this.comboBoxKA = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClients.Location = new System.Drawing.Point(3, 65);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(62, 21);
            this.labelClients.TabIndex = 1;
            this.labelClients.Text = "Клиенты";
            // 
            // labelUslugi1c
            // 
            this.labelUslugi1c.AutoSize = true;
            this.labelUslugi1c.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelUslugi1c.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUslugi1c.Location = new System.Drawing.Point(7, 121);
            this.labelUslugi1c.Name = "labelUslugi1c";
            this.labelUslugi1c.Size = new System.Drawing.Size(63, 21);
            this.labelUslugi1c.TabIndex = 2;
            this.labelUslugi1c.Text = "Услуги 1с";
            this.labelUslugi1c.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDelovoePO
            // 
            this.labelDelovoePO.AutoSize = true;
            this.labelDelovoePO.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelDelovoePO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDelovoePO.Location = new System.Drawing.Point(7, 177);
            this.labelDelovoePO.Name = "labelDelovoePO";
            this.labelDelovoePO.Size = new System.Drawing.Size(82, 21);
            this.labelDelovoePO.TabIndex = 3;
            this.labelDelovoePO.Text = "Деловое ПО";
            // 
            // labelKA
            // 
            this.labelKA.AutoSize = true;
            this.labelKA.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelKA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKA.Location = new System.Drawing.Point(7, 233);
            this.labelKA.Name = "labelKA";
            this.labelKA.Size = new System.Drawing.Size(183, 21);
            this.labelKA.TabIndex = 4;
            this.labelKA.Text = "Комплексная автоматизация";
            // 
            // listViewSuppy
            // 
            this.listViewSuppy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSuppy.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewSuppy.FullRowSelect = true;
            this.listViewSuppy.GridLines = true;
            this.listViewSuppy.HideSelection = false;
            this.listViewSuppy.Location = new System.Drawing.Point(248, 63);
            this.listViewSuppy.MultiSelect = false;
            this.listViewSuppy.Name = "listViewSuppy";
            this.listViewSuppy.Size = new System.Drawing.Size(714, 223);
            this.listViewSuppy.TabIndex = 5;
            this.listViewSuppy.UseCompatibleStateImageBehavior = false;
            this.listViewSuppy.View = System.Windows.Forms.View.Details;
            this.listViewSuppy.SelectedIndexChanged += new System.EventHandler(this.listViewSuppy_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id клиента";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Название";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id услуги 1С";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Услуга 1С";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Id ДеловогоПО";
            this.columnHeader10.Width = 99;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Деловое ПО";
            this.columnHeader11.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id комплексной автоматизации";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Комплексная автоматизация";
            this.columnHeader2.Width = 132;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(7, 89);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(239, 29);
            this.comboBoxClients.TabIndex = 7;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // comboBoxUslugi1c
            // 
            this.comboBoxUslugi1c.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxUslugi1c.FormattingEnabled = true;
            this.comboBoxUslugi1c.Location = new System.Drawing.Point(8, 145);
            this.comboBoxUslugi1c.Name = "comboBoxUslugi1c";
            this.comboBoxUslugi1c.Size = new System.Drawing.Size(239, 29);
            this.comboBoxUslugi1c.TabIndex = 8;
            // 
            // comboBoxDelovoePO
            // 
            this.comboBoxDelovoePO.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxDelovoePO.FormattingEnabled = true;
            this.comboBoxDelovoePO.Location = new System.Drawing.Point(8, 201);
            this.comboBoxDelovoePO.Name = "comboBoxDelovoePO";
            this.comboBoxDelovoePO.Size = new System.Drawing.Size(239, 29);
            this.comboBoxDelovoePO.TabIndex = 9;
            // 
            // comboBoxKA
            // 
            this.comboBoxKA.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxKA.FormattingEnabled = true;
            this.comboBoxKA.Location = new System.Drawing.Point(8, 257);
            this.comboBoxKA.Name = "comboBoxKA";
            this.comboBoxKA.Size = new System.Drawing.Size(239, 29);
            this.comboBoxKA.TabIndex = 10;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonDel.Location = new System.Drawing.Point(673, 292);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonEdit.Location = new System.Drawing.Point(582, 292);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(491, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxKA);
            this.Controls.Add(this.comboBoxDelovoePO);
            this.Controls.Add(this.comboBoxUslugi1c);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.listViewSuppy);
            this.Controls.Add(this.labelKA);
            this.Controls.Add(this.labelDelovoePO);
            this.Controls.Add(this.labelUslugi1c);
            this.Controls.Add(this.labelClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.FormSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelUslugi1c;
        private System.Windows.Forms.Label labelDelovoePO;
        private System.Windows.Forms.Label labelKA;
        private System.Windows.Forms.ListView listViewSuppy;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxUslugi1c;
        private System.Windows.Forms.ComboBox comboBoxDelovoePO;
        private System.Windows.Forms.ComboBox comboBoxKA;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}