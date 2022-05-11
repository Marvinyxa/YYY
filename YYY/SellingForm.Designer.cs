
namespace YYY
{
    partial class SellingForm
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
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_product = new Guna.UI2.WinForms.Guna2Button();
            this.Button_seller = new Guna.UI2.WinForms.Guna2Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_cash = new System.Windows.Forms.DataGridView();
            this.dataGridView_sell_product = new System.Windows.Forms.DataGridView();
            this.label_name_seller = new System.Windows.Forms.Label();
            this.Button_sell = new Guna.UI2.WinForms.Guna2Button();
            this.label_date = new System.Windows.Forms.Label();
            this.TextBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.Button_search = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_search = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_create = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
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
            this.Button_exit.Location = new System.Drawing.Point(6, 480);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(161, 45);
            this.Button_exit.TabIndex = 10;
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
            this.Button_product.Location = new System.Drawing.Point(-1, 113);
            this.Button_product.Name = "Button_product";
            this.Button_product.Size = new System.Drawing.Size(154, 45);
            this.Button_product.TabIndex = 9;
            this.Button_product.Text = "Склад";
            this.Button_product.Click += new System.EventHandler(this.Button_product_Click);
            // 
            // Button_seller
            // 
            this.Button_seller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_seller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_seller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_seller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_seller.FillColor = System.Drawing.Color.Transparent;
            this.Button_seller.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_seller.ForeColor = System.Drawing.Color.SlateBlue;
            this.Button_seller.Location = new System.Drawing.Point(-1, 35);
            this.Button_seller.Name = "Button_seller";
            this.Button_seller.Size = new System.Drawing.Size(161, 48);
            this.Button_seller.TabIndex = 8;
            this.Button_seller.Text = "Продавцы";
            this.Button_seller.Click += new System.EventHandler(this.Button_seller_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Black", 16.75F, System.Drawing.FontStyle.Bold);
            this.label_exit.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_exit.Location = new System.Drawing.Point(1058, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(30, 31);
            this.label_exit.TabIndex = 7;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView_cash);
            this.panel1.Controls.Add(this.dataGridView_sell_product);
            this.panel1.Controls.Add(this.label_name_seller);
            this.panel1.Controls.Add(this.Button_sell);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.TextBox_search);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.Button_search);
            this.panel1.Controls.Add(this.ComboBox_search);
            this.panel1.Controls.Add(this.Button_create);
            this.panel1.Controls.Add(this.TextBox_amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(166, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 468);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Отчет о продажах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(337, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Чек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(337, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Склад";
            // 
            // dataGridView_cash
            // 
            this.dataGridView_cash.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cash.Location = new System.Drawing.Point(32, 104);
            this.dataGridView_cash.Name = "dataGridView_cash";
            this.dataGridView_cash.ReadOnly = true;
            this.dataGridView_cash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cash.Size = new System.Drawing.Size(273, 337);
            this.dataGridView_cash.TabIndex = 25;
            // 
            // dataGridView_sell_product
            // 
            this.dataGridView_sell_product.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_sell_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sell_product.Location = new System.Drawing.Point(339, 316);
            this.dataGridView_sell_product.Name = "dataGridView_sell_product";
            this.dataGridView_sell_product.ReadOnly = true;
            this.dataGridView_sell_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sell_product.Size = new System.Drawing.Size(510, 125);
            this.dataGridView_sell_product.TabIndex = 24;
            // 
            // label_name_seller
            // 
            this.label_name_seller.AutoSize = true;
            this.label_name_seller.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold);
            this.label_name_seller.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name_seller.Location = new System.Drawing.Point(89, 29);
            this.label_name_seller.Name = "label_name_seller";
            this.label_name_seller.Size = new System.Drawing.Size(144, 28);
            this.label_name_seller.TabIndex = 23;
            this.label_name_seller.Text = "Администратор";
            // 
            // Button_sell
            // 
            this.Button_sell.BackColor = System.Drawing.Color.SlateBlue;
            this.Button_sell.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_sell.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_sell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_sell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_sell.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_sell.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_sell.ForeColor = System.Drawing.Color.White;
            this.Button_sell.Location = new System.Drawing.Point(737, 248);
            this.Button_sell.Name = "Button_sell";
            this.Button_sell.Size = new System.Drawing.Size(114, 45);
            this.Button_sell.TabIndex = 22;
            this.Button_sell.Text = "Продать";
            this.Button_sell.Click += new System.EventHandler(this.Button_sell_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold);
            this.label_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_date.Location = new System.Drawing.Point(771, 11);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(101, 28);
            this.label_date.TabIndex = 21;
            this.label_date.Text = "12.03.2022";
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
            this.TextBox_search.Location = new System.Drawing.Point(526, 42);
            this.TextBox_search.Name = "TextBox_search";
            this.TextBox_search.PasswordChar = '\0';
            this.TextBox_search.PlaceholderText = "";
            this.TextBox_search.SelectedText = "";
            this.TextBox_search.Size = new System.Drawing.Size(207, 36);
            this.TextBox_search.TabIndex = 20;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(339, 104);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.ReadOnly = true;
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(510, 116);
            this.dataGridView_product.TabIndex = 19;
            this.dataGridView_product.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_product_RowHeaderMouseClick);
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
            this.Button_search.Location = new System.Drawing.Point(739, 33);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(99, 45);
            this.Button_search.TabIndex = 18;
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
            "Номер",
            "Артикул",
            "Название",
            "Цена",
            "Количество",
            "Носитель",
            "Категория",
            "Показать все"});
            this.ComboBox_search.Location = new System.Drawing.Point(339, 42);
            this.ComboBox_search.Name = "ComboBox_search";
            this.ComboBox_search.Size = new System.Drawing.Size(170, 36);
            this.ComboBox_search.TabIndex = 17;
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
            this.Button_create.Location = new System.Drawing.Point(539, 248);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(165, 45);
            this.Button_create.TabIndex = 11;
            this.Button_create.Text = "Добавить в чек";
            this.Button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // TextBox_amount
            // 
            this.TextBox_amount.BorderRadius = 15;
            this.TextBox_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_amount.DefaultText = "";
            this.TextBox_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_amount.Location = new System.Drawing.Point(375, 251);
            this.TextBox_amount.Name = "TextBox_amount";
            this.TextBox_amount.PasswordChar = '\0';
            this.TextBox_amount.PlaceholderText = "";
            this.TextBox_amount.SelectedText = "";
            this.TextBox_amount.Size = new System.Drawing.Size(158, 36);
            this.TextBox_amount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(337, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(333, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПРОДАЖИ";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 535);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Button_product);
            this.Controls.Add(this.Button_seller);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button_exit;
        private Guna.UI2.WinForms.Guna2Button Button_product;
        private Guna.UI2.WinForms.Guna2Button Button_seller;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private Guna.UI2.WinForms.Guna2Button Button_search;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_search;
        private Guna.UI2.WinForms.Guna2Button Button_create;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name_seller;
        private Guna.UI2.WinForms.Guna2Button Button_sell;
        private System.Windows.Forms.DataGridView dataGridView_sell_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_cash;
        private System.Windows.Forms.Label label5;
    }
}