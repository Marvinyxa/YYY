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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            DataTable seller_table = new DataTable();
            for (int u = 0; u < StaticProduct.count_seller; u++)
            {
                seller_table.Merge(SellerClass.ShowInfo(u));
            }
            dataGridView_seller.DataSource = seller_table;
        
        }
        int uber_row_index = -1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            if (StaticProduct.count_seller == StaticProduct.number_seller_count)
            {
                MessageBox.Show("Количество продавцов максимально.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name, surname, patronymic, password;
                int experience, i, i1, i2, i3, i4;
                ulong phone;
                bool flag = false;
                if (TextBox_name.Text == "" || TextBox_surname.Text == "" || TextBox_patronymic.Text == "" || TextBox_password.Text == "" || TextBox_experience.Text == "" || TextBox_phone.Text == "")
                {
                    MessageBox.Show("Вы не ввели одно или несколько из требуемых значений.", "Ошибка");
                }
                else
                {

                    name = TextBox_name.Text;
                    i2 = 0;
                    foreach (char a in name)
                    {
                        if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                        {
                        }
                        else
                        {
                            MessageBox.Show("В имене использованны некорректные символы. В имене могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            i2++;
                            TextBox_name.Clear();
                            break;
                        }
                    }
                    surname = TextBox_surname.Text;
                    i3 = 0;
                    foreach (char a in surname)
                    {
                        if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                        {
                        }
                        else
                        {
                            MessageBox.Show("В фамилии использованны некорректные символы. В фамили могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            i3++;
                            TextBox_surname.Clear();
                            break;
                        }
                    }
                    patronymic = TextBox_patronymic.Text;
                    i4 = 0;
                    foreach (char a in patronymic)
                    {
                        if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                        {
                        }
                        else
                        {
                            MessageBox.Show("В отчестве использованны некорректные символы. В отчестве могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            i4++;
                            TextBox_patronymic.Clear();
                            break;
                        }
                    }
                    password = TextBox_password.Text;
                    flag = int.TryParse(TextBox_experience.Text, out experience);
                    i = 0;
                    i1 = 0;
                    if ((flag && experience > 0) && (experience >= 0) && (experience <= 65))
                    {
                        i++;
                    }
                    else
                    {
                        TextBox_experience.Clear();
                        MessageBox.Show("Вы ввели некорректное значение стажа работника. Стажем работника может быть число от 1 до 65.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    flag = ulong.TryParse(TextBox_phone.Text, out phone);
                    if ((flag && phone > 0) && (phone >= 89000000000) && (phone <= 89999999999))
                    {
                        i1++;
                    }
                    else
                    {
                        TextBox_phone.Clear();
                        MessageBox.Show("Вы ввели некорректное значение номера телефона. Номер телефона должен быть записан в формате: 89999999999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (i == 1 && i1 == 1 && i2 == 0 && i3 == 0 && i4 == 0)
                    {
                        if (StaticProduct.count_seller > 0)
                        {
                            int j1 = 0, j2 = 0, j3 = 0;
                            for (int j = 0; j < StaticProduct.count_seller; j++)
                            {
                                if (phone == StaticProduct.sellers[j].Phone)
                                {
                                    MessageBox.Show("Продавец с таким номером телефона уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    TextBox_phone.Clear();
                                    j1++;
                                    break;
                                }
                                else
                                {
                                    if (password == StaticProduct.sellers[j].Password)
                                    {
                                        MessageBox.Show("Продавец с таким паролем аккаунта уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        TextBox_password.Clear();
                                        j2++;
                                        break;
                                    }
                                    else
                                    {
                                        if (name == StaticProduct.sellers[j].Name && surname == StaticProduct.sellers[j].Surname && patronymic == StaticProduct.sellers[j].Patronymic)
                                        {
                                            MessageBox.Show("Продавец с таким именем фамилией и отчеством существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            TextBox_name.Clear();
                                            TextBox_surname.Clear();
                                            TextBox_patronymic.Clear();
                                            j3++;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (j1 == 0 && j2 == 0 && j3 == 0)
                            {
                                StaticProduct.sellers[StaticProduct.count_seller] = new SellerClass(name, surname, patronymic, experience, phone, password);
                                StaticProduct.count_seller++;
                                TextBox_name.Clear();
                                TextBox_surname.Clear();
                                TextBox_patronymic.Clear();
                                TextBox_experience.Clear();
                                TextBox_phone.Clear();
                                TextBox_password.Clear();
                            }

                        }
                        else
                        {
                            StaticProduct.sellers[StaticProduct.count_seller] = new SellerClass(name, surname, patronymic, experience, phone, password);
                            StaticProduct.count_seller++;
                            TextBox_name.Clear();
                            TextBox_surname.Clear();
                            TextBox_patronymic.Clear();
                            TextBox_experience.Clear();
                            TextBox_phone.Clear();
                            TextBox_password.Clear();
                        }
                        DataTable seller_table = new DataTable();
                        for (int u = 0; u < StaticProduct.count_seller; u++)
                        {
                            seller_table.Merge(SellerClass.ShowInfo(u));
                        }
                        dataGridView_seller.DataSource = seller_table;

                    }
                }            

            }
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            if (uber_row_index == -1)
            {
                MessageBox.Show("Вы не выбрали строку в таблице.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (StaticProduct.count_seller == 0)
                {
                    MessageBox.Show("У Вас еще нет продовцов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name, surname, patronymic, password;
                    int experience, i, i1, i2, i3, i4;
                    ulong phone;
                    bool flag = false;
                    if (TextBox_name.Text == "" || TextBox_surname.Text == "" || TextBox_patronymic.Text == "" || TextBox_password.Text == "" || TextBox_experience.Text == "" || TextBox_phone.Text == "")
                    {
                        MessageBox.Show("Вы не ввели одно или несколько из требуемых значений.", "Ошибка");
                    }
                    else
                    {

                        name = TextBox_name.Text;
                        i2 = 0;
                        foreach (char a in name)
                        {
                            if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                            {
                            }
                            else
                            {
                                MessageBox.Show("В имене использованны некорректные символы. В имене могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i2++;
                                TextBox_name.Clear();
                                break;
                            }
                        }
                        surname = TextBox_surname.Text;
                        i3 = 0;
                        foreach (char a in surname)
                        {
                            if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                            {
                            }
                            else
                            {
                                MessageBox.Show("В фамилии использованны некорректные символы. В фамилии могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i3++;
                                TextBox_surname.Clear();
                                break;
                            }
                        }
                        patronymic = TextBox_patronymic.Text;
                        i4 = 0;
                        foreach (char a in patronymic)
                        {
                            if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                            {
                            }
                            else
                            {
                                MessageBox.Show("В отчестве использованны некорректные символы. В отчестве могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i4++;
                                TextBox_patronymic.Clear();
                                break;
                            }
                        }
                        password = TextBox_password.Text;
                        flag = int.TryParse(TextBox_experience.Text, out experience);
                        i = 0;
                        i1 = 0;
                        if ((flag && experience > 0) && (experience >= 0) && (experience <= 65))
                        {
                            i++;
                        }
                        else
                        {
                            TextBox_experience.Clear();
                            MessageBox.Show("Вы ввели некорректное значение стажа работника. Стаж не может превышать 65 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        flag = ulong.TryParse(TextBox_phone.Text, out phone);
                        if ((flag && phone > 0) && (phone >= 89000000000) && (phone <= 89999999999))
                        {
                            i1++;
                        }
                        else
                        {
                            TextBox_phone.Clear();
                            MessageBox.Show("Вы ввели некорректное значение номера телефона. Номер телефона должен быть записан в формате: 89999999999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (i == 1 && i1 == 1 && i2 == 0 && i3 == 0 && i4 == 0)
                        {
                            if (StaticProduct.count_seller > 0)
                            {
                                int j1 = 0, j2 = 0, j3 = 0;
                                for (int j = 0; j < StaticProduct.count_seller; j++)
                                {
                                    
                                    if (phone == StaticProduct.sellers[j].Phone && j!=uber_row_index)
                                    {
                                        MessageBox.Show("Продавец с таким номером телефона уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        TextBox_phone.Clear();
                                        j1++;
                                        break;
                                    }
                                    else
                                    {
                                        if (password == StaticProduct.sellers[j].Password && j != uber_row_index)
                                        {
                                            MessageBox.Show("Продавец с таким паролем аккаунта уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            TextBox_password.Clear();
                                            j2++;
                                            break;
                                        }
                                        else
                                        {
                                            if (name == StaticProduct.sellers[j].Name && surname == StaticProduct.sellers[j].Surname && patronymic == StaticProduct.sellers[j].Patronymic && j != uber_row_index)
                                            {
                                                MessageBox.Show("Продавец с таким именем фамилией и отчеством существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                TextBox_name.Clear();
                                                TextBox_surname.Clear();
                                                TextBox_patronymic.Clear();
                                                j3++;
                                                break;
                                            }
                                            
                                        }
                                    }
                                }
                                if (j1 == 0 && j2 == 0 && j3 == 0)
                                {
                                    StaticProduct.sellers[uber_row_index].Name = name;
                                    StaticProduct.sellers[uber_row_index].Surname = surname;
                                    StaticProduct.sellers[uber_row_index].Patronymic = patronymic;
                                    StaticProduct.sellers[uber_row_index].Experience = experience;
                                    StaticProduct.sellers[uber_row_index].Phone = phone;
                                    StaticProduct.sellers[uber_row_index].Password = password;
                                    TextBox_name.Clear();
                                    TextBox_surname.Clear();
                                    TextBox_patronymic.Clear();
                                    TextBox_experience.Clear();
                                    TextBox_phone.Clear();
                                    TextBox_password.Clear();
                                }

                            }
                            else
                            {
                                StaticProduct.sellers[uber_row_index].Name = name;
                                StaticProduct.sellers[uber_row_index].Surname = surname;
                                StaticProduct.sellers[uber_row_index].Patronymic = patronymic;
                                StaticProduct.sellers[uber_row_index].Experience = experience;
                                StaticProduct.sellers[uber_row_index].Phone = phone;
                                StaticProduct.sellers[uber_row_index].Password = password;
                                TextBox_name.Clear();
                                TextBox_surname.Clear();
                                TextBox_patronymic.Clear();
                                TextBox_experience.Clear();
                                TextBox_phone.Clear();
                                TextBox_password.Clear();
                            }

                            DataTable seller_table = new DataTable();
                            for (int u = 0; u < StaticProduct.count_seller; u++)
                            {
                                seller_table.Merge(SellerClass.ShowInfo(u));
                            }
                            dataGridView_seller.DataSource = seller_table;

                        }

                    }
                
                }
            }
        }

        private void dataGridView_seller_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            uber_row_index = e.RowIndex;
            string s = dataGridView_seller[0, uber_row_index].Value.ToString();
            TextBox_name.Text = dataGridView_seller[1, uber_row_index].Value.ToString();
            TextBox_surname.Text = dataGridView_seller[2, uber_row_index].Value.ToString();
            TextBox_patronymic.Text = dataGridView_seller[3, uber_row_index].Value.ToString();
            TextBox_experience.Text = dataGridView_seller[4, uber_row_index].Value.ToString();
            TextBox_phone.Text = dataGridView_seller[5, uber_row_index].Value.ToString();
            TextBox_password.Text = dataGridView_seller[6, uber_row_index].Value.ToString();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            int count_seller = StaticProduct.count_seller;
            if (uber_row_index == -1)
            {
                MessageBox.Show("Вы не выбрали строку в таблице.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (StaticProduct.count_seller == 0)
                {
                    MessageBox.Show("У вас еще нет продовцов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = uber_row_index;
                    while (i <= count_seller)
                    {
                        StaticProduct.sellers[i] = StaticProduct.sellers[i + 1];
                        i++;
                    }
                    TextBox_name.Clear();
                    TextBox_surname.Clear();
                    TextBox_patronymic.Clear();
                    TextBox_experience.Clear();
                    TextBox_phone.Clear();
                    TextBox_password.Clear();
                    StaticProduct.count_seller--;
                    DataTable seller_table = new DataTable();
                    for (int u = 0; u < StaticProduct.count_seller; u++)
                    {
                        seller_table.Merge(SellerClass.ShowInfo(u));
                    }
                    dataGridView_seller.DataSource = seller_table;
                }
            }
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            if (StaticProduct.count_seller == 0)
            {
                MessageBox.Show("У вас еще нет продовцов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ComboBox_search.Text == "")
                {
                    MessageBox.Show("Вы не выбрали по какому параметру необходимо искать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TextBox_search.Text == "" && ComboBox_search.Text == "Показать все")

                    {
                        DataTable seller_table = new DataTable();
                        for (int u = 0; u < StaticProduct.count_seller; u++)
                        {
                            seller_table.Merge(SellerClass.ShowInfo(u));
                        }
                        dataGridView_seller.DataSource = seller_table;
                        TextBox_search.Clear();
                        ComboBox_search.SelectedIndex = -1;
                    }
                    else
                    {
                        if (TextBox_search.Text == "")

                        {
                            MessageBox.Show("Вы не выбрали по какому параметр для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (ComboBox_search.Text == "Стаж работы")
                            {
                                int experience;
                                bool flag;
                                flag = int.TryParse(TextBox_search.Text, out experience);
                                if ((flag && experience > 0) && (experience >= 0) && (experience <= 45))
                                {
                                    int i = 0, i1 = 0;
                                    DataTable seller_table = new DataTable();
                                    while (i < StaticProduct.count_seller)
                                    {
                                        if (experience == StaticProduct.sellers[i].Experience)
                                        {
                                            seller_table.Merge(SellerClass.ShowInfo(i));
                                            i1++;
                                        }
                                        i++;
                                    }
                                    if (i1 == 0)
                                    {
                                        MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    dataGridView_seller.DataSource = seller_table;
                                    TextBox_search.Clear();
                                    ComboBox_search.SelectedIndex = -1;

                                }
                                else
                                {
                                    MessageBox.Show("Вы ввели некорректное значение стажа работника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }  
                            }
                            else
                            {
                                if (ComboBox_search.Text == "Номер телефона")
                                {
                                    ulong phone;
                                    bool flag;
                                    flag = ulong.TryParse(TextBox_search.Text, out phone);
                                    flag = ulong.TryParse(TextBox_phone.Text, out phone);
                                    if ((flag && phone > 0) && (phone >= 89000000000) && (phone <= 89999999999))
                                    {
                                            int i = 0, i1 = 0;
                                            DataTable seller_table = new DataTable();
                                            while (i < StaticProduct.count_seller)
                                            {
                                                if (phone == StaticProduct.sellers[i].Phone)
                                                {
                                                seller_table.Merge(SellerClass.ShowInfo(i));
                                                i1++;
                                                }
                                                i++;
                                            }
                                            if (i1 == 0)
                                            {
                                                MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            dataGridView_seller.DataSource = seller_table;
                                            TextBox_search.Clear();
                                            ComboBox_search.SelectedIndex = -1;
                                        

                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы ввели некорректное значение стажа работника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    if (ComboBox_search.Text == "Имя")
                                    {
                                        string name;
                                        name = TextBox_search.Text;
                                        int i2 = 0;
                                        foreach (char a in name)
                                        {
                                            if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                                            {
                                            }
                                            else
                                            {
                                                MessageBox.Show("В имене использованны некорректные символы. В имене могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                i2++;
                                                break;
                                            }
                                        }
                                        if (i2 == 0)
                                        {
                                            int i = 0, i1 = 0;
                                            DataTable seller_table = new DataTable();
                                            while (i < StaticProduct.count_seller)
                                            {
                                                if (name.ToLower().Replace(" ", "") == StaticProduct.sellers[i].Name.ToLower().Replace(" ", ""))
                                                {
                                                    seller_table.Merge(SellerClass.ShowInfo(i));
                                                    i1++;
                                                }
                                                i++;
                                            }
                                            if (i1 == 0)
                                            {
                                                MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            dataGridView_seller.DataSource = seller_table;
                                            TextBox_search.Clear();
                                            ComboBox_search.SelectedIndex = -1;
                                        }
                                    }
                                    else
                                    {

                                        if (ComboBox_search.Text == "Фамилия")
                                        {
                                            string surname;
                                            surname = TextBox_search.Text;
                                            int i2 = 0;
                                            foreach (char a in surname)
                                            {
                                                if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                                                {
                                                }
                                                else
                                                {
                                                    MessageBox.Show("В фамилии использованны некорректные символы. В фамилии могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    i2++;
                                                    break;
                                                }
                                            }
                                            if (i2 == 0)
                                            {
                                                int i = 0, i1 = 0;
                                                DataTable seller_table = new DataTable();
                                                while (i < StaticProduct.count_seller)
                                                {
                                                    if (surname.ToLower().Replace(" ", "") == StaticProduct.sellers[i].Surname.ToLower().Replace(" ", ""))
                                                    {
                                                        seller_table.Merge(SellerClass.ShowInfo(i));
                                                        i1++;
                                                    }
                                                    i++;
                                                }
                                                if (i1 == 0)
                                                {
                                                    MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                dataGridView_seller.DataSource = seller_table;
                                                TextBox_search.Clear();
                                                ComboBox_search.SelectedIndex = -1;
                                            }
                                        }
                                        else
                                        {
                                            if (ComboBox_search.Text == "Отчество")
                                            {
                                                string patronymic;
                                                patronymic = TextBox_search.Text;
                                                int i2 = 0;
                                                foreach (char a in patronymic)
                                                {
                                                    if (a >= 'а' && a <= 'я' || (a >= 'А' && a <= 'Я') || a == '-')
                                                    {
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("В отчестве использованны некорректные символы. В отчестве могут использоваться только русские буквы и символ «-».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        i2++;
                                                        break;
                                                    }
                                                }
                                                if (i2 == 0)
                                                {
                                                    int i = 0, i1 = 0;
                                                    DataTable seller_table = new DataTable();
                                                    while (i < StaticProduct.count_seller)
                                                    {
                                                        if (patronymic.ToLower().Replace(" ", "") == StaticProduct.sellers[i].Patronymic.ToLower().Replace(" ", ""))
                                                        {
                                                            seller_table.Merge(SellerClass.ShowInfo(i));
                                                            i1++;
                                                        }
                                                        i++;
                                                    }
                                                    if (i1 == 0)
                                                    {
                                                        MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    dataGridView_seller.DataSource = seller_table;
                                                    TextBox_search.Clear();
                                                    ComboBox_search.SelectedIndex = -1;
                                                }
                                            }
                                            else
                                            {
                                                if (ComboBox_search.Text == "Пароль")
                                                {
                                                    string password;
                                                    password = TextBox_search.Text;
                                                    int i = 0, i1 = 0;
                                                    DataTable seller_table = new DataTable();
                                                    while (i < StaticProduct.count_seller)
                                                    {
                                                            if (password == StaticProduct.sellers[i].Password)
                                                            {
                                                            seller_table.Merge(SellerClass.ShowInfo(i));
                                                            i1++;
                                                            }
                                                            i++;
                                                    }
                                                    if (i1 == 0)
                                                    {
                                                         MessageBox.Show("Таких продавцов в магазине нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    dataGridView_seller.DataSource = seller_table;
                                                    TextBox_search.Clear();
                                                    ComboBox_search.SelectedIndex = -1;
                                                  
                                                }
                                                else
                                                {
                                                    if (ComboBox_search.Text == "Номер")
                                                    {
                                                        bool flag;
                                                        int number;
                                                        flag = int.TryParse(TextBox_search.Text, out number);
                                                        if ((flag && number > 0) && (number >= 1) && (number <= StaticProduct.count_seller))
                                                        {
                                                            int i = 0, i1 = 0;
                                                            DataTable seller_table = new DataTable();
                                                            while (i < StaticProduct.count_seller)
                                                            {
                                                                if (number == (i + 1))
                                                                {
                                                                    seller_table.Merge(SellerClass.ShowInfo(i));
                                                                    i1++;
                                                                }
                                                                i++;
                                                            }
                                                            if (i1 == 0)
                                                            {
                                                                MessageBox.Show("Таких товаров на складе нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            dataGridView_seller.DataSource = seller_table;
                                                            TextBox_search.Clear();
                                                            ComboBox_search.SelectedIndex = -1;
                                                        }
                                                        else
                                                        {
                                                            TextBox_search.Clear();
                                                            MessageBox.Show("Вы ввели некорректное значение номера продукта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.SlateBlue;
        }

        private void Button_exit_MouseEnter(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;
        }

        private void Button_exit_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.SlateBlue;
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

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Form ifrm = new LoginForm();
            ifrm.Show();
            this.Close();
        }

        private void Button_product_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormProduct();
            ifrm.Show();
            this.Close();
        }

        private void Button_selling_Click(object sender, EventArgs e)
        {
            Form ifrm = new SellingForm();
            ifrm.Show();
            this.Close();
        }
    }
}