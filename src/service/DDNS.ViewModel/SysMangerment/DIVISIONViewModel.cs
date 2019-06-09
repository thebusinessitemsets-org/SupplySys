using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.SysMangerment
{
    public class DIVISIONViewModel
    {
        //public int Id { get; set; }
        public string DIV_ID { get; set; }
        public string DIV_NAME { get; set; }
        public int DIV_TYPE { get; set; }
        public string STOCK_ID { get; set; }
        public string DIV_MEMO { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
    }
}
