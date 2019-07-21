using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.PurchaseCenter
{
    public class Purchase00Entity
    {
        public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string Purchase_ID { get; set; }
        public int STATUS { get; set; }
        public int PAT_STATUS { get; set; }
        public DateTime INPUT_DATE { get; set; }
        public string SUP_ID { get; set; }
        public DateTime EXPECT_DATE { get; set; }
        public string USER_ID { get; set; }
        public string APP_USER { get; set; }
        public DateTime APP_DATETIME { get; set; }
        public decimal TOT_AMOUNT { get; set; }
        public decimal TOT_TAX { get; set; }
        public decimal TOT_QTY { get; set; }
        public decimal PRE_PAY { get; set; }
        public string PER_PAY_ID { get; set; }
        public int EXPORTED { get; set; }
        public int EXPORTED_ID { get; set; }
        public string Memo { get; set; }
        public int LOCKED { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int Trans_STATUS { get; set; }
    }
}
