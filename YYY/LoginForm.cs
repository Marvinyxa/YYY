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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.SlateBlue;
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void guna2Button_enter_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Вы не ввели имя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex > -1)
                {
                    if (comboBox_role.SelectedItem.ToString() == "Администратор")
                    {
                        if (TextBox_username.Text == "Хомяк" && TextBox_password.Text == "1234")
                        {
                            StaticProduct.name_seller = TextBox_username.Text;
                            StaticProduct.number_seller = 0;
                            Form ifrm = new FormProduct();
                            ifrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Вы ввели неправильный пароль или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (StaticProduct.count_seller > 0)
                        {
                            int i = 0;
                            for (int u = 0; u < StaticProduct.count_seller; u++)
                            {
                                if (StaticProduct.sellers[u].Name == TextBox_username.Text && StaticProduct.sellers[u].Password == TextBox_password.Text)
                                {
                                    StaticProduct.name_seller = TextBox_username.Text;
                                    StaticProduct.number_seller = u + 1;
                                    Form ifrm1 = new ForSeller();
                                    ifrm1.Show();
                                    this.Hide();
                                    i++;
                                }
                            }
                            if (i == 0)
                            {
                                MessageBox.Show("Вы ввели неправильный пароль или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("В магазине еще не работают продавцы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Выберете администратор вы или продавец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
