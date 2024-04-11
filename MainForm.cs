using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class MainForm : Form
    {
        private bool isAdmin = false;
        private MySqlConnection conn;
        private List<Element> elements = new List<Element>();
        public Timer timerAutoUpdate;

        private int _pictureBoxHeightStandart;
        private const int _pictureBoxHeightImageNotFound = 130;

        public MainForm(bool _isAdmin, string login, string userName)
        {
            isAdmin = _isAdmin;
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            this.Text += $"  Login:\"{login}\"  User:\"{userName}\"" + (isAdmin ? "   [ADMIN]" : "");
            _pictureBoxHeightStandart = pictureBox.Height;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            timerAutoUpdate = new Timer();
            timerAutoUpdate.Interval = Properties.Settings.Default.AutopdateDataInterval;
            timerAutoUpdate.Tick += TimerAutoUpdate_Tick;
            timerAutoUpdate.Enabled = Properties.Settings.Default.isAutoupdateDate;
            checkBox_inver_sort_CheckedChanged(null, null);

            toolStripButton_addElement.Visible = isAdmin;
            toolStripButton_removeElement.Visible = isAdmin;
            button_editElement.Visible = isAdmin;
            добавитьToolStripMenuItem.Visible = isAdmin;
            изменитьToolStripMenuItem.Visible = isAdmin;
            удалитьToolStripMenuItem.Visible = isAdmin;

            conn = new MySqlConnection(SQLData.ConnectionString);

            MessageBox.Show($"Вы вошли в систему как: {userName}" + (_isAdmin ? "\nВозможности редактирования присутствуют." : ""), "Вход");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control && isAdmin) toolStripButton_addElement_Click(sender, e);
            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control && isAdmin) button_editElement_Click(sender, e);
            if (e.KeyCode == Keys.U && e.Modifiers == Keys.Control) UpdateList(false);
            if (e.KeyCode == Keys.Oemplus && e.Modifiers == Keys.Control && Font.Size <= 20) this.Font = new Font(Font.FontFamily, Font.Size + 1, Font.Style);
            if (e.KeyCode == Keys.OemMinus && e.Modifiers == Keys.Control && Font.Size >= 5) this.Font = new Font(Font.FontFamily, Font.Size - 1, Font.Style);
            if (e.KeyCode == Keys.Delete && isAdmin) toolStripButton_removeElement_Click(sender, e);
        }

        private void TimerAutoUpdate_Tick(object sender, EventArgs e)
        {
            UpdateList(false);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        private void toolStripButton_updateElements_Click(object sender, EventArgs e) => UpdateList(false);

        private void UpdateList(bool dropIndex = true)
        {
            if (!OpenSQLConnect(ref conn, this)) return;
            string sql = "SELECT `id`, `name` FROM `elements`";
            //сортировка
            if (radioButton_sort_delivery_date.Checked) sql += " ORDER by `delivery_date`";
            if (radioButton_sort_production_date.Checked) sql += " ORDER by `production_date`";
            if (radioButton_sort_name.Checked) sql += " ORDER by `name`";
            if (radioButton_sort_quantity.Checked) sql += " ORDER by `quantity`";
            if (radioButton_sort_provider.Checked) sql += " ORDER by `provider`";
            if (radioButton_sort_manufacturer.Checked) sql += " ORDER by `manufacturer`";
            if (radioButton_sort_none.Checked) sql += " ORDER by `id`";

            if (checkBox_inver_sort.Checked) sql += "DESC";

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                for (int i = 0; i < elements.Count; i++) { elements[i].Dispose(); elements[i] = null; }
                elements.Clear();
                while (reader.Read())
                {
                    elements.Add(new Element(int.Parse(reader[0].ToString()), reader[1].ToString()));
                }
                System.GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }
            reader.Close();
            conn.Close();

            int lastIndex = listBox_elements.SelectedIndex;

            listBox_elements.Items.Clear();
            for (int i = 0; i < elements.Count; i++)
            {
                listBox_elements.Items.Add($"{Element.Dencode(elements[i].Name)}");
            }

            if (listBox_elements.Items.Count > 0)
            {
                try
                {
                    listBox_elements.SelectedIndex = dropIndex ? 0 : lastIndex;
                }
                catch { listBox_elements.SelectedIndex = 0; }
                listBox_elements_SelectedIndexChanged(null, null);
            }
            else
            {
                flowLayoutPanel1.Visible = false;
            }

            if (timerAutoUpdate.Enabled) { timerAutoUpdate.Stop(); timerAutoUpdate.Start(); }
        }

        static public bool OpenSQLConnect(ref MySqlConnection conn, MainForm mainForm = null)
        {
            try
            {
                conn.Open();
                if (mainForm != null) mainForm.timerAutoUpdate.Start();
                return true;
            }
            catch
            {
                conn.Close();
                if (mainForm != null) mainForm.timerAutoUpdate.Stop();
                MessageBox.Show("Ошибка подключения!\nНе удаётся установить соединение с сервером!", "Ой", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (mainForm != null) mainForm.timerAutoUpdate.Start();
                return false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void setImageToNotFound()
        {
            pictureBox.Height = _pictureBoxHeightImageNotFound;
            elements[listBox_elements.SelectedIndex].Image = Properties.Resources.fileNotFoundIcon;
        }

        private void listBox_elements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_elements.SelectedIndex == -1)
            {
                button_editElement.Enabled = false;
                toolStripButton_removeElement.Enabled = false;
                изменитьToolStripMenuItem.Enabled = false;
                удалитьToolStripMenuItem.Enabled = false;
                return;
            }
            else
            {
                button_editElement.Enabled = true;
                toolStripButton_removeElement.Enabled = true;
                изменитьToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem.Enabled = true;
            }

            if (!OpenSQLConnect(ref conn)) return;
            //flowLayoutPanel1.Visible = false;
            string sql = "SELECT `id`, `name`, `description`, `manufacturer`, `quantity`, `delivery_date`, `provider`, `production_date`, `image`, `unit_measurement` FROM `elements` WHERE `id`=" + elements[listBox_elements.SelectedIndex].Id.ToString();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    elements[listBox_elements.SelectedIndex].Id = int.Parse(reader[0].ToString());
                    elements[listBox_elements.SelectedIndex].Name = reader[1].ToString();
                    elements[listBox_elements.SelectedIndex].Description = reader[2].ToString();
                    elements[listBox_elements.SelectedIndex].Manufacturer = reader[3].ToString();
                    elements[listBox_elements.SelectedIndex].Quantity = int.Parse(reader[4].ToString());
                    elements[listBox_elements.SelectedIndex].Delivery_date = DateTime.Parse(reader[5].ToString());
                    elements[listBox_elements.SelectedIndex].Provider = reader[6].ToString();
                    elements[listBox_elements.SelectedIndex].Production_date = DateTime.Parse(reader[7].ToString());
                    elements[listBox_elements.SelectedIndex].ImagePath = reader[8].ToString();
                    elements[listBox_elements.SelectedIndex].Unit_measurement = reader[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }
            reader.Close();
            conn.Close();

            // загрузка изображения
            string imagePath = Element.Dencode(elements[listBox_elements.SelectedIndex].ImagePath);
            if (elements[listBox_elements.SelectedIndex].Image != null) elements[listBox_elements.SelectedIndex].Image.Dispose(); // удалить старое                  
            try
            {
                elements[listBox_elements.SelectedIndex].Image = new Bitmap(imagePath);
                pictureBox.Height = _pictureBoxHeightStandart;
            }
            catch
            {
                Bitmap bitmap = LoadPicture(imagePath);
                if (bitmap == null) setImageToNotFound();
                else
                {
                    pictureBox.Height = _pictureBoxHeightStandart;
                    elements[listBox_elements.SelectedIndex].Image = bitmap;
                }
            }
            var el = elements[listBox_elements.SelectedIndex];
            label_name.Text = Element.Dencode(el.Name);
            textBox_description.Text = Element.Dencode(el.Description);
            label_manufacturer.Text = "Производитель: " + Element.Dencode(el.Manufacturer);
            label_count.Text = "Количество: " + el.Quantity.ToString() + $" {Element.Dencode(el.Unit_measurement)}";
            label_delivery_date.Text = "Дата поставки: " + el.Delivery_date.ToString();
            label_production_date.Text = "Дата производства: " + el.Production_date.ToString();
            label_provider.Text = "Поставщик: " + Element.Dencode(el.Provider);

            if (pictureBox.Image != null) pictureBox.Image.Dispose();
            pictureBox.Image = el.Image;

            flowLayoutPanel1.Visible = true;
        }

        private void toolStripButton_addElement_Click(object sender, EventArgs e)
        {
            if (!isAdmin) return;

            new AddEditElementForm().ShowDialog();
            if (!AddEditElementForm.isSave) return;

            if (!OpenSQLConnect(ref conn)) return;
            string sql = "SELECT EXISTS(SELECT* FROM `elements` WHERE `name`= '" + AddEditElementForm.el.Name + "')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    if (reader[0].ToString() != "0")
                    {
                        reader.Close();
                        conn.Close();
                        MessageBox.Show("Такой элемент уже существует!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }
            reader.Close();

            sql = $"INSERT INTO `elements` (`name`, `description`, `manufacturer`, `quantity`, `production_date`, `delivery_date`, `provider`, `image`, `unit_measurement`) VALUES " +
                $"('{AddEditElementForm.el.Name}', '{AddEditElementForm.el.Description}', '{AddEditElementForm.el.Manufacturer}', '{AddEditElementForm.el.Quantity}', '{AddEditElementForm.el.Production_date.ToString("s").Replace('T', ' ')}', '{AddEditElementForm.el.Delivery_date.ToString("s").Replace('T', ' ')}', '{AddEditElementForm.el.Provider}', '{AddEditElementForm.el.ImagePath}', '{AddEditElementForm.el.Unit_measurement}')";
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
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }

            reader.Close();
            conn.Close();

            UpdateList();
        }

        private void toolStripButton_removeElement_Click(object sender, EventArgs e)
        {
            if (!isAdmin) return;

            if (listBox_elements.SelectedIndex == -1) return;

            if (MessageBox.Show(
                "Вы уверены, что хотите безвозвратно удалить данные о товаре?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No) return;

            if (!OpenSQLConnect(ref conn)) return;
            string sql = "DELETE FROM `elements` WHERE `id` = " + elements[listBox_elements.SelectedIndex].Id;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }
            reader.Close();
            conn.Close();

            UpdateList();
        }

        private void button_editElement_Click(object sender, EventArgs e)
        {
            if (!isAdmin) return;

            if (listBox_elements.SelectedIndex == -1) return;
            new AddEditElementForm(elements[listBox_elements.SelectedIndex]).ShowDialog();
            if (!AddEditElementForm.isSave) return;

            if (!OpenSQLConnect(ref conn)) return;
            string sql = $"UPDATE `elements` SET `name` = '{AddEditElementForm.el.Name}', `image`='{AddEditElementForm.el.ImagePath}', `description` = '{AddEditElementForm.el.Description}', `manufacturer` = '{AddEditElementForm.el.Manufacturer}', `provider`='{AddEditElementForm.el.Provider}', `quantity` = '{AddEditElementForm.el.Quantity}', `unit_measurement`='{AddEditElementForm.el.Unit_measurement}' WHERE `id` = {elements[listBox_elements.SelectedIndex].Id}";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n\n" + ex.Message);
            }

            reader.Close();
            conn.Close();

            UpdateList(false);
        }

        public static Bitmap LoadPicture(string url)
        {
            System.Net.HttpWebRequest wreq;
            System.Net.HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (System.Net.HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // Do nothing... 
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        private void toolStripButton_openSettingsProfile_Click(object sender, EventArgs e) => new SettingsForm(this, SettingsForm.TabPanel.Profile).ShowDialog();

        private void toolStripButton_exitProfile_Click(object sender, EventArgs e) => Application.Restart();

        private void toolStripButton_openSettings_Click(object sender, EventArgs e) => new SettingsForm(this).ShowDialog();

        private void toolStripButton_Find_Click(object sender, EventArgs e)
        {
            if (elements.Count < 2) return;
            UpdateList(false);
            new Find_Form(elements).ShowDialog();
            if (Find_Form.FindElementIndex != -1) listBox_elements.SelectedIndex = Find_Form.FindElementIndex;
        }

        private void checkBox_inver_sort_CheckedChanged(object sender, EventArgs e) => checkBox_inver_sort.BackgroundImage = !checkBox_inver_sort.Checked ? Properties.Resources.inSortI : Properties.Resources.inSort;
    }
}
