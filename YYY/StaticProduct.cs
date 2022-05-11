using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYY
{
    class StaticProduct
    {
        public static int number_chek=0;
        public static string name_seller;
        public static int number_seller;
        public static int number_count = 50;
        public static int count_product = 0;
        public static int number_sell_count = 50;
        public static int count_sell_product = 0;
        public static int number_seller_count = 10;
        public static int count_seller = 0;
        public static int number_cash_count = 50;
        public static int count_cash = 0;
        public static Product[] products = new Product[number_count];
        public static SellerClass[] sellers = new SellerClass[number_seller_count];
        public static SellProduct[] sellproducts = new SellProduct[number_sell_count];
        public static Cash[] cashs = new Cash[number_cash_count];
    }
    
}
