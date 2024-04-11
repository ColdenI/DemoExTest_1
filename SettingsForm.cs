using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class SettingsForm : Form
    {
        private MySqlConnection conn;
        private MainForm mainForm;


        public SettingsForm(MainForm mainForm, TabPanel tabPanel = TabPanel.Profile)
        {
            InitializeComponent();
            tabControl1.SelectTab((int)tabPanel);
            this.mainForm = mainForm;

            conn = new MySqlConnection(SQLData.ConnectionString);
        }

        public enum TabPanel
        {
            Profile = 0,
            Autoupdate = 1
        }

        #region Profile
        private void textBox_changePassword_newPassword_TextChanged(object sender, EventArgs e)
        {       
            if (textBox_changePassword_newPassword.Text.Length < 4) label_changePasswordError.Text = "Пароль слишком короткий!";
            else label_changePasswordError.Text = string.Empty;

            if (!isSanitation(textBox_changePassword_newPassword.Text)) label_changePasswordError.Text = "Пароль не должен содержать спец символы!";
            
        }
        private void button_changePassword_Click(object sender, EventArgs e)
        {
            label_changePasswordError.Text = string.Empty;

            if (textBox_changePassword_newPassword.Text.Length < 4)
            {
                label_changePasswordError.Text = "Пароль слишком короткий!";
                return;
            }
            
            if (!isSanitation(textBox_changePassword_newPassword.Text))
            {
                label_changePasswordError.Text = "Пароль не должен содержать спец символы!";
                return;
            }

            if(!MainForm.OpenSQLConnect(ref conn)) return;
            string sql = $"SELECT EXISTS(SELECT * FROM `users` WHERE `login`= '{textBox_changePassword_login.Text}' && `password`='{LoginForm.CreateMD5(textBox_changePassword_lastPassword.Text)}')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) == 0)
                    {
                        label_changePasswordError.Text = "Логин или пароль неверны!";
                        reader.Close(); conn.Close();
                        return;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка!\n\n" + ex.Message); }
            reader.Close();

            sql = $"UPDATE `users` SET `password`='{LoginForm.CreateMD5(textBox_changePassword_newPassword.Text)}' WHERE `login` = '{textBox_changePassword_login.Text}'";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка!\n\n" + ex.Message); }
            reader.Close(); conn.Close();
            MessageBox.Show("Пароль изменён.");
            Application.Restart();
        }
        #endregion

        static public bool isSanitation(string text)
        {
            if(string.IsNullOrEmpty(text)) return false;
            if (text.Contains('`') ||
                text.Contains('\'') ||
                text.Contains('\"') ||
                text.Contains('&') ||
                text.Contains('|') ||
                text.Contains('\\')
                ) return false;

            return true;
        }

        private void checkBox_autoupdate_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isAutoupdateDate = checkBox_autoupdate.Checked;
            SaveAutoupdateDate();
            numericUpDown_autoupdate.Enabled = checkBox_autoupdate.Checked;
        }

        private void numericUpDown_autoupdate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutopdateDataInterval = (int)numericUpDown_autoupdate.Value * 1000;
            SaveAutoupdateDate();
        }

        private void SaveAutoupdateDate()
        {
            Properties.Settings.Default.Save();
            mainForm.timerAutoUpdate.Interval = Properties.Settings.Default.AutopdateDataInterval;
            mainForm.timerAutoUpdate.Enabled = Properties.Settings.Default.isAutoupdateDate;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBox_autoupdate.Checked = Properties.Settings.Default.isAutoupdateDate;
            numericUpDown_autoupdate.Value = Properties.Settings.Default.AutopdateDataInterval / 1000;
            numericUpDown_autoupdate.Enabled = checkBox_autoupdate.Checked;
        }
    }
}
