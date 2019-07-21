using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.DataCenter
{
    public class STOCK00Entity
    {
        public int Id { set; get; }
        public string SHOP_ID { set; get; }
        public string STOCK_ID { set; get; }
        public string STOCK_NAME { set; get; }
        public string IsDefBill { set; get; }
        public int IsBool { set; get; }
        public string Memo { set; get; }
        public DateTime CRT_DATETIME { set; get; }
        public string CRT_USER_ID { set; get; }
        public DateTime MOD_DATETIME { set; get; }
        public string MOD_USER_ID { set; get; }
        public DateTime LAST_UPDATE { set; get; }
        public int Stock_Kind { set; get; }
    }
}
