using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YYY
{
    class Product
    {
        private int id;
        private string name;
        private float price;
        private int amount;
        private string carrier;
        private string category;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string Сarrier
        {
            get
            {
                return carrier;
            }
            set
            {
                carrier = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public static DataTable ShowInfo(int number)
        {
            DataTable product_table = new DataTable();
            product_table.Columns.Add("Номер", typeof(int));
            product_table.Columns.Add("Артикул", typeof(int));
            product_table.Columns.Add("Название", typeof(string));
            product_table.Columns.Add("Цена", typeof(float));
            product_table.Columns.Add("Количество", typeof(int));
            product_table.Columns.Add("Носитель", typeof(string));
            product_table.Columns.Add("Категория", typeof(string));
            product_table.Rows.Add(number + 1, StaticProduct.products[number].Id, StaticProduct.products[number].Name, StaticProduct.products[number].Price, StaticProduct.products[number].Amount, StaticProduct.products[number].Сarrier, StaticProduct.products[number].Category);
            return product_table;
        }
        
        public Product(int id, string name, float price,int amount, string carrier, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
            Сarrier = carrier;
            Category = category;
        }

    }
}
