using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WarehouseSystem
{
    public partial class AddEditElementForm : Form
    {
        static public Element el;
        static public bool isSave = false;
        private bool EditMode = false;

        public AddEditElementForm()
        {
            el = new Element();
            EditMode = false;
            INIT();
        }

        public AddEditElementForm(Element element)
        {
            el = element;
            EditMode = true;
            INIT();
        }

        private void INIT()
        {
            InitializeComponent();
            this.FormClosing += AddEditElementForm_FormClosing;
            isSave = false;
            label_error.Text = string.Empty;
            this.Text = EditMode ? $"Изменить элемент [id:{el.Id}  \"{Element.Dencode(el.Name)}]" : "Создать новый";

            dateTimePicker_delivery_date.Value = el.Delivery_date;
            dateTimePicker_production_date.Value = el.Production_date;
            textBox_name.Text = Element.Dencode(el.Name);
            textBox_description.Text = Element.Dencode(el.Description);
            textBox_manufacturer.Text = Element.Dencode(el.Manufacturer);
            textBox_provider.Text = Element.Dencode(el.Provider);
            textBox_imagePath.Text = Element.Dencode(el.ImagePath);
            comboBox_unit_measurement.Text = Element.Dencode(el.Unit_measurement);
            numericUpDown_quantity.Value = el.Quantity;
        }

        private void AddEditElementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                EditMode ? "Сохранить изменения?" : "Добавить новый элемент?",
                "Применить?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No) return;
            Apply();
        }

        private void button_apply_Click(object sender, EventArgs e) => Close();

        private void Apply()
        {
            if (CheckError(out string er))
            {
                MessageBox.Show(er, "Ой", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            el.Name = Element.Encode(textBox_name.Text);
            el.Description = Element.Encode(textBox_description.Text);
            el.Manufacturer = Element.Encode(textBox_manufacturer.Text); 
            el.Provider = Element.Encode(textBox_provider.Text); 
            el.ImagePath = Element.Encode(textBox_imagePath.Text);
            el.Unit_measurement = Element.Encode(comboBox_unit_measurement.Text);
            el.Quantity = (int)numericUpDown_quantity.Value;
            el.Production_date = dateTimePicker_production_date.Value;
            el.Delivery_date = dateTimePicker_delivery_date.Value;

            isSave = true;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e) => CheckError();

        private bool CheckError(out string error)
        {
            label_error.Text = string.Empty;
            bool isError = false;
            error = string.Empty;

            if (textBox_name.Text.Length < 5) {error = "Длинна названия должна быть не менее 5 символов."; label_error.Text = error; isError = true; }          

            return isError;
        }
        private bool CheckError()
        {
            string error = string.Empty;
            return CheckError(out error);
        }

        private void textBox_description_TextChanged(object sender, EventArgs e) => CheckError();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            textBox_imagePath.Text = dialog.FileName;
        }
    }
}
