using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WarehouseSystem
{
    public class Element
    {
        private DateTime _lastTimeUpdate;
        public double lastTimeUpdate { get => (DateTime.Now - _lastTimeUpdate).TotalSeconds; }
        public bool isFull = false;

        private int id;
        private string name;
        private string description;
        private string manufacturer;
        private int quantity;
        private DateTime delivery_date;
        private string provider;
        private DateTime production_date;
        private string imagePath;
        private string unit_measurement;
        public Image Image;

        public int Id { get => id; set => id = value; }
        public string Name { set { name = value; Update(); } get => name; }
        public string Description { set { description = value; Update(); } get => description; }
        public string Manufacturer { set { manufacturer = value; Update(); } get => manufacturer; }
        public int Quantity { set { quantity = value; Update(); } get => quantity; }
        public DateTime Production_date { get => production_date; set { production_date = value; Update(); } }
        public string Provider { get => provider; set { provider = value; Update(); } }
        public DateTime Delivery_date { get => delivery_date; set { delivery_date = value; Update(); } }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Unit_measurement { get => unit_measurement; set { unit_measurement = value; Update(); } }

        public Element(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            _lastTimeUpdate = DateTime.Now;
        }
        public Element(int id, string name, string description, string manufacturer, int quantity, string provider, DateTime delivery_date, DateTime production_date)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Manufacturer = manufacturer;
            this.Quantity = quantity;
            this.Provider = provider;
            this.Delivery_date = delivery_date;
            this.Production_date = production_date;
            isFull = true;
            _lastTimeUpdate = DateTime.Now;
        }
        public Element()
        {
            name = string.Empty;
            description = string.Empty;
            manufacturer = string.Empty;
            quantity = 0;
            provider = string.Empty;
            delivery_date = DateTime.Now;
            production_date = DateTime.Now;
            imagePath = string.Empty;
            unit_measurement = Encode("шт.");
        }

        private void Update()
        {
            isFull = true;
            _lastTimeUpdate = DateTime.Now;
        }

        public void Dispose(){
            if (Image != null) Image.Dispose();
            name = string.Empty;
            description = string.Empty;
            manufacturer = string.Empty;
            provider = string.Empty;
            imagePath = string.Empty;
            unit_measurement = string.Empty;
        }

        static public string Encode(string str)
        {
            string res = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                res += $"%{(int)str[i]}";
            }
            return res;
        }
        static public string Dencode(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return "";
            string res = string.Empty;
            List<string> list = str.Split('%').ToList();
            list.RemoveAt(0);
            foreach (string i in list)
            {
                res += (char)(int.Parse(i));
            }
            return res;
        }
    }
}
