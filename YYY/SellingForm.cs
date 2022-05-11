using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace YYY
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
            label_date.Text = DateTime.Today.ToShortDateString();
            label_name_seller.Text = StaticProduct.name_seller;
            DataTable product_table = new DataTable();
            for (int u = 0; u < StaticProduct.count_product; u++)
            {
                product_table.Merge(Product.ShowInfo(u));
            }
            dataGridView_product.DataSource = product_table;
            DataTable sell_product_table = new DataTable();
            for (int u = 0; u < StaticProduct.count_sell_product; u++)
            {
                sell_product_table.Merge(SellProduct.ShowInfo(u));
            }
            dataGridView_sell_product.DataSource = sell_product_table;
            DataTable cash_table = new DataTable();
            for (int u = 0; u < StaticProduct.count_cash; u++)
            {
                cash_table.Merge(Cash.ShowInfo(u));
            }
            dataGridView_cash.DataSource = cash_table;
        }

        int uber_row_index = -1;
        private void Button_search_Click(object sender, EventArgs e)
        {
            if (StaticProduct.count_product == 0)
            {
                MessageBox.Show("Склад пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ComboBox_search.Text == "")
                {
                    MessageBox.Show("Вы не выбрали по какому параметру необходимо искать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TextBox_search.Text == "" && ComboBox_search.Text == "Показать все")

                    {
                        DataTable product_table = new DataTable();
                        for (int u = 0; u < StaticProduct.count_product; u++)
                        {
                            product_table.Merge(Product.ShowInfo(u));
                        }
                        dataGridView_product.DataSource = product_table;
                        TextBox_search.Clear();
                        ComboBox_search.SelectedIndex = -1;
                    }
                    else
                    {
                        if (TextBox_search.Text == "")

                        {
                            MessageBox.Show("Вы не выбрали по какому параметр для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (ComboBox_search.Text == "Артикул")
                            {
                                int id;
                                bool flag;
                                flag = int.TryParse(TextBox_search.Text, out id);
                                if ((flag && id > 0) && (id >= 10000) && (id <= 99999))
                                {
                                    int i = 0, i1 = 0;
                                    DataTable product_table = new DataTable();
                                    while (i < StaticProduct.count_product)
                                    {
                                        if (id == StaticProduct.products[i].Id)
                                        {
                                            product_table.Merge(Product.ShowInfo(i));
                                            i1++;
                                        }
                                        i++;
                                    }
                                    if (i1 == 0)
                                    {
                                        MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    dataGridView_product.DataSource = product_table;
                                    TextBox_search.Clear();
                                    ComboBox_search.SelectedIndex = -1;

                                }

                                else
                                {
                                    TextBox_search.Clear();
                                    MessageBox.Show("Вы ввели некорректное значение артикула товара.  Артикул товара должен состоять из пяти цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (ComboBox_search.Text == "Цена")
                                {
                                    bool flag;
                                    float price;
                                    flag = float.TryParse(TextBox_search.Text, out price);
                                    if ((flag && price > 0) && (price >= 0) && (price <= 10000000))
                                    {
                                        int i = 0, i1 = 0;
                                        DataTable product_table = new DataTable();
                                        while (i < StaticProduct.count_product)
                                        {
                                            if (price == StaticProduct.products[i].Price)
                                            {
                                                product_table.Merge(Product.ShowInfo(i));
                                                i1++;
                                            }
                                            i++;
                                        }
                                        if (i1 == 0)
                                        {
                                            MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        dataGridView_product.DataSource = product_table;
                                        TextBox_search.Clear();
                                        ComboBox_search.SelectedIndex = -1;
                                    }
                                    else
                                    {
                                        TextBox_search.Clear();
                                        MessageBox.Show("Вы ввели некорректное значение цены товара. Цена товара не может превышать 10 миллионов рублей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    if (ComboBox_search.Text == "Количество")
                                    {
                                        bool flag;
                                        int amount;
                                        flag = int.TryParse(TextBox_search.Text, out amount);
                                        if ((flag && amount > 0) && (amount >= 1) && (amount <= 99999))
                                        {
                                            int i = 0, i1 = 0;
                                            DataTable product_table = new DataTable();
                                            while (i < StaticProduct.count_product)
                                            {
                                                if (amount == StaticProduct.products[i].Amount)
                                                {
                                                    product_table.Merge(Product.ShowInfo(i));
                                                    i1++;
                                                }
                                                i++;
                                            }
                                            if (i1 == 0)
                                            {
                                                MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            dataGridView_product.DataSource = product_table;
                                            TextBox_search.Clear();
                                            ComboBox_search.SelectedIndex = -1;
                                        }
                                        else
                                        {
                                            TextBox_search.Clear();
                                            MessageBox.Show("Вы ввели некорректное значение количества товара. Количеством товара должно быть числом от 1 до 99999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {

                                        if (ComboBox_search.Text == "Название")
                                        {
                                            string name, name1;
                                            name = TextBox_search.Text;
                                            name = name.ToLower();
                                            name = name.Replace(" ", "");
                                            int i = 0, i1 = 0;
                                            DataTable product_table = new DataTable();
                                            while (i < StaticProduct.count_product)
                                            {
                                                name1 = StaticProduct.products[i].Name.ToLower();
                                                name1 = name1.Replace(" ", "");
                                                if (name == name1)
                                                {
                                                    product_table.Merge(Product.ShowInfo(i));
                                                    i1++;
                                                }
                                                i++;
                                            }
                                            if (i1 == 0)
                                            {
                                                MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }

                                            dataGridView_product.DataSource = product_table;
                                            TextBox_search.Clear();
                                            ComboBox_search.SelectedIndex = -1;
                                        }
                                        else
                                        {
                                            if (ComboBox_search.Text == "Носитель")
                                            {
                                                string carrier, carrier1;
                                                carrier = TextBox_search.Text;
                                                carrier = carrier.ToLower();
                                                carrier = carrier.Replace(" ", "");
                                                if (carrier == "blu-ray" || carrier == "dvd" || carrier == "cd" || carrier == "кассеты")
                                                {
                                                    int i = 0, i1 = 0;
                                                    DataTable product_table = new DataTable();
                                                    while (i < StaticProduct.count_product)
                                                    {
                                                        carrier1 = StaticProduct.products[i].Сarrier.ToLower();
                                                        carrier1 = carrier1.Replace(" ", "");
                                                        if (carrier == carrier1)
                                                        {
                                                            product_table.Merge(Product.ShowInfo(i));
                                                            i1++;
                                                        }
                                                        i++;
                                                    }
                                                    if (i1 == 0)
                                                    {
                                                        MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }

                                                    dataGridView_product.DataSource = product_table;
                                                    TextBox_search.Clear();
                                                    ComboBox_search.SelectedIndex = -1;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Введено неккоректное название носителя информации. На складе могут находиться товары на читерех видах носителей: Blu-ray, DVD, CD и Кассеты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                if (ComboBox_search.Text == "Категория")
                                                {
                                                    string category, category1;
                                                    category = TextBox_search.Text;
                                                    category = category.ToLower();
                                                    category = category.Replace(" ", "");
                                                    if (category == "аудиопродукция" || category == "видеопродукция" || category == "софт" || category == "игры")
                                                    {
                                                        int i = 0, i1 = 0;
                                                        DataTable product_table = new DataTable();
                                                        while (i < StaticProduct.count_product)
                                                        {
                                                            category1 = StaticProduct.products[i].Category.ToLower();
                                                            category1 = category1.Replace(" ", "");
                                                            if (category == category1)
                                                            {
                                                                product_table.Merge(Product.ShowInfo(i));
                                                                i1++;
                                                            }
                                                            i++;
                                                        }
                                                        if (i1 == 0)
                                                        {
                                                            MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }

                                                        dataGridView_product.DataSource = product_table;
                                                        TextBox_search.Clear();
                                                        ComboBox_search.SelectedIndex = -1;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Введено неккоректное название категории товара. На складе могут находиться товары четырех категорий: Аудиопродукция, Видеопродукция, Софт и Игры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    if (ComboBox_search.Text == "Номер")
                                                    {
                                                        bool flag;
                                                        int number;
                                                        flag = int.TryParse(TextBox_search.Text, out number);
                                                        if ((flag && number > 0) && (number >= 1) && (number <= StaticProduct.count_product))
                                                        {
                                                            int i = 0, i1 = 0;
                                                            DataTable product_table = new DataTable();
                                                            while (i < StaticProduct.count_product)
                                                            {
                                                                if (number == (i + 1))
                                                                {
                                                                    product_table.Merge(Product.ShowInfo(i));
                                                                    i1++;
                                                                }
                                                                i++;
                                                            }
                                                            if (i1 == 0)
                                                            {
                                                                MessageBox.Show("Таких товаров на складе нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            dataGridView_product.DataSource = product_table;
                                                            TextBox_search.Clear();
                                                            ComboBox_search.SelectedIndex = -1;
                                                        }
                                                        else
                                                        {
                                                            TextBox_search.Clear();
                                                            MessageBox.Show("Вы ввели некорректное значение номера товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }

                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_product_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            uber_row_index = e.RowIndex;
        }

        private void Button_sell_Click(object sender, EventArgs e)
        {
            if (StaticProduct.count_sell_product == 0)
            {
                MessageBox.Show("Чек пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (StaticProduct.count_cash < StaticProduct.number_cash_count)
                {
                    string name = StaticProduct.name_seller;
                int number = StaticProduct.number_seller;
                string date = DateTime.Today.ToShortDateString();
                float money = 0;
                int count_sell_product = StaticProduct.count_sell_product;
                    StaticProduct.number_chek++;
                    string path = Path.GetFullPath("check" + StaticProduct.number_chek + ".txt");
                    FileInfo file = new FileInfo(path);
                    if (!file.Exists)
                    {

                        using (StreamWriter sw = file.CreateText())
                        {
                            double t;
                            string text1;
                            string text = "Кассовый чек";
                            text = text.PadLeft((90 - text.Length) / 2 + text.Length, ' ');
                            sw.WriteLine(text);
                            sw.WriteLine("Наименование                            Количество                            Сумма");
                            for (int u = 0; u < count_sell_product; u++)
                            {
                                text = StaticProduct.sellproducts[u].Amount.ToString();
                                text = text.PadLeft((40 + StaticProduct.sellproducts[u].Amount.ToString().Length - StaticProduct.sellproducts[u].Name.Length), ' ');

                                t = Math.Round((StaticProduct.sellproducts[u].Amount * StaticProduct.sellproducts[u].Price), 2);
                                text1 = "" + t;
                                text1 = text1.PadLeft((45 - StaticProduct.sellproducts[u].Amount.ToString().Length - StaticProduct.sellproducts[u].Amount.ToString().Length), ' ');
                                sw.WriteLine(StaticProduct.sellproducts[u].Name + text + text1);
                                money = money + StaticProduct.sellproducts[u].Amount * StaticProduct.sellproducts[u].Price;
                                Math.Round(money, 2);
                            }
                            sw.WriteLine("-----------------------------------------------------------------------------------");
                            sw.WriteLine("Итого:                                                                        " + Math.Round(money, 2));
                            sw.WriteLine("Дата:" + date + "                                                      Продавец:" + name);
                        
                        }
                    }
                    for (int u = 0; u < count_sell_product; u++)
                {
                    money = money + StaticProduct.sellproducts[u].Amount * StaticProduct.sellproducts[u].Price;
                    Math.Round(money, 2);
                    StaticProduct.sellproducts[u] = StaticProduct.sellproducts[u + 1];
                    StaticProduct.count_sell_product--;
                }
                
                    if (StaticProduct.count_cash > 0)
                    {
                        int i = 0;
                        for (int u = 0; u < StaticProduct.count_cash; u++)
                        {
                            if (StaticProduct.cashs[u].Number == number)
                            {
                                StaticProduct.cashs[u].Money = StaticProduct.cashs[u].Money + money;
                                i++;
                            }
                        }
                        if (i == 0)
                        {
                            StaticProduct.cashs[StaticProduct.count_cash] = new Cash(number, name, date, money);
                            StaticProduct.count_cash++;
                        }
                    }
                    else
                    {
                        StaticProduct.cashs[StaticProduct.count_cash] = new Cash(number, name, date, money);
                        StaticProduct.count_cash++;
                    }
                    DataTable cash_table = new DataTable();
                    for (int u = 0; u < StaticProduct.count_cash; u++)
                    {
                        cash_table.Merge(Cash.ShowInfo(u));
                    }
                    dataGridView_cash.DataSource = cash_table;
                    dataGridView_sell_product.DataSource = new object();
                    string fpath = path;
                    Process proc = Process.Start("notepad.exe", fpath);
                    proc.WaitForExit();
                    proc.Close();
                }
                else
                {
                    MessageBox.Show("Таблица переполненна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
    

        private void Button_create_Click(object sender, EventArgs e)
        {
            int amount;
            bool flag;
            flag = int.TryParse(TextBox_amount.Text, out amount);
            if ((flag && amount > 0) && (amount >= 1) && (amount <= 99999))
            {
                if (uber_row_index == -1)
                {
                    MessageBox.Show("Вы не выбрали строку в таблице.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (StaticProduct.count_product == 0)
                    {
                        MessageBox.Show("Склад пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (amount< StaticProduct.products[uber_row_index].Amount)
                        {
                            StaticProduct.products[uber_row_index].Amount = StaticProduct.products[uber_row_index].Amount - amount;
                            StaticProduct.sellproducts[StaticProduct.count_sell_product] = new SellProduct(StaticProduct.products[uber_row_index].Id, StaticProduct.products[uber_row_index].Name, StaticProduct.products[uber_row_index].Price, amount, StaticProduct.products[uber_row_index].Сarrier,StaticProduct.products[uber_row_index].Category);
                            StaticProduct.count_sell_product++;
                            DataTable product_table = new DataTable();
                            for (int u = 0; u < StaticProduct.count_product; u++)
                            {
                                product_table.Merge(Product.ShowInfo(u));
                            }
                            dataGridView_product.DataSource = product_table;
                            DataTable sell_product_table = new DataTable();
                            for (int u = 0; u < StaticProduct.count_sell_product; u++)
                            {
                                sell_product_table.Merge(SellProduct.ShowInfo(u));
                            }
                            dataGridView_sell_product.DataSource = sell_product_table;
                            TextBox_amount.Clear();
                        }
                        else
                        {
                            if (amount == StaticProduct.products[uber_row_index].Amount)
                            {
                                int count_product = StaticProduct.count_product;
                                StaticProduct.sellproducts[StaticProduct.count_sell_product] = new SellProduct(StaticProduct.products[uber_row_index].Id, StaticProduct.products[uber_row_index].Name, StaticProduct.products[uber_row_index].Price, amount, StaticProduct.products[uber_row_index].Сarrier, StaticProduct.products[uber_row_index].Category);
                                StaticProduct.count_sell_product++;
                                int i = uber_row_index;
                                while (i <= count_product)
                                {
                                    StaticProduct.products[i] = StaticProduct.products[i + 1];
                                    i++;
                                }
                                StaticProduct.count_product--;
                                DataTable product_table = new DataTable();
                                for (int u = 0; u < StaticProduct.count_product; u++)
                                {
                                    product_table.Merge(Product.ShowInfo(u));
                                }
                                dataGridView_product.DataSource = product_table;
                                DataTable sell_product_table = new DataTable();
                                for (int u = 0; u < StaticProduct.count_sell_product; u++)
                                {
                                    sell_product_table.Merge(SellProduct.ShowInfo(u));
                                }
                                dataGridView_sell_product.DataSource = sell_product_table;
                                TextBox_amount.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Введенное вами количество товаров превышает количетсво товаров имеющихся на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели некорректное значение количества товара. Количеством товара дожно быть числом от 1 до 99999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.SlateBlue;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= StaticProduct.number_chek; i++)
            {
                string path = Path.GetFullPath("check" + i + ".txt");
                File.Delete(path);

            }
            Application.Exit();
            
        }

        private void Button_exit_MouseEnter(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;
        }

        private void Button_exit_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.SlateBlue;
        }

        private void Button_seller_Click(object sender, EventArgs e)
        {
            Form ifrm = new SellerForm();
            ifrm.Show();
            this.Hide();
        }

        private void Button_product_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormProduct();
            ifrm.Show();
            this.Close();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Form ifrm = new LoginForm();
            ifrm.Show();
            this.Close();
        }
    }
}
