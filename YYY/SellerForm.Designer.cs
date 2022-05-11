
namespace YYY
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_exit = new System.Windows.Forms.Label();
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_product = new Guna.UI2.WinForms.Guna2Button();
            this.Button_selling = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_search = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_search = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_seller = new System.Windows.Forms.DataGridView();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_change = new Guna.UI2.WinForms.Guna2Button();
            this.Button_create = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_patronymic = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_experience = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Black", 16.75F, System.Drawing.FontStyle.Bold);
            this.label_exit.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_exit.Location = new System.Drawing.Point(1058, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(30, 31);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // Button_exit
            // 
            this.Button_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_exit.FillColor = System.Drawing.Color.Transparent;
            this.Button_exit.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_exit.ForeColor = System.Drawing.Color.SlateBlue;
            this.Button_exit.Location = new System.Drawing.Point(-1, 469);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(161, 45);
            this.Button_exit.TabIndex = 6;
            this.Button_exit.Text = "Выход";
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            this.Button_exit.MouseEnter += new System.EventHandler(this.Button_exit_MouseEnter);
            this.Button_exit.MouseLeave += new System.EventHandler(this.Button_exit_MouseLeave);
            // 
            // Button_product
            // 
            this.Button_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_product.FillColor = System.Drawing.Color.Transparent;
            this.Button_product.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_product.ForeColor = System.Drawing.Color.SlateBlue;
            this.Button_product.Location = new System.Drawing.Point(-1, 57);
            this.Button_product.Name = "Button_product";
            this.Button_product.Size = new System.Drawing.Size(168, 48);
            this.Button_product.TabIndex = 7;
            this.Button_product.Text = "Склад";
            this.Button_product.Click += new System.EventHandler(this.Button_product_Click);
            // 
            // Button_selling
            // 
            this.Button_selling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_selling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_selling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_selling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_selling.FillColor = System.Drawing.Color.Transparent;
            this.Button_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_selling.ForeColor = System.Drawing.Color.SlateBlue;
            this.Button_selling.Location = new System.Drawing.Point(-1, 126);
            this.Button_selling.Name = "Button_selling";
            this.Button_selling.Size = new System.Drawing.Size(168, 45);
            this.Button_selling.TabIndex = 8;
            this.Button_selling.Text = "Продажи";
            this.Button_selling.Click += new System.EventHandler(this.Button_selling_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.TextBox_search);
            this.panel1.Controls.Add(this.Button_search);
            this.panel1.Controls.Add(this.ComboBox_search);
            this.panel1.Controls.Add(this.TextBox_password);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.Button_delete);
            this.panel1.Controls.Add(this.Button_change);
            this.panel1.Controls.Add(this.Button_create);
            this.panel1.Controls.Add(this.TextBox_patronymic);
            this.panel1.Controls.Add(this.TextBox_experience);
            this.panel1.Controls.Add(this.TextBox_surname);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(173, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 446);
            this.panel1.TabIndex = 9;
            // 
            // TextBox_search
            // 
            this.TextBox_search.BorderRadius = 15;
            this.TextBox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_search.DefaultText = "";
            this.TextBox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search.Location = new System.Drawing.Point(537, 51);
            this.TextBox_search.Name = "TextBox_search";
            this.TextBox_search.PasswordChar = '\0';
            this.TextBox_search.PlaceholderText = "";
            this.TextBox_search.SelectedText = "";
            this.TextBox_search.Size = new System.Drawing.Size(207, 36);
            this.TextBox_search.TabIndex = 24;
            // 
            // Button_search
            // 
            this.Button_search.BackColor = System.Drawing.Color.SlateBlue;
            this.Button_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_search.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_search.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_search.ForeColor = System.Drawing.Color.White;
            this.Button_search.Location = new System.Drawing.Point(750, 42);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(99, 45);
            this.Button_search.TabIndex = 23;
            this.Button_search.Text = "Найти";
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // ComboBox_search
            // 
            this.ComboBox_search.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_search.BorderRadius = 15;
            this.ComboBox_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_search.ItemHeight = 30;
            this.ComboBox_search.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Отчество",
            "Стаж работы",
            "Номер телефона",
            "Пароль",
            "Номер",
            "Показать все"});
            this.ComboBox_search.Location = new System.Drawing.Point(339, 51);
            this.ComboBox_search.Name = "ComboBox_search";
            this.ComboBox_search.Size = new System.Drawing.Size(183, 36);
            this.ComboBox_search.TabIndex = 22;
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderRadius = 15;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(164, 300);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(158, 36);
            this.TextBox_password.TabIndex = 21;
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.BorderRadius = 15;
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Location = new System.Drawing.Point(164, 255);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderText = "";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.Size = new System.Drawing.Size(158, 36);
            this.TextBox_phone.TabIndex = 20;
            // 
            // dataGridView_seller
            // 
            this.dataGridView_seller.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seller.Location = new System.Drawing.Point(339, 104);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.ReadOnly = true;
            this.dataGridView_seller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seller.Size = new System.Drawing.Size(510, 305);
            this.dataGridView_seller.TabIndex = 19;
            this.dataGridView_seller.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_seller_RowHeaderMouseClick);
            // 
            // Button_delete
            // 
            this.Button_delete.BackColor = System.Drawing.Color.SlateBlue;
            this.Button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_delete.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_delete.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_delete.ForeColor = System.Drawing.Color.White;
            this.Button_delete.Location = new System.Drawing.Point(223, 342);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(110, 45);
            this.Button_delete.TabIndex = 13;
            this.Button_delete.Text = "Удалить";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // Button_change
            // 
            this.Button_change.BackColor = System.Drawing.Color.SlateBlue;
            this.Button_change.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_change.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_change.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_change.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_change.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_change.ForeColor = System.Drawing.Color.White;
            this.Button_change.Location = new System.Drawing.Point(117, 342);
            this.Button_change.Name = "Button_change";
            this.Button_change.Size = new System.Drawing.Size(114, 45);
            this.Button_change.TabIndex = 12;
            this.Button_change.Text = "Изменить";
            this.Button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // Button_create
            // 
            this.Button_create.BackColor = System.Drawing.Color.SlateBlue;
            this.Button_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_create.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_create.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_create.ForeColor = System.Drawing.Color.White;
            this.Button_create.Location = new System.Drawing.Point(3, 342);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(114, 45);
            this.Button_create.TabIndex = 11;
            this.Button_create.Text = "Добавить";
            this.Button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // TextBox_patronymic
            // 
            this.TextBox_patronymic.BorderRadius = 15;
            this.TextBox_patronymic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_patronymic.DefaultText = "";
            this.TextBox_patronymic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_patronymic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_patronymic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_patronymic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_patronymic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_patronymic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_patronymic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_patronymic.Location = new System.Drawing.Point(164, 167);
            this.TextBox_patronymic.Name = "TextBox_patronymic";
            this.TextBox_patronymic.PasswordChar = '\0';
            this.TextBox_patronymic.PlaceholderText = "";
            this.TextBox_patronymic.SelectedText = "";
            this.TextBox_patronymic.Size = new System.Drawing.Size(158, 36);
            this.TextBox_patronymic.TabIndex = 10;
            // 
            // TextBox_experience
            // 
            this.TextBox_experience.BorderRadius = 15;
            this.TextBox_experience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_experience.DefaultText = "";
            this.TextBox_experience.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_experience.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_experience.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_experience.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_experience.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_experience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_experience.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_experience.Location = new System.Drawing.Point(164, 209);
            this.TextBox_experience.Name = "TextBox_experience";
            this.TextBox_experience.PasswordChar = '\0';
            this.TextBox_experience.PlaceholderText = "";
            this.TextBox_experience.SelectedText = "";
            this.TextBox_experience.Size = new System.Drawing.Size(158, 36);
            this.TextBox_experience.TabIndex = 9;
            // 
            // TextBox_surname
            // 
            this.TextBox_surname.BorderRadius = 15;
            this.TextBox_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_surname.DefaultText = "";
            this.TextBox_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_surname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_surname.Location = new System.Drawing.Point(164, 83);
            this.TextBox_surname.Name = "TextBox_surname";
            this.TextBox_surname.PasswordChar = '\0';
            this.TextBox_surname.PlaceholderText = "";
            this.TextBox_surname.SelectedText = "";
            this.TextBox_surname.Size = new System.Drawing.Size(158, 36);
            this.TextBox_surname.TabIndex = 8;
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 15;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(164, 125);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(158, 36);
            this.TextBox_name.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стаж работы (лет)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(348, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПРОДАВЦЫ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_selling);
            this.Controls.Add(this.Button_product);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2Button Button_exit;
        private Guna.UI2.WinForms.Guna2Button Button_product;
        private Guna.UI2.WinForms.Guna2Button Button_selling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_seller;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_change;
        private Guna.UI2.WinForms.Guna2Button Button_create;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_patronymic;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_experience;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_surname;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search;
        private Guna.UI2.WinForms.Guna2Button Button_search;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_search;
    }
}