namespace WarehouseSystem
{
    partial class Find_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Form));
            this.textBox_findStr = new System.Windows.Forms.TextBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.checkBox_findName = new System.Windows.Forms.CheckBox();
            this.checkBox_find_manufacturer = new System.Windows.Forms.CheckBox();
            this.checkBox_find_provider = new System.Windows.Forms.CheckBox();
            this.checkBox_find_description = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_find = new System.Windows.Forms.ListBox();
            this.button_open = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_findStr
            // 
            this.textBox_findStr.Location = new System.Drawing.Point(13, 13);
            this.textBox_findStr.Name = "textBox_findStr";
            this.textBox_findStr.Size = new System.Drawing.Size(492, 22);
            this.textBox_findStr.TabIndex = 0;
            // 
            // button_Find
            // 
            this.button_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Find.Location = new System.Drawing.Point(512, 10);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(87, 29);
            this.button_Find.TabIndex = 1;
            this.button_Find.Text = "Поиск";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // checkBox_findName
            // 
            this.checkBox_findName.AutoSize = true;
            this.checkBox_findName.Checked = true;
            this.checkBox_findName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_findName.Location = new System.Drawing.Point(6, 21);
            this.checkBox_findName.Name = "checkBox_findName";
            this.checkBox_findName.Size = new System.Drawing.Size(95, 20);
            this.checkBox_findName.TabIndex = 2;
            this.checkBox_findName.Text = "Название";
            this.checkBox_findName.UseVisualStyleBackColor = true;
            // 
            // checkBox_find_manufacturer
            // 
            this.checkBox_find_manufacturer.AutoSize = true;
            this.checkBox_find_manufacturer.Checked = true;
            this.checkBox_find_manufacturer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_find_manufacturer.Location = new System.Drawing.Point(6, 47);
            this.checkBox_find_manufacturer.Name = "checkBox_find_manufacturer";
            this.checkBox_find_manufacturer.Size = new System.Drawing.Size(133, 20);
            this.checkBox_find_manufacturer.TabIndex = 3;
            this.checkBox_find_manufacturer.Text = "Производитель";
            this.checkBox_find_manufacturer.UseVisualStyleBackColor = true;
            // 
            // checkBox_find_provider
            // 
            this.checkBox_find_provider.AutoSize = true;
            this.checkBox_find_provider.Checked = true;
            this.checkBox_find_provider.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_find_provider.Location = new System.Drawing.Point(6, 73);
            this.checkBox_find_provider.Name = "checkBox_find_provider";
            this.checkBox_find_provider.Size = new System.Drawing.Size(101, 20);
            this.checkBox_find_provider.TabIndex = 4;
            this.checkBox_find_provider.Text = "Поставщик";
            this.checkBox_find_provider.UseVisualStyleBackColor = true;
            // 
            // checkBox_find_description
            // 
            this.checkBox_find_description.AutoSize = true;
            this.checkBox_find_description.Checked = true;
            this.checkBox_find_description.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_find_description.Location = new System.Drawing.Point(7, 99);
            this.checkBox_find_description.Name = "checkBox_find_description";
            this.checkBox_find_description.Size = new System.Drawing.Size(94, 20);
            this.checkBox_find_description.TabIndex = 5;
            this.checkBox_find_description.Text = "Описание";
            this.checkBox_find_description.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_findName);
            this.groupBox1.Controls.Add(this.checkBox_find_description);
            this.groupBox1.Controls.Add(this.checkBox_find_manufacturer);
            this.groupBox1.Controls.Add(this.checkBox_find_provider);
            this.groupBox1.Location = new System.Drawing.Point(452, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по";
            // 
            // listBox_find
            // 
            this.listBox_find.FormattingEnabled = true;
            this.listBox_find.ItemHeight = 16;
            this.listBox_find.Location = new System.Drawing.Point(13, 57);
            this.listBox_find.Name = "listBox_find";
            this.listBox_find.Size = new System.Drawing.Size(433, 324);
            this.listBox_find.TabIndex = 7;
            this.listBox_find.SelectedIndexChanged += new System.EventHandler(this.listBox_find_SelectedIndexChanged);
            // 
            // button_open
            // 
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Location = new System.Drawing.Point(496, 336);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(103, 45);
            this.button_open.TabIndex = 8;
            this.button_open.Text = "Открыть";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // Find_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 390);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.listBox_find);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.textBox_findStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_findStr;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.CheckBox checkBox_findName;
        private System.Windows.Forms.CheckBox checkBox_find_manufacturer;
        private System.Windows.Forms.CheckBox checkBox_find_provider;
        private System.Windows.Forms.CheckBox checkBox_find_description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_find;
        private System.Windows.Forms.Button button_open;
    }
}