using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YYY
{
    class SellerClass
    {
        private string name;
        private string surname;
        private string patronymic;
        private int experience;
        private ulong phone;
        private string password;
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
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
        public ulong Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static DataTable ShowInfo(int number)
        {
            DataTable seller_table = new DataTable();
            seller_table.Columns.Add("Номер", typeof(int));
            seller_table.Columns.Add("Имя", typeof(string));
            seller_table.Columns.Add("Фамилия", typeof(string));
            seller_table.Columns.Add("Отчество", typeof(string));
            seller_table.Columns.Add("Стаж", typeof(int));
            seller_table.Columns.Add("Номер телефона", typeof(ulong));
            seller_table.Columns.Add("Пароль", typeof(string));
            seller_table.Rows.Add(number + 1, StaticProduct.sellers[number].Name, StaticProduct.sellers[number].Surname, StaticProduct.sellers[number].Patronymic, StaticProduct.sellers[number].Experience, StaticProduct.sellers[number].Phone, StaticProduct.sellers[number].Password);
            return seller_table;
        }
        public SellerClass (string name, string surname, string patronymic,  int experience, ulong phone, string password)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Experience = experience;
            Phone = phone;
            Password = password;
        }
    }
}
