namespace WarehouseSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox_elements = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_manufacturer = new System.Windows.Forms.Label();
            this.label_provider = new System.Windows.Forms.Label();
            this.label_production_date = new System.Windows.Forms.Label();
            this.label_delivery_date = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_sort_none = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_name = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_manufacturer = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_provider = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_quantity = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_production_date = new System.Windows.Forms.RadioButton();
            this.radioButton_sort_delivery_date = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBox_inver_sort = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripButton_addElement = new System.Windows.Forms.ToolStripButton();
            this.button_editElement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_removeElement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_find = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_updateElements = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_openSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_exitProfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_openSettingsProfile = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_elements
            // 
            this.listBox_elements.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_elements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_elements.FormattingEnabled = true;
            this.listBox_elements.ItemHeight = 16;
            this.listBox_elements.Location = new System.Drawing.Point(0, 0);
            this.listBox_elements.Name = "listBox_elements";
            this.listBox_elements.Size = new System.Drawing.Size(331, 607);
            this.listBox_elements.TabIndex = 0;
            this.listBox_elements.SelectedIndexChanged += new System.EventHandler(this.listBox_elements_SelectedIndexChanged);
            this.listBox_elements.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 100);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_addElement_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.button_editElement_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_removeElement_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_addElement,
            this.button_editElement,
            this.toolStripButton_removeElement,
            this.toolStripButton_find,
            this.toolStripButton_updateElements,
            this.toolStripSeparator1,
            this.toolStripButton_openSettings,
            this.toolStripButton_exitProfile,
            this.toolStripButton_openSettingsProfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1066, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 682);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox);
            this.flowLayoutPanel1.Controls.Add(this.label_name);
            this.flowLayoutPanel1.Controls.Add(this.label_count);
            this.flowLayoutPanel1.Controls.Add(this.label_manufacturer);
            this.flowLayoutPanel1.Controls.Add(this.label_provider);
            this.flowLayoutPanel1.Controls.Add(this.label_production_date);
            this.flowLayoutPanel1.Controls.Add(this.label_delivery_date);
            this.flowLayoutPanel1.Controls.Add(this.textBox_description);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 680);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(3, 375);
            this.label_name.Name = "label_name";
            this.label_name.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_name.Size = new System.Drawing.Size(57, 30);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(3, 405);
            this.label_count.Name = "label_count";
            this.label_count.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_count.Size = new System.Drawing.Size(41, 26);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "Count";
            // 
            // label_manufacturer
            // 
            this.label_manufacturer.AutoSize = true;
            this.label_manufacturer.Location = new System.Drawing.Point(3, 431);
            this.label_manufacturer.Name = "label_manufacturer";
            this.label_manufacturer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_manufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_manufacturer.Size = new System.Drawing.Size(111, 26);
            this.label_manufacturer.TabIndex = 9;
            this.label_manufacturer.Text = "Производитель";
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Location = new System.Drawing.Point(3, 457);
            this.label_provider.Name = "label_provider";
            this.label_provider.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_provider.Size = new System.Drawing.Size(57, 26);
            this.label_provider.TabIndex = 12;
            this.label_provider.Text = "provider";
            // 
            // label_production_date
            // 
            this.label_production_date.AutoSize = true;
            this.label_production_date.Location = new System.Drawing.Point(3, 483);
            this.label_production_date.Name = "label_production_date";
            this.label_production_date.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_production_date.Size = new System.Drawing.Size(104, 26);
            this.label_production_date.TabIndex = 13;
            this.label_production_date.Text = "production_date";
            // 
            // label_delivery_date
            // 
            this.label_delivery_date.AutoSize = true;
            this.label_delivery_date.Location = new System.Drawing.Point(3, 509);
            this.label_delivery_date.Name = "label_delivery_date";
            this.label_delivery_date.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_delivery_date.Size = new System.Drawing.Size(89, 36);
            this.label_delivery_date.TabIndex = 14;
            this.label_delivery_date.Text = "delivery_date";
            // 
            // textBox_description
            // 
            this.textBox_description.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_description.Location = new System.Drawing.Point(3, 548);
            this.textBox_description.MinimumSize = new System.Drawing.Size(677, 4);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_description.Size = new System.Drawing.Size(690, 134);
            this.textBox_description.TabIndex = 1;
            this.textBox_description.Text = "description";
            this.textBox_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_none);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_name);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_provider);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_quantity);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_manufacturer);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_production_date);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_sort_delivery_date);
            this.flowLayoutPanel2.Controls.Add(this.checkBox_inver_sort);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(331, 67);
            this.flowLayoutPanel2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.flowLayoutPanel2, "Сортировка");
            // 
            // radioButton_sort_none
            // 
            this.radioButton_sort_none.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_none.AutoSize = true;
            this.radioButton_sort_none.Checked = true;
            this.radioButton_sort_none.Location = new System.Drawing.Point(3, 3);
            this.radioButton_sort_none.Name = "radioButton_sort_none";
            this.radioButton_sort_none.Size = new System.Drawing.Size(42, 26);
            this.radioButton_sort_none.TabIndex = 2;
            this.radioButton_sort_none.TabStop = true;
            this.radioButton_sort_none.Text = "Нет";
            this.toolTip1.SetToolTip(this.radioButton_sort_none, "Без сортировки");
            this.radioButton_sort_none.UseVisualStyleBackColor = true;
            this.radioButton_sort_none.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_name
            // 
            this.radioButton_sort_name.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_name.AutoSize = true;
            this.radioButton_sort_name.Location = new System.Drawing.Point(51, 3);
            this.radioButton_sort_name.Name = "radioButton_sort_name";
            this.radioButton_sort_name.Size = new System.Drawing.Size(43, 26);
            this.radioButton_sort_name.TabIndex = 3;
            this.radioButton_sort_name.Text = "Имя";
            this.toolTip1.SetToolTip(this.radioButton_sort_name, "Сортировка по названию");
            this.radioButton_sort_name.UseVisualStyleBackColor = true;
            this.radioButton_sort_name.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_manufacturer
            // 
            this.radioButton_sort_manufacturer.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_manufacturer.AutoSize = true;
            this.radioButton_sort_manufacturer.Location = new System.Drawing.Point(224, 3);
            this.radioButton_sort_manufacturer.Name = "radioButton_sort_manufacturer";
            this.radioButton_sort_manufacturer.Size = new System.Drawing.Size(86, 26);
            this.radioButton_sort_manufacturer.TabIndex = 4;
            this.radioButton_sort_manufacturer.Text = "Производ.";
            this.toolTip1.SetToolTip(this.radioButton_sort_manufacturer, "Сортировка по производителю");
            this.radioButton_sort_manufacturer.UseVisualStyleBackColor = true;
            this.radioButton_sort_manufacturer.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_provider
            // 
            this.radioButton_sort_provider.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_provider.AutoSize = true;
            this.radioButton_sort_provider.Location = new System.Drawing.Point(100, 3);
            this.radioButton_sort_provider.Name = "radioButton_sort_provider";
            this.radioButton_sort_provider.Size = new System.Drawing.Size(68, 26);
            this.radioButton_sort_provider.TabIndex = 5;
            this.radioButton_sort_provider.Text = "Постав.";
            this.toolTip1.SetToolTip(this.radioButton_sort_provider, "Сортировка по поставщикам");
            this.radioButton_sort_provider.UseVisualStyleBackColor = true;
            this.radioButton_sort_provider.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_quantity
            // 
            this.radioButton_sort_quantity.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_quantity.AutoSize = true;
            this.radioButton_sort_quantity.Location = new System.Drawing.Point(174, 3);
            this.radioButton_sort_quantity.Name = "radioButton_sort_quantity";
            this.radioButton_sort_quantity.Size = new System.Drawing.Size(44, 26);
            this.radioButton_sort_quantity.TabIndex = 6;
            this.radioButton_sort_quantity.Text = "Кол.";
            this.toolTip1.SetToolTip(this.radioButton_sort_quantity, "Сортировка по количеству");
            this.radioButton_sort_quantity.UseVisualStyleBackColor = true;
            this.radioButton_sort_quantity.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_production_date
            // 
            this.radioButton_sort_production_date.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_production_date.AutoSize = true;
            this.radioButton_sort_production_date.Location = new System.Drawing.Point(3, 35);
            this.radioButton_sort_production_date.Name = "radioButton_sort_production_date";
            this.radioButton_sort_production_date.Size = new System.Drawing.Size(119, 26);
            this.radioButton_sort_production_date.TabIndex = 7;
            this.radioButton_sort_production_date.Text = "Дата производ.";
            this.toolTip1.SetToolTip(this.radioButton_sort_production_date, "Сортировка по дате производства");
            this.radioButton_sort_production_date.UseVisualStyleBackColor = true;
            this.radioButton_sort_production_date.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // radioButton_sort_delivery_date
            // 
            this.radioButton_sort_delivery_date.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_sort_delivery_date.AutoSize = true;
            this.radioButton_sort_delivery_date.Location = new System.Drawing.Point(128, 35);
            this.radioButton_sort_delivery_date.Name = "radioButton_sort_delivery_date";
            this.radioButton_sort_delivery_date.Size = new System.Drawing.Size(101, 26);
            this.radioButton_sort_delivery_date.TabIndex = 8;
            this.radioButton_sort_delivery_date.Text = "Дата постав.";
            this.toolTip1.SetToolTip(this.radioButton_sort_delivery_date, "Сортировка по дате поставки");
            this.radioButton_sort_delivery_date.UseVisualStyleBackColor = true;
            this.radioButton_sort_delivery_date.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel1MinSize = 65;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox_elements);
            this.splitContainer2.Size = new System.Drawing.Size(333, 682);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 2;
            // 
            // checkBox_inver_sort
            // 
            this.checkBox_inver_sort.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_inver_sort.AutoSize = true;
            this.checkBox_inver_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox_inver_sort.BackgroundImage = global::WarehouseSystem.Properties.Resources.inSort;
            this.checkBox_inver_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox_inver_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_inver_sort.Location = new System.Drawing.Point(235, 35);
            this.checkBox_inver_sort.MinimumSize = new System.Drawing.Size(25, 25);
            this.checkBox_inver_sort.Name = "checkBox_inver_sort";
            this.checkBox_inver_sort.Size = new System.Drawing.Size(25, 25);
            this.checkBox_inver_sort.TabIndex = 0;
            this.toolTip1.SetToolTip(this.checkBox_inver_sort, "Обратная сортировка");
            this.checkBox_inver_sort.UseVisualStyleBackColor = false;
            this.checkBox_inver_sort.CheckedChanged += new System.EventHandler(this.checkBox_inver_sort_CheckedChanged);
            this.checkBox_inver_sort.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(690, 369);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // toolStripButton_addElement
            // 
            this.toolStripButton_addElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_addElement.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addElement.Image")));
            this.toolStripButton_addElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addElement.Name = "toolStripButton_addElement";
            this.toolStripButton_addElement.Size = new System.Drawing.Size(80, 28);
            this.toolStripButton_addElement.Text = "Добавить";
            this.toolStripButton_addElement.Click += new System.EventHandler(this.toolStripButton_addElement_Click);
            // 
            // button_editElement
            // 
            this.button_editElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_editElement.Enabled = false;
            this.button_editElement.Image = ((System.Drawing.Image)(resources.GetObject("button_editElement.Image")));
            this.button_editElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_editElement.Name = "button_editElement";
            this.button_editElement.Size = new System.Drawing.Size(82, 28);
            this.button_editElement.Text = "Изменить";
            this.button_editElement.Click += new System.EventHandler(this.button_editElement_Click);
            // 
            // toolStripButton_removeElement
            // 
            this.toolStripButton_removeElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_removeElement.Enabled = false;
            this.toolStripButton_removeElement.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_removeElement.Image")));
            this.toolStripButton_removeElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_removeElement.Name = "toolStripButton_removeElement";
            this.toolStripButton_removeElement.Size = new System.Drawing.Size(69, 28);
            this.toolStripButton_removeElement.Text = "Удалить";
            this.toolStripButton_removeElement.Click += new System.EventHandler(this.toolStripButton_removeElement_Click);
            // 
            // toolStripButton_find
            // 
            this.toolStripButton_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_find.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_find.Image")));
            this.toolStripButton_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_find.Name = "toolStripButton_find";
            this.toolStripButton_find.Size = new System.Drawing.Size(56, 28);
            this.toolStripButton_find.Text = "Поиск";
            this.toolStripButton_find.Click += new System.EventHandler(this.toolStripButton_Find_Click);
            // 
            // toolStripButton_updateElements
            // 
            this.toolStripButton_updateElements.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_updateElements.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_updateElements.Image")));
            this.toolStripButton_updateElements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_updateElements.Name = "toolStripButton_updateElements";
            this.toolStripButton_updateElements.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton_updateElements.Text = "Обновить";
            this.toolStripButton_updateElements.Click += new System.EventHandler(this.toolStripButton_updateElements_Click);
            // 
            // toolStripButton_openSettings
            // 
            this.toolStripButton_openSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_openSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openSettings.Image")));
            this.toolStripButton_openSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openSettings.Name = "toolStripButton_openSettings";
            this.toolStripButton_openSettings.Size = new System.Drawing.Size(88, 28);
            this.toolStripButton_openSettings.Text = "Настройки";
            this.toolStripButton_openSettings.Click += new System.EventHandler(this.toolStripButton_openSettings_Click);
            // 
            // toolStripButton_exitProfile
            // 
            this.toolStripButton_exitProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_exitProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_exitProfile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_exitProfile.Image")));
            this.toolStripButton_exitProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exitProfile.Name = "toolStripButton_exitProfile";
            this.toolStripButton_exitProfile.Size = new System.Drawing.Size(57, 28);
            this.toolStripButton_exitProfile.Text = "Выйти";
            this.toolStripButton_exitProfile.Click += new System.EventHandler(this.toolStripButton_exitProfile_Click);
            // 
            // toolStripButton_openSettingsProfile
            // 
            this.toolStripButton_openSettingsProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_openSettingsProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_openSettingsProfile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openSettingsProfile.Image")));
            this.toolStripButton_openSettingsProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openSettingsProfile.Name = "toolStripButton_openSettingsProfile";
            this.toolStripButton_openSettingsProfile.Size = new System.Drawing.Size(77, 28);
            this.toolStripButton_openSettingsProfile.Text = "Профиль";
            this.toolStripButton_openSettingsProfile.Click += new System.EventHandler(this.toolStripButton_openSettingsProfile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 713);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление складом";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_elements;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_addElement;
        private System.Windows.Forms.ToolStripButton toolStripButton_removeElement;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton_updateElements;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton_openSettingsProfile;
        private System.Windows.Forms.Label label_manufacturer;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.ToolStripButton button_editElement;
        private System.Windows.Forms.Label label_production_date;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.Label label_delivery_date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_exitProfile;
        private System.Windows.Forms.ToolStripButton toolStripButton_openSettings;
        private System.Windows.Forms.ToolStripButton toolStripButton_find;
        private System.Windows.Forms.CheckBox checkBox_inver_sort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_sort_none;
        private System.Windows.Forms.RadioButton radioButton_sort_name;
        private System.Windows.Forms.RadioButton radioButton_sort_manufacturer;
        private System.Windows.Forms.RadioButton radioButton_sort_provider;
        private System.Windows.Forms.RadioButton radioButton_sort_quantity;
        private System.Windows.Forms.RadioButton radioButton_sort_production_date;
        private System.Windows.Forms.RadioButton radioButton_sort_delivery_date;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}