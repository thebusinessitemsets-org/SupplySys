using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.DataCenter
{
    public class STOCK01ViewModel
    {
        public int Id { get; set; }
        public string STOCK_ID { get; set; }
        public string PROD_ID { get; set; }
        public string STOCK_UNIT_QUAN { get; set; }
        public string STOCK_UNIT_QUAN1 { get; set; }
        public string STOCK_UNIT_QUAN2 { get; set; }
        public int USABLE { get; set; }
        public string Meno { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public string SHOP_ID { get; set; }
        public decimal COST { get; set; }
        public decimal COST1 { get; set; }
        public decimal COST2 { get; set; }
    }
}
