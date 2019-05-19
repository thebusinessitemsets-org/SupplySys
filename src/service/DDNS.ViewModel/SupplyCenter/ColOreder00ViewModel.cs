using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.SupplyCenter
{
    public class ColOreder00ViewModel
    {
        public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string COL_ID { get; set; }
        public DateTime INPUT_DATE { get; set; }
        public string ORD_USER { get; set; }
        public DateTime EXPECT_DATE { get; set; }
        public int STATUS { get; set; }
        public int PROD_TYPE { get; set; }
        public int ORD_TYPE { get; set; }
        public string ORD_DEP_ID { get; set; }
        public DateTime COL_BeginDate { get; set; }
        public DateTime COL_EndDate { get; set; }
        public string APP_USER { get; set; }
        public DateTime APP_DATE { get; set; }
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
