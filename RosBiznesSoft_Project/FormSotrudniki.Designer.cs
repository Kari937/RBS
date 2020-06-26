namespace RosBiznesSoft_Project
{
    partial class FormSotrudniki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSotrudniki));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewSotrudniki = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelDolzhnost = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDob = new System.Windows.Forms.TextBox();
            this.textBoxDolzhnost = new System.Windows.Forms.TextBox();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonDel.Location = new System.Drawing.Point(456, 330);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 40);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonEdit.Location = new System.Drawing.Point(365, 330);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 40);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(274, 330);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 40);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewSotrudniki
            // 
            this.listViewSotrudniki.BackColor = System.Drawing.SystemColors.Window;
            this.listViewSotrudniki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSotrudniki.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.listViewSotrudniki.FullRowSelect = true;
            this.listViewSotrudniki.GridLines = true;
            this.listViewSotrudniki.HideSelection = false;
            this.listViewSotrudniki.Location = new System.Drawing.Point(150, 87);
            this.listViewSotrudniki.MultiSelect = false;
            this.listViewSotrudniki.Name = "listViewSotrudniki";
            this.listViewSotrudniki.Size = new System.Drawing.Size(583, 217);
            this.listViewSotrudniki.TabIndex = 22;
            this.listViewSotrudniki.UseCompatibleStateImageBehavior = false;
            this.listViewSotrudniki.View = System.Windows.Forms.View.Details;
            this.listViewSotrudniki.SelectedIndexChanged += new System.EventHandler(this.listViewSotrudniki_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия Имя";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Должность";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Добавочный номер";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Почта";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 127;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(14, 250);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 21);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Почта";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelDob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDob.Location = new System.Drawing.Point(12, 193);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(123, 21);
            this.labelDob.TabIndex = 20;
            this.labelDob.Text = "Добавочный номер";
            // 
            // labelDolzhnost
            // 
            this.labelDolzhnost.AutoSize = true;
            this.labelDolzhnost.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelDolzhnost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDolzhnost.Location = new System.Drawing.Point(14, 136);
            this.labelDolzhnost.Name = "labelDolzhnost";
            this.labelDolzhnost.Size = new System.Drawing.Size(76, 21);
            this.labelDolzhnost.TabIndex = 19;
            this.labelDolzhnost.Text = "Должность";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.labelNames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNames.Location = new System.Drawing.Point(14, 79);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(93, 21);
            this.labelNames.TabIndex = 18;
            this.labelNames.Text = "Фамилия Имя";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxEmail.Location = new System.Drawing.Point(18, 274);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 30);
            this.textBoxEmail.TabIndex = 17;
            // 
            // textBoxDob
            // 
            this.textBoxDob.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxDob.Location = new System.Drawing.Point(18, 217);
            this.textBoxDob.Name = "textBoxDob";
            this.textBoxDob.Size = new System.Drawing.Size(100, 30);
            this.textBoxDob.TabIndex = 16;
            // 
            // textBoxDolzhnost
            // 
            this.textBoxDolzhnost.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxDolzhnost.Location = new System.Drawing.Point(18, 160);
            this.textBoxDolzhnost.Name = "textBoxDolzhnost";
            this.textBoxDolzhnost.Size = new System.Drawing.Size(100, 30);
            this.textBoxDolzhnost.TabIndex = 15;
            // 
            // textBoxNames
            // 
            this.textBoxNames.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.textBoxNames.Location = new System.Drawing.Point(18, 103);
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(100, 30);
            this.textBoxNames.TabIndex = 14;
            // 
            // FormSotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(745, 382);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewSotrudniki);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelDolzhnost);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxDob);
            this.Controls.Add(this.textBoxDolzhnost);
            this.Controls.Add(this.textBoxNames);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSotrudniki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormSotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewSotrudniki;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelDolzhnost;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDob;
        private System.Windows.Forms.TextBox textBoxDolzhnost;
        private System.Windows.Forms.TextBox textBoxNames;
    }
}