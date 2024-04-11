using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class Find_Form : Form
    {
        private List<Element> elements = new List<Element>();
        private List<Element> elF = new List<Element>();
        public static int FindElementIndex = -1;

        public Find_Form(List<Element> elements)
        {
            InitializeComponent();
            this.FormClosing += FindForm_FormClosing;
            this.elements = elements;
            button_open.Enabled = false;
            FindElementIndex = -1;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < elF.Count; i++)
            {
                elF[i].Dispose();
                elF[i] = null;
            }
            elF.Clear();
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if(
                !checkBox_findName.Checked &&
                !checkBox_find_description.Checked &&
                !checkBox_find_manufacturer.Checked &&
                !checkBox_find_provider.Checked
                )
            {
                MessageBox.Show("Выберите поля для поиска!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_findStr.Text))
            {
                MessageBox.Show("Введите ключевое выражение!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            button_open.Enabled = false;
            listBox_find.Items.Clear();
            elF.Clear();

            foreach (var i in elements)
            {
                //Console.WriteLine(Element.Dencode(i.Name));
                if (
                    ((Element.Dencode(i.Name).ToLower().Contains(textBox_findStr.Text.ToLower()) && checkBox_findName.Checked)) ||
                    ((Element.Dencode(i.Description).ToLower().Contains(textBox_findStr.Text.ToLower()) && checkBox_find_description.Checked)) ||
                    ((Element.Dencode(i.Manufacturer).ToLower().Contains(textBox_findStr.Text.ToLower()) && checkBox_find_manufacturer.Checked)) ||
                    ((Element.Dencode(i.Provider).ToLower().Contains(textBox_findStr.Text.ToLower()) && checkBox_find_provider.Checked)) 
                    )elF.Add(i);
            }
            
            if(elF.Count < 1)
            {
                MessageBox.Show("Ничего не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(var i in elF) listBox_find.Items.Add($"ID:{i.Id} {Element.Dencode(i.Name)}");          
        }

        private void button_open_Click(object sender, EventArgs e)
        {          
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Id == elF[listBox_find.SelectedIndex].Id) FindElementIndex = i;
            }
            Close();
        }

        private void listBox_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_find.SelectedIndex != -1) button_open.Enabled = true;
        }
    }
}
