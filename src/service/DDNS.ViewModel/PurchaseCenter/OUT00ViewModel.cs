using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.PurchaseCenter
{
    public class OUT00ViewModel
    {
        public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string OUT_ID { get; set; }
        public int STATUS { get; set; }
        public DateTime INPUT_DATE { get; set; }
        public string IN_SHOP { get; set; }
        public string STOCK_ID { get; set; }
        public string USER_ID { get; set; }
        public string APP_USER { get; set; }
        public DateTime APP_DATETIME { get; set; }
        public DateTime EXPECT_DATE { get; set; }
        public int Exported { get; set; }
        public string Exported_ID { get; set; }
        public int RELATE_ID { get; set; }
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
