using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YYY
{
    class Cash
    {
        int number;
        private string name;
        private string date;
        private float money;
       
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
        public float Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public static DataTable ShowInfo(int number)
        {
            DataTable cash_table = new DataTable();
            cash_table.Columns.Add("Номер", typeof(int));
            cash_table.Columns.Add("Имя", typeof(string));
            cash_table.Columns.Add("Дата", typeof(string));
            cash_table.Columns.Add("Прибыль", typeof(float));
            cash_table.Rows.Add(StaticProduct.cashs[number].Number, StaticProduct.cashs[number].Name, StaticProduct.cashs[number].Date, StaticProduct.cashs[number].Money);
            return cash_table;
        }
        public Cash(int number, string name, string date, float money)
        {
            Number = number;
            Name = name;
            Date = date;
            Money = money;
        }
    }
}
