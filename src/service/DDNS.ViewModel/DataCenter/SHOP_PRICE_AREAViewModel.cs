using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.DataCenter
{
    public class SHOP_PRICE_AREAViewModel
    {
        public int Id { get; set; }
        public string PRCAREA_ID { get; set; }
        public string PRCAREA_NAME { get; set; }
        public int ENABLE { get; set; }
        public string PRCAREA_MEMO { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MODE_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
    }
}
