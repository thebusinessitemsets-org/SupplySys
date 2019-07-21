using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.PurchaseCenter
{
    public class IN01Entity
    {
        public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string IN_ID { get; set; }
        public int SNo { get; set; }
        public string PROD_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public string STD_UNIT { get; set; }
        public int STD_CONVERT { get; set; }
        public decimal STD_QUAN { get; set; }
        public decimal STD_PRICE { get; set; }
        public decimal COST { get; set; }
        public decimal QUAN1 { get; set; }
        public decimal QUAN2 { get; set; }
        public string MEMO { get; set; }
        public string BAT_NO { get; set; }
        public DateTime Exp_DateTime { get; set; }
    }
}
