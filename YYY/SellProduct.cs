using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YYY
{
    class SellProduct
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
            DataTable sell_product_table = new DataTable();
            sell_product_table.Columns.Add("Номер", typeof(int));
            sell_product_table.Columns.Add("Артикул", typeof(int));
            sell_product_table.Columns.Add("Название", typeof(string));
            sell_product_table.Columns.Add("Цена", typeof(float));
            sell_product_table.Columns.Add("Количество", typeof(int));
            sell_product_table.Columns.Add("Носитель", typeof(string));
            sell_product_table.Columns.Add("Категория", typeof(string));
            sell_product_table.Rows.Add(number + 1, StaticProduct.sellproducts[number].Id, StaticProduct.sellproducts[number].Name, StaticProduct.sellproducts[number].Price, StaticProduct.sellproducts[number].Amount, StaticProduct.sellproducts[number].Сarrier, StaticProduct.sellproducts[number].Category);
            return sell_product_table;
        }

        public SellProduct(int id, string name, float price, int amount, string carrier, string category)
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
