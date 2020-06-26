namespace RosBiznesSoft_Project
{
    partial class Kompleksnaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kompleksnaya));
            this.labelLevel = new System.Windows.Forms.Label();
            this.listViewKomp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSrok = new System.Windows.Forms.TextBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.labelSrok = new System.Windows.Forms.Label();
            this.textBoxPO = new System.Windows.Forms.TextBox();
            this.textBoxMachtab = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPO = new System.Windows.Forms.Label();
            this.labelMachtab = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLevel.Location = new System.Drawing.Point(21, 55);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(234, 21);
            this.labelLevel.TabIndex = 0;
            this.labelLevel.Text = "Уровень комплексной автоматизации";
            // 
            // listViewKomp
            // 
            this.listViewKomp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewKomp.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewKomp.FullRowSelect = true;
            this.listViewKomp.GridLines = true;
            this.listViewKomp.HideSelection = false;
            this.listViewKomp.Location = new System.Drawing.Point(239, 71);
            this.listViewKomp.MultiSelect = false;
            this.listViewKomp.Name = "listViewKomp";
            this.listViewKomp.Size = new System.Drawing.Size(456, 231);
            this.listViewKomp.TabIndex = 1;
            this.listViewKomp.UseCompatibleStateImageBehavior = false;
            this.listViewKomp.View = System.Windows.Forms.View.Details;
            this.listViewKomp.SelectedIndexChanged += new System.EventHandler(this.listViewKomp_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Уровень КА";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Сроки";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ПО";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Масштаб сотрудников";
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxSrok.Location = new System.Drawing.Point(25, 124);
            this.textBoxSrok.Name = "textBoxSrok";
            this.textBoxSrok.Size = new System.Drawing.Size(200, 30);
            this.textBoxSrok.TabIndex = 2;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Базовый",
            "Стандартный",
            "Комплексный"});
            this.comboBoxLevel.Location = new System.Drawing.Point(24, 71);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(200, 29);
            this.comboBoxLevel.TabIndex = 3;
            // 
            // labelSrok
            // 
            this.labelSrok.AutoSize = true;
            this.labelSrok.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelSrok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSrok.Location = new System.Drawing.Point(21, 103);
            this.labelSrok.Name = "labelSrok";
            this.labelSrok.Size = new System.Drawing.Size(110, 21);
            this.labelSrok.TabIndex = 4;
            this.labelSrok.Text = "Срок реализации";
            // 
            // textBoxPO
            // 
            this.textBoxPO.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxPO.Location = new System.Drawing.Point(24, 173);
            this.textBoxPO.Name = "textBoxPO";
            this.textBoxPO.Size = new System.Drawing.Size(200, 30);
            this.textBoxPO.TabIndex = 5;
            // 
            // textBoxMachtab
            // 
            this.textBoxMachtab.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxMachtab.Location = new System.Drawing.Point(24, 222);
            this.textBoxMachtab.Name = "textBoxMachtab";
            this.textBoxMachtab.Size = new System.Drawing.Size(200, 30);
            this.textBoxMachtab.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxPrice.Location = new System.Drawing.Point(25, 271);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 30);
            this.textBoxPrice.TabIndex = 7;
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPO.Location = new System.Drawing.Point(22, 157);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(23, 13);
            this.labelPO.TabIndex = 8;
            this.labelPO.Text = "ПО";
            // 
            // labelMachtab
            // 
            this.labelMachtab.AutoSize = true;
            this.labelMachtab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMachtab.Location = new System.Drawing.Point(22, 206);
            this.labelMachtab.Name = "labelMachtab";
            this.labelMachtab.Size = new System.Drawing.Size(53, 13);
            this.labelMachtab.TabIndex = 9;
            this.labelMachtab.Text = "Масштаб";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(22, 255);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 13);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Стоимость";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonDel.Location = new System.Drawing.Point(517, 308);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonEdit.Location = new System.Drawing.Point(426, 308);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(335, 308);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Kompleksnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMachtab);
            this.Controls.Add(this.labelPO);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxMachtab);
            this.Controls.Add(this.textBoxPO);
            this.Controls.Add(this.labelSrok);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.textBoxSrok);
            this.Controls.Add(this.listViewKomp);
            this.Controls.Add(this.labelLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kompleksnaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплексная автоматизация";
            this.Load += new System.EventHandler(this.Kompleksnaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ListView listViewKomp;
        private System.Windows.Forms.TextBox textBoxSrok;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label labelSrok;
        private System.Windows.Forms.TextBox textBoxPO;
        private System.Windows.Forms.TextBox textBoxMachtab;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.Label labelMachtab;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}