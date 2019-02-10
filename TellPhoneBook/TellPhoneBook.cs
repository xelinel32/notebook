using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TellPhoneBook.Classes;

namespace TellPhoneBook
{
    public partial class TellPhoneBook : Form
    {
        public TellPhoneBook()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();
        //Додавання даних
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" || cmbOther.Text == "")
            {
                MessageBox.Show("Поля порожні! Заповніть всі поля!", "TellPhoneBook");
            } else
            {
                c.FirstName = txtFirstName.Text;
                c.LastName = txtLastName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;
                c.Address = txtAddress.Text;
                c.Other = cmbOther.Text;

                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("Контакт доданий!", "TellPhoneBook");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Контакт не доданий!", "TellPhoneBook");
                }
                //Load
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
        }
        //Подгрузка сразу в форму
        private void TellPhoneBook_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        //Метод очистки полей
        public void Clear()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtPhoneNumber.Text = null;
            txtAddress.Text = null;
            cmbOther.Text = null;
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Отображение в текстбоксах для изменения контакта
            int rowIndex = e.RowIndex;
            txtIdPerson.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbOther.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }
        //Изменение данных
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdPerson.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" || cmbOther.Text == "")
            {
                MessageBox.Show("Поля порожні! Заповніть всі поля!", "TellPhoneBook");
            }
            else
            {
                c.Id = Convert.ToInt32(txtIdPerson.Text);
                c.FirstName = txtFirstName.Text;
                c.LastName = txtLastName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;
                c.Address = txtAddress.Text;
                c.Other = cmbOther.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Контакт змінений!", "TellPhoneBook");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Контакт не змінений!", "TellPhoneBook");
                }
                //Load
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
        }
        //Удаление данных
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdPerson.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" || cmbOther.Text == "")
            {
                MessageBox.Show("Поля порожні! Заповніть всі поля!", "TellPhoneBook");
            }
            else
            {
                c.Id = Convert.ToInt32(txtIdPerson.Text);
                bool success = c.Delete(c);
                if (success == true)
                {
                    MessageBox.Show("Контакт видалений!", "TellPhoneBook");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Контакт не видалено!", "TellPhoneBook");
                }
                //Load
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
        }
        //подключаем базу
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [TContactPersons] WHERE [Ім`я] LIKE N'%" + keyword+ "%' OR [Прізвище] LIKE N'%" + keyword + "%' OR [Телефон] LIKE N'%" + keyword + "%' OR [Адреса] LIKE N'%" + keyword + "%' OR [Група] LIKE N'%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void ВийтиToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        //Запрет на открытие тех же окон
        Help f2;
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Help();
                f2.Show();
            }
        }
        Info f1; 
        private void проПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null || f1.IsDisposed)
            {
                f1 = new Info();
                f1.Show();
            }
        }
        //Проверка на запретные символы
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'ї' && l != 'і' && l != 'ґ')
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'ї' && l != 'і' && l != 'ґ' && l != 'ё')
            {
                e.Handled = true;
            }
        }
    }
}
