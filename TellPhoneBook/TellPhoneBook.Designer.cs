namespace TellPhoneBook
{
    partial class TellPhoneBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellPhoneBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbOther = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdPerson = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.cmbOther);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати контакт";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(434, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Видалити контакт";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(434, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Змінити контакт";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Location = new System.Drawing.Point(434, 16);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Додати контакт";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(104, 76);
            this.txtPhoneNumber.Mask = "+38(999) 999-99-99";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // cmbOther
            // 
            this.cmbOther.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOther.FormattingEnabled = true;
            this.cmbOther.Items.AddRange(new object[] {
            "Робота",
            "Сім`я",
            "Друзі",
            "Офiс"});
            this.cmbOther.Location = new System.Drawing.Point(64, 160);
            this.cmbOther.Name = "cmbOther";
            this.cmbOther.Size = new System.Drawing.Size(155, 21);
            this.cmbOther.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 192);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(490, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(64, 107);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(286, 47);
            this.txtAddress.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(64, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 20);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(64, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пошук:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Група:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адреса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефону:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.dgvContactList);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контакти";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(6, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистити поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(479, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Вихід";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(9, 19);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.ReadOnly = true;
            this.dgvContactList.Size = new System.Drawing.Size(545, 193);
            this.dgvContactList.TabIndex = 0;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.ВийтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.проПрограммуToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.открытьToolStripMenuItem.Text = "Вiдкрити";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.помощьToolStripMenuItem.Text = "Допомога";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // проПрограммуToolStripMenuItem
            // 
            this.проПрограммуToolStripMenuItem.Name = "проПрограммуToolStripMenuItem";
            this.проПрограммуToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.проПрограммуToolStripMenuItem.Text = "Про программу";
            this.проПрограммуToolStripMenuItem.Click += new System.EventHandler(this.проПрограммуToolStripMenuItem_Click);
            // 
            // ВийтиToolStripMenuItem
            // 
            this.ВийтиToolStripMenuItem.Name = "ВийтиToolStripMenuItem";
            this.ВийтиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ВийтиToolStripMenuItem.Text = "Вийти";
            this.ВийтиToolStripMenuItem.Click += new System.EventHandler(this.ВийтиToolStripMenuItem_Click);
            // 
            // txtIdPerson
            // 
            this.txtIdPerson.Location = new System.Drawing.Point(562, 1);
            this.txtIdPerson.Name = "txtIdPerson";
            this.txtIdPerson.Size = new System.Drawing.Size(10, 20);
            this.txtIdPerson.TabIndex = 15;
            this.txtIdPerson.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 17);
            this.dateLabel.Text = "Дата:";
            // 
            // statBar
            // 
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLabel,
            this.toolStripStatusLabel1});
            this.statBar.Location = new System.Drawing.Point(0, 510);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(584, 22);
            this.statBar.TabIndex = 3;
            this.statBar.Text = "statBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TellPhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 532);
            this.Controls.Add(this.txtIdPerson);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 570);
            this.Name = "TellPhoneBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TellPhoneBook";
            this.Load += new System.EventHandler(this.TellPhoneBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cmbOther;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВийтиToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIdPerson;
        private System.Windows.Forms.ToolStripStatusLabel dateLabel;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

