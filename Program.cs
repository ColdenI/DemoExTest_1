using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseSystem
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
           
            string login = null, password = null;
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-l") login = args[i + 1];
                    if (args[i] == "-p") password = args[i + 1];
                }
            }
            catch { }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // запуск mysql
            if (!File.Exists(Properties.Settings.Default.mysqld_path))
            {
                MessageBox.Show("Файл mysql не найден, укажите путь к файлу 'mysqld.exe'", "MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "|*.exe";
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                if (new FileInfo(ofd.FileName).Name != "mysqld.exe") return;
                Properties.Settings.Default.mysqld_path = ofd.FileName;
                Properties.Settings.Default.Save();
                Application.Restart();
            }

            Process proc = new Process();
            if (!Process.GetProcessesByName("mysqld").Any())
            {              
                //proc.StartInfo.FileName = "mysqld";
                proc.StartInfo.FileName = Properties.Settings.Default.mysqld_path;
                proc.StartInfo.UseShellExecute = true;
                //proc.StartInfo.Verb = "runas";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }

            if (login != null && password != null) Application.Run(new LoginForm(login, password));
            else Application.Run(new LoginForm());

            try
            {
                proc.Kill();
            }catch { }
            proc.Close();
            Application.Exit();
        }
    }
}
