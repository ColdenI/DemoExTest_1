namespace WarehouseSystem
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.textBox_changePassword_login = new System.Windows.Forms.TextBox();
            this.textBox_changePassword_lastPassword = new System.Windows.Forms.TextBox();
            this.textBox_changePassword_newPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_profile = new System.Windows.Forms.TabPage();
            this.label_changePasswordError = new System.Windows.Forms.Label();
            this.tabPage_autoupdate = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_autoupdate = new System.Windows.Forms.NumericUpDown();
            this.checkBox_autoupdate = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_profile.SuspendLayout();
            this.tabPage_autoupdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Старый пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_changePassword
            // 
            this.button_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changePassword.Location = new System.Drawing.Point(321, 102);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(96, 28);
            this.button_changePassword.TabIndex = 2;
            this.button_changePassword.Text = "Изменить";
            this.button_changePassword.UseVisualStyleBackColor = true;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // textBox_changePassword_login
            // 
            this.textBox_changePassword_login.Location = new System.Drawing.Point(127, 3);
            this.textBox_changePassword_login.MaxLength = 128;
            this.textBox_changePassword_login.Name = "textBox_changePassword_login";
            this.textBox_changePassword_login.Size = new System.Drawing.Size(284, 22);
            this.textBox_changePassword_login.TabIndex = 3;
            // 
            // textBox_changePassword_lastPassword
            // 
            this.textBox_changePassword_lastPassword.Location = new System.Drawing.Point(127, 33);
            this.textBox_changePassword_lastPassword.MaxLength = 128;
            this.textBox_changePassword_lastPassword.Name = "textBox_changePassword_lastPassword";
            this.textBox_changePassword_lastPassword.PasswordChar = '*';
            this.textBox_changePassword_lastPassword.Size = new System.Drawing.Size(284, 22);
            this.textBox_changePassword_lastPassword.TabIndex = 4;
            // 
            // textBox_changePassword_newPassword
            // 
            this.textBox_changePassword_newPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_changePassword_newPassword.Location = new System.Drawing.Point(127, 63);
            this.textBox_changePassword_newPassword.MaxLength = 128;
            this.textBox_changePassword_newPassword.Name = "textBox_changePassword_newPassword";
            this.textBox_changePassword_newPassword.PasswordChar = '*';
            this.textBox_changePassword_newPassword.Size = new System.Drawing.Size(284, 22);
            this.textBox_changePassword_newPassword.TabIndex = 5;
            this.textBox_changePassword_newPassword.TextChanged += new System.EventHandler(this.textBox_changePassword_newPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Новый пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.04831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_changePassword_newPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_changePassword_lastPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_changePassword_login, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 90);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_profile);
            this.tabControl1.Controls.Add(this.tabPage_autoupdate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 168);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage_profile
            // 
            this.tabPage_profile.Controls.Add(this.label_changePasswordError);
            this.tabPage_profile.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_profile.Controls.Add(this.button_changePassword);
            this.tabPage_profile.Location = new System.Drawing.Point(4, 25);
            this.tabPage_profile.Name = "tabPage_profile";
            this.tabPage_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_profile.Size = new System.Drawing.Size(427, 139);
            this.tabPage_profile.TabIndex = 0;
            this.tabPage_profile.Text = "Профиль";
            this.tabPage_profile.UseVisualStyleBackColor = true;
            // 
            // label_changePasswordError
            // 
            this.label_changePasswordError.AutoSize = true;
            this.label_changePasswordError.ForeColor = System.Drawing.Color.Red;
            this.label_changePasswordError.Location = new System.Drawing.Point(12, 100);
            this.label_changePasswordError.Name = "label_changePasswordError";
            this.label_changePasswordError.Size = new System.Drawing.Size(0, 16);
            this.label_changePasswordError.TabIndex = 9;
            // 
            // tabPage_autoupdate
            // 
            this.tabPage_autoupdate.Controls.Add(this.label4);
            this.tabPage_autoupdate.Controls.Add(this.numericUpDown_autoupdate);
            this.tabPage_autoupdate.Controls.Add(this.checkBox_autoupdate);
            this.tabPage_autoupdate.Location = new System.Drawing.Point(4, 25);
            this.tabPage_autoupdate.Name = "tabPage_autoupdate";
            this.tabPage_autoupdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_autoupdate.Size = new System.Drawing.Size(427, 139);
            this.tabPage_autoupdate.TabIndex = 1;
            this.tabPage_autoupdate.Text = "Автообновление";
            this.tabPage_autoupdate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "сек.";
            // 
            // numericUpDown_autoupdate
            // 
            this.numericUpDown_autoupdate.Location = new System.Drawing.Point(18, 33);
            this.numericUpDown_autoupdate.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_autoupdate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_autoupdate.Name = "numericUpDown_autoupdate";
            this.numericUpDown_autoupdate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_autoupdate.TabIndex = 1;
            this.numericUpDown_autoupdate.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_autoupdate.ValueChanged += new System.EventHandler(this.numericUpDown_autoupdate_ValueChanged);
            // 
            // checkBox_autoupdate
            // 
            this.checkBox_autoupdate.AutoSize = true;
            this.checkBox_autoupdate.Location = new System.Drawing.Point(9, 7);
            this.checkBox_autoupdate.Name = "checkBox_autoupdate";
            this.checkBox_autoupdate.Size = new System.Drawing.Size(191, 20);
            this.checkBox_autoupdate.TabIndex = 0;
            this.checkBox_autoupdate.Text = "Автообновление данных";
            this.checkBox_autoupdate.UseVisualStyleBackColor = true;
            this.checkBox_autoupdate.CheckedChanged += new System.EventHandler(this.checkBox_autoupdate_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 168);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_profile.ResumeLayout(false);
            this.tabPage_profile.PerformLayout();
            this.tabPage_autoupdate.ResumeLayout(false);
            this.tabPage_autoupdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoupdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.TextBox textBox_changePassword_login;
        private System.Windows.Forms.TextBox textBox_changePassword_lastPassword;
        private System.Windows.Forms.TextBox textBox_changePassword_newPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_profile;
        private System.Windows.Forms.Label label_changePasswordError;
        private System.Windows.Forms.TabPage tabPage_autoupdate;
        private System.Windows.Forms.NumericUpDown numericUpDown_autoupdate;
        private System.Windows.Forms.CheckBox checkBox_autoupdate;
        private System.Windows.Forms.Label label4;
    }
}