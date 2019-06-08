using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.SupplyCenter
{
    public class Order01ViewModel
    {
        //public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string ORDER_ID { get; set; }
        public int SNo { get; set; }
        public string PROD_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal ON_QUAN { get; set; }
        public decimal QUAN1 { get; set; }
        public decimal QUAN2 { get; set; }
        public decimal COST_PRICE { get; set; }
        public decimal STD_UNIT { get; set; }
        public int STD_CONVERT { get; set; }
        public decimal STD_QUAN { get; set; }
        public decimal STD_PRICE { get; set; }
        public string Memo { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
    }
}
