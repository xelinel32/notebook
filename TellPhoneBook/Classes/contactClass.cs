using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellPhoneBook.Classes
{
    class contactClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Other { get; set; }

        //Подключились к базе
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Просмотр
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM [TContactPersons]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Добавление в базу
        public bool Insert (contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO [TContactPersons] ([Ім`я], [Прізвище], [Телефон], [Адреса], [Група]) VALUES(N'" + c.FirstName+ "', N'" + c.LastName + "', N'" + c.PhoneNumber + "', N'" + c.Address.Trim() + "', N'" + c.Other + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Обновление данных
        public bool Update(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE [TContactPersons] SET [Ім`я]=N'" + c.FirstName+ "', [Прізвище]=N'" + c.LastName+ "', [Телефон]=N'" + c.PhoneNumber+ "', [Адреса]=N'" + c.Address.Trim()+ "', [Група]=N'" + c.Other + "' WHERE [ID]='"+c.Id+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Удаление данных
        public bool Delete(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM [TContactPersons] WHERE [ID]=N'"+c.Id+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
