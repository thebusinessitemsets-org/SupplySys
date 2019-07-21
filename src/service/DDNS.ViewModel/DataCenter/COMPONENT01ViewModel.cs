using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.DataCenter
{
    public class COMPONENT01ViewModel
    {
        public int Id { get; set; }
        public string COM_ID { get; set; }
        public string DETAIL_ID { get; set; }
        public string PROD_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal LQUANTITY { get; set; }
        public string New_PROD_ID { get; set; }
        public int IsScales { get; set; }
        public int PrtTag { get; set; }
        public int IsFlag { get; set; }
        public string Meno { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MODE_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
    }
}
