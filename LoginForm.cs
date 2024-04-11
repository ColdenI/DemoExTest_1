using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class LoginForm : Form
    {
        private Timer timeOut;
        private MySqlConnection conn;

        public LoginForm(string _login, string _password) 
        {
            INIT();
            textBox_login.Text = _login;
            textBox_password.Text = _password;
            button_login_Click(null, null);
        }

        public LoginForm() => INIT();

        private void INIT()
        {
            InitializeComponent();

            if (!SQLData.LoadSqlData())
            {
                new Install().ShowDialog();
                //MessageBox.Show($"Файл \"{SQLData.pathSQLConConfig}\" был создан, заполниет данные для подключения...\nПуть: \"{Path.GetFullPath(SQLData.pathSQLConConfig)}\"");
            }

            timeOut = new Timer();
            timeOut.Interval = 3000;
            timeOut.Tick += TimeOut_Tick;
        }

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            conn.Close();
            timeOut.Stop();
            MessageBox.Show("Ошибка подключения!\nНе удаётся установить соединение с сервером!", "Ой", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            //MessageBox.Show("Ошибка подключения!");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            // создаём объект для подключения к БД
            conn = new MySqlConnection(SQLData.ConnectionString);
            // устанавливаем соединение с БД
            timeOut.Start();
            try
            {
                conn.Open();
            }catch
            {
                timeOut.Stop();
                MessageBox.Show("Ошибка подключения!\nНе удаётся установить соединение с сервером!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                conn.Close();
                this.Enabled = true;
                return;
            }
            // запрос
            string sql = "SELECT `password`, `is_admin`, `name` FROM `users` WHERE `login`='" + textBox_login.Text.ToString() + "'";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            timeOut.Stop();

            try
            {
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    if (reader[0].ToString() == CreateMD5(textBox_password.Text))
                    {
                        bool isAdmin = (reader[1].ToString() == "1") ? true : false;
                        string name = reader[2].ToString();
                        reader.Close();
                        conn.Close();
                        this.Visible = false;
                        var mf = new MainForm(isAdmin, textBox_login.Text.ToString(), name);
                        mf.Owner = this;
                        mf.Show();
                        this.Enabled = true;
                        return;
                    }
                }
            }catch (Exception ex) {
                MessageBox.Show("Произошла ошибка!\n\n"+ ex.Message);
            }
            MessageBox.Show("Логин или пароль неверны!");
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();
            this.Enabled = true;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void checkBox_viewPassword_CheckedChanged(object sender, EventArgs e) => textBox_password.PasswordChar = checkBox_viewPassword.Checked ? (char)0 : '*';

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button_login_Click(sender, e);
        }


    }
}
