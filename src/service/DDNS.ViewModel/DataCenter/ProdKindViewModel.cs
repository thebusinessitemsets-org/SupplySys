using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.DataCenter
{
    public class ProdKindViewModel
    {
        public int Id { get; set; }
        public string KIND_ID { get; set; }
        public string KIND_NAME { get; set; }
        public int ENABLE { get; set; }
        public int ISBOM { get; set; }
        public int IsBool { get; set; }
        public string KIND_MEMO { get; set; }
        public string CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public string MODE_DATETIME { get; set; }
        public string MODE_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
    }
}
