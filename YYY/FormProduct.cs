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


namespace YYY
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            DataTable product_table = new DataTable();
            for (int u = 0; u < StaticProduct.count_product; u++)
            {
                product_table.Merge(Product.ShowInfo(u));
            }
            dataGridView_product.DataSource = product_table;
            
        }
        int uber_row_index = -1;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            if (StaticProduct.count_product == StaticProduct.number_count)
            {
                MessageBox.Show("Склад переполнен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name, carrier, category;
                int id, amount, i, i1, i2;
                float price;
                bool flag = false;
                if (TextBox_name.Text == "" || TextBox_id.Text == "" || TextBox_amount.Text == "" || TextBox_price.Text == "" || ComboBox_carrier.Text == "" || ComboBox_category.Text == "")
                {
                    MessageBox.Show("Вы не ввели одно или несколько из требуемых значений.", "Ошибка");
                }
                else
                {
                    name = TextBox_name.Text;
                    flag = int.TryParse(TextBox_id.Text, out id);
                    i = 0;
                    i1 = 0;
                    i2 = 0;
                    if ((flag && id > 0) && (id >= 10000) && (id <= 99999))
                    {
                        i++;
                    }
                    else
                    {
                        TextBox_id.Clear();
                        MessageBox.Show("Вы ввели некорректное значение артикула товара. Артикул товара должен состоять из пяти цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    flag = int.TryParse(TextBox_amount.Text, out amount);
                    if ((flag && amount > 0) && (amount >= 1) && (amount <= 99999))
                    {
                        i1++;
                    }
                    else
                    {
                        TextBox_amount.Clear();
                        MessageBox.Show("Вы ввели некорректное значение количества товара. Количеством товара должно быть числом от 1 до 99999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    flag = float.TryParse(TextBox_price.Text, out price);
                    if ((flag && price > 0) && (price >= 0) && (price <= 10000000))
                    {
                        i2++;
                    }
                    else
                    {
                        TextBox_price.Clear();
                        MessageBox.Show("Вы ввели некорректное значение цены товара. Цена товара не может превышать 10 миллионов рублей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    carrier = ComboBox_carrier.Text;
                    category = ComboBox_category.Text;
                    int j1 = 0;
                    if (i == 1 && i1 == 1 && i2 == 1)
                    {
                        if (StaticProduct.count_product > 0)
                        {
                            for (int j = 0; j < StaticProduct.count_product; j++)
                            {
                                if (id == StaticProduct.products[j].Id && name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", "") && price == StaticProduct.products[j].Price && category.ToLower().Replace(" ", "") == StaticProduct.products[j].Category.ToLower().Replace(" ", "") && carrier.ToLower().Replace(" ", "") == StaticProduct.products[j].Сarrier.ToLower().Replace(" ", ""))
                                {
                                    StaticProduct.products[j].Amount = StaticProduct.products[j].Amount + amount;
                                    j1++;
                                }
                            }
                            if (j1 == 0)
                            {
                                int j2 = 0;
                                for (int j = 0; j < StaticProduct.count_product; j++)
                                {
                                    if (id == StaticProduct.products[j].Id || name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", ""))
                                    {
                                        j2++;
                                    }
                                }
                                if (j2 == 0)
                                {
                                    StaticProduct.products[StaticProduct.count_product] = new Product(id, name, price, amount, carrier, category);
                                    StaticProduct.count_product++;
                                    TextBox_id.Clear();
                                    TextBox_name.Clear();
                                    TextBox_price.Clear();
                                    TextBox_amount.Clear();
                                    ComboBox_carrier.SelectedIndex = -1;
                                    ComboBox_category.SelectedIndex = -1;
                                }
                                else
                                {
                                    MessageBox.Show("Товар с таким артикулом или названием уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            
                        }
                        else
                        {
                            if (j1 == 0)
                            {
                                int j2 = 0;
                                for (int j = 0; j < StaticProduct.count_product; j++)
                                {
                                    if (id == StaticProduct.products[j].Id || name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", ""))
                                    {
                                        j2++;
                                    }
                                }
                                if (j2 == 0)
                                {
                                    StaticProduct.products[StaticProduct.count_product] = new Product(id, name, price, amount, carrier, category);
                                    StaticProduct.count_product++;
                                    TextBox_id.Clear();
                                    TextBox_name.Clear();
                                    TextBox_price.Clear();
                                    TextBox_amount.Clear();
                                    ComboBox_carrier.SelectedIndex = -1;
                                    ComboBox_category.SelectedIndex = -1;
                                }
                                else
                                {
                                    MessageBox.Show("Товар с таким артикулом или названием уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    DataTable product_table = new DataTable();
                    for (int u = 0; u < StaticProduct.count_product; u++)
                    {
                        product_table.Merge(Product.ShowInfo(u));
                    }
                    dataGridView_product.DataSource = product_table;
                }
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

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Form ifrm = new LoginForm();
            ifrm.Show();
            this.Close();
        }



        private void dataGridView_product_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            uber_row_index = e.RowIndex;
            string s = dataGridView_product[0, uber_row_index].Value.ToString();
            TextBox_id.Text = dataGridView_product[1, uber_row_index].Value.ToString();
            TextBox_name.Text = dataGridView_product[2, uber_row_index].Value.ToString();
            TextBox_price.Text = dataGridView_product[3, uber_row_index].Value.ToString();
            TextBox_amount.Text = dataGridView_product[4, uber_row_index].Value.ToString();
            ComboBox_carrier.Text = dataGridView_product[5, uber_row_index].Value.ToString();
            ComboBox_category.Text = dataGridView_product[6, uber_row_index].Value.ToString();


        }

        private void Button_change_Click(object sender, EventArgs e)
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
                    string name, carrier, category;
                    int id, amount, i, i1, i2;
                    float price;
                    bool flag = false;
                    if (TextBox_name.Text == "" || TextBox_id.Text == "" || ComboBox_category.Text == "" || TextBox_amount.Text == "" || TextBox_price.Text == "" || ComboBox_carrier.Text == "")
                    {
                        MessageBox.Show("Вы не ввели одно или несколько из требуемых значений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        name = TextBox_name.Text;
                        flag = int.TryParse(TextBox_id.Text, out id);
                        i = 0;
                        i1 = 0;
                        i2 = 0;
                        if ((flag && id > 0) && (id >= 10000) && (id <= 99999))
                        {
                            i++;
                        }
                        else
                        {
                            TextBox_id.Clear();
                            MessageBox.Show("Вы ввели некорректное значение артикула товара. Артикул товара должен состоять из пяти цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        flag = int.TryParse(TextBox_amount.Text, out amount);
                        if ((flag && amount > 0) && (amount >= 1) && (amount <= 99999))
                        {
                            i1++;
                        }
                        else
                        {
                            TextBox_amount.Clear();
                            MessageBox.Show("Вы ввели некорректное значение количества товара. Количеством товара должно быть числом от 1 до 99999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        flag = float.TryParse(TextBox_price.Text, out price);
                        if ((flag && price > 0) && (price >= 0) && (price <= 10000000))
                        {
                            i2++;
                        }
                        else
                        {
                            TextBox_price.Clear();
                            MessageBox.Show("Вы ввели некорректное значение цены товара. Цена товара не может превышать 10 миллионов рублей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        carrier = ComboBox_carrier.Text;
                        category = ComboBox_category.Text;
                        int j1 = 0;
                        int j2 = 0;
                        if (i == 1 && i1 == 1 && i2 == 1)
                        {
                            for (int j = 0; j < StaticProduct.count_product; j++)
                            {
                                if (id == StaticProduct.products[j].Id && j != uber_row_index)
                                {
                                    j1++;
                                }
                            }
                            for (int j = 0; j < StaticProduct.count_product; j++)
                            {
                                if (name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", "") && j != uber_row_index)
                                {
                                    j2++;
                                }
                            }
                            if (j1 != 0)
                            {
                                MessageBox.Show("Товар с таким артикулом уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (j2 != 0)
                                {
                                    MessageBox.Show("Товар с таким названием уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    StaticProduct.products[uber_row_index].Id = id;
                                    StaticProduct.products[uber_row_index].Name = name;
                                    StaticProduct.products[uber_row_index].Price = price;
                                    StaticProduct.products[uber_row_index].Amount = amount;
                                    StaticProduct.products[uber_row_index].Сarrier = carrier;
                                    StaticProduct.products[uber_row_index].Category = category;
                                    TextBox_id.Clear();
                                    TextBox_name.Clear();
                                    TextBox_price.Clear();
                                    TextBox_amount.Clear();
                                    ComboBox_carrier.SelectedIndex = -1;
                                    ComboBox_category.SelectedIndex = -1;
                                }
                            }
                        }

                        DataTable product_table = new DataTable();
                        for (int u = 0; u < StaticProduct.count_product; u++)
                        {
                            product_table.Merge(Product.ShowInfo(u));
                        }
                        dataGridView_product.DataSource = product_table;
                    }
                }
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            int count_product = StaticProduct.count_product;
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
                    int i = uber_row_index;
                    while (i <= count_product)
                    {
                        StaticProduct.products[i] = StaticProduct.products[i + 1];
                        i++;
                    }
                    TextBox_id.Clear();
                    TextBox_name.Clear();
                    TextBox_price.Clear();
                    TextBox_amount.Clear();
                    ComboBox_carrier.SelectedIndex = -1;
                    ComboBox_category.SelectedIndex = -1;
                    StaticProduct.count_product--;
                    DataTable product_table = new DataTable();
                    for (int u = 0; u < StaticProduct.count_product; u++)
                    {
                        product_table.Merge(Product.ShowInfo(u));
                    }
                    dataGridView_product.DataSource = product_table;
                }
            }
        }

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
                                                            if (number == (i+ 1))
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

        private void Button_seller_Click(object sender, EventArgs e)
        {
            Form ifrm = new SellerForm();
            ifrm.Show();
            this.Hide();
        }

        private void Button_selling_Click(object sender, EventArgs e)
        {
            Form ifrm = new SellingForm();
            ifrm.Show();
            this.Hide();
        }

        private void Button_exсel_Click(object sender, EventArgs e)
        {
            try
            {
                string path = TextBox_file.Text;

                StreamReader f = new StreamReader(path);
                int st = 0;
                DialogResult dr = MessageBox.Show("Убедитесь, что данные в каждой строчке файла записаны в таком формате: артикул;название;цена;количество;носитель;категория", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    while (!f.EndOfStream)
                    {
                        string s = f.ReadLine();
                        st++;
                        if (String.IsNullOrEmpty(s))
                        {
                            MessageBox.Show("Строка номер " + st + "пустая.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string[] slovo = s.Split(';' );
                            if (StaticProduct.count_product == StaticProduct.number_count)
                            {
                                MessageBox.Show("Склад переполнен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                string name, carrier, category;
                                int id, amount, i, i1, i2, i3, i4;
                                float price;
                                bool flag;
                                if (slovo[0] == "" || slovo[1] == "" || slovo[2] == "" || slovo[3] == "" || slovo[4] == "" || slovo[5] == "")
                                {
                                    MessageBox.Show("Вы не ввели одно или несколько из требуемых значений в строке под номером " + st + ".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    name = slovo[1];
                                    flag = int.TryParse(slovo[0], out id);
                                    i = 0;
                                    i1 = 0;
                                    i2 = 0;
                                    i3 = 0;
                                    i4 = 0;
                                    if ((flag && id > 0) && (id >= 10000) && (id <= 99999))
                                    {
                                        i++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы ввели некорректное значение артикула товарав в строке под номером " + st + ". Артикул товара должен состоять из пяти цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    flag = int.TryParse(slovo[3], out amount);
                                    if ((flag && amount > 0) && (amount >= 1) && (amount <= 99999))
                                    {
                                        i1++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы ввели некорректное значение количества товара в строке под номером " + st + ". Количеством товара должно быть числом от 1 до 99999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    flag = float.TryParse(slovo[2], out price);
                                    if ((flag && price > 0) && (price >= 0) && (price <= 10000000))
                                    {
                                        i2++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы ввели некорректное значение цены товара в строке под номером " + st + ". Цена товара не может превышать 10 миллионов рублей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    category = "";
                                    carrier = "";
                                    if (slovo[4].Replace(" ", "").ToLower() == "blu-ray" || slovo[4].Replace(" ", "").ToLower() == "dvd" || slovo[4].Replace(" ", "").ToLower() == "cd" || slovo[4].Replace(" ", "").ToLower() == "кассеты")
                                    {
                                        carrier = slovo[4];
                                        i3++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Введено неккоректное название носителя информации в строке под номером " + st + ". На складе могут находиться товары на читерех видах носителей: Blu-ray, DVD, CD и Кассеты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    if (slovo[5].Replace(" ", "").ToLower() == "аудиопродукция" || slovo[5].Replace(" ", "").ToLower() == "видеопродукция" || slovo[5].Replace(" ", "").ToLower() == "софт" || slovo[5].Replace(" ", "").ToLower() == "игры")
                                    {
                                        category = slovo[5];
                                        i4++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Введено неккоректное название категории товара в строке под номером " + st + ". На складе могут находиться товары четырех категорий: Аудиопродукция, Видеопродукция, Софт и Игры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    int j1 = 0;
                                    if (i == 1 && i1 == 1 && i2 == 1 && i3 == 1 && i4 == 1)
                                    {
                                        if (StaticProduct.count_product > 0)
                                        {
                                            for (int j = 0; j < StaticProduct.count_product; j++)
                                            {
                                                if (id == StaticProduct.products[j].Id && name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", "") && price == StaticProduct.products[j].Price && category.ToLower().Replace(" ", "") == StaticProduct.products[j].Category.ToLower().Replace(" ", "") && carrier.ToLower().Replace(" ", "") == StaticProduct.products[j].Сarrier.ToLower().Replace(" ", ""))
                                                {
                                                    StaticProduct.products[j].Amount = StaticProduct.products[j].Amount + amount;
                                                    j1++;
                                                }
                                            }
                                            if (j1 == 0)
                                            {
                                                int j2 = 0;
                                                for (int j = 0; j < StaticProduct.count_product; j++)
                                                {
                                                    if (id == StaticProduct.products[j].Id || name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", ""))
                                                    {
                                                        j2++;
                                                    }
                                                }
                                                if (j2 == 0)
                                                {
                                                    StaticProduct.products[StaticProduct.count_product] = new Product(id, name, price, amount, carrier, category);
                                                    StaticProduct.count_product++;
                                                    TextBox_id.Clear();
                                                    TextBox_name.Clear();
                                                    TextBox_price.Clear();
                                                    TextBox_amount.Clear();
                                                    ComboBox_carrier.SelectedIndex = -1;
                                                    ComboBox_category.SelectedIndex = -1;
                                                    MessageBox.Show("Данные успешно строки под номером " + st + " импортированы.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Товар, расположенный в файле в строке под номером " + st + ", с таким артикулом или названием уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }

                                        }
                                        else
                                        {
                                            if (j1 == 0)
                                            {
                                                int j2 = 0;
                                                for (int j = 0; j < StaticProduct.count_product; j++)
                                                {
                                                    if (id == StaticProduct.products[j].Id || name.ToLower().Replace(" ", "") == StaticProduct.products[j].Name.ToLower().Replace(" ", ""))
                                                    {
                                                        j2++;
                                                    }
                                                }
                                                if (j2 == 0)
                                                {
                                                    StaticProduct.products[StaticProduct.count_product] = new Product(id, name, price, amount, carrier, category);
                                                    StaticProduct.count_product++;
                                                    TextBox_id.Clear();
                                                    TextBox_name.Clear();
                                                    TextBox_price.Clear();
                                                    TextBox_amount.Clear();
                                                    ComboBox_carrier.SelectedIndex = -1;
                                                    ComboBox_category.SelectedIndex = -1;
                                                    MessageBox.Show("Данные успешно строки под номером " + st + " импортированы.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Товар, расположенный в файле в строке под номером " + st + ", с таким артикулом или названием уже есть на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                    }
                                   
                                }
                            }
                        }
                    }
                    f.Close();
                    DataTable product_table = new DataTable();
                    for (int u = 0; u < StaticProduct.count_product; u++)
                    {
                        product_table.Merge(Product.ShowInfo(u));
                    }
                    dataGridView_product.DataSource = product_table;
                }
            }
            catch
            {
                MessageBox.Show("Введён не коректный файл повторите ввод", "Уведомление");
                TextBox_file.Text = "";
            }
        

        }
    }
}




