using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class Install : Form
    {
        private MySqlConnection conn;

        public Install()
        {
            InitializeComponent();
            this.FormClosed += Install_FormClosed;
        }

        private void Install_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection($"server={textBox_server.Text};user={textBox_login.Text};database=mysql;password={textBox_password.Text};");
            this.Enabled = false;
            progressBar1.Value = 6; Update();
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения!\nНе удаётся установить соединение с сервером!\nПроверьте введенные данные...", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                progressBar1.Value = 0; Update();
                this.Enabled = true;
                return;
            }
            progressBar1.Value = 23; Update();


            string sql = 
                $"CREATE DATABASE `{textBox_database.Text}`;" +
                $"USE `{textBox_database.Text}`;" +
                "DROP TABLE IF EXISTS `elements`;" +
                "CREATE TABLE `elements` (\r\n  `id` int NOT NULL AUTO_INCREMENT,\r\n  `name` text NOT NULL,\r\n  `description` mediumtext,\r\n  `image` text,\r\n  `manufacturer` text,\r\n  `provider` text,\r\n  `quantity` int NOT NULL DEFAULT '0',\r\n  `production_date` datetime DEFAULT '1970-01-01 01:00:00',\r\n  `delivery_date` datetime DEFAULT '1970-01-01 01:00:00',\r\n  `unit_measurement` text,\r\n  PRIMARY KEY (`id`),\r\n  UNIQUE KEY `id_UNIQUE` (`id`)\r\n) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;" +
                "DROP TABLE IF EXISTS `users`;" +
                "CREATE TABLE `users` (\r\n  `id` int NOT NULL AUTO_INCREMENT,\r\n  `login` varchar(128) DEFAULT NULL,\r\n  `password` varchar(128) DEFAULT NULL,\r\n  `is_admin` tinyint NOT NULL DEFAULT '0',\r\n  `name` varchar(128) DEFAULT NULL,\r\n  PRIMARY KEY (`id`),\r\n  UNIQUE KEY `login` (`login`)\r\n) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;" +
                "LOCK TABLES `users` WRITE;" +
                "INSERT INTO `users` VALUES (1,'admin','21232F297A57A5A743894A0E4A801FC3',1,'Администратор'),(2,'user','EE11CBB19052E40B07AAC0CA060C23EE',0,'Пользователь');\r\n" +
                "UNLOCK TABLES;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
            }catch
            {
                goto F;
            }
            try { while (reader.Read()) { } }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }

            F:

            progressBar1.Value = 77; Update();

            File.WriteAllText(SQLData.pathSQLConConfig,
                $"<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                    $"\r\n<MySQLConnectionConfig>\r\n  " +
                        $"<server>{textBox_server.Text}</server>\r\n  " +
                        $"<user>{textBox_login.Text}</user>\r\n  " +
                        $"<password>{textBox_password.Text}</password>\r\n  " +
                        $"<database>{textBox_database.Text}</database>\r\n  " +
                    $"</MySQLConnectionConfig>"
            );
            progressBar1.Value = 100; Update();
            MessageBox.Show("База данных успешно настроена.");
            this.Enabled = true;
            Application.Restart();
        }
    }
}

