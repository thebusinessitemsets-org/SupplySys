using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.DataCenter
{
    public class ProdDepEntity
    {
        public int Id { get; set; }
        public string DEP_ID { get; set; }
        public string DEP_NAME { get; set; }
        public int ENABLE { get; set; }
        public string KIND_ID { get; set; }
        public int IsBool1 { get; set; }
        public int IsBool2 { get; set; }
        public int IsBool3 { get; set; }
        public string DEP_MEMO { get; set; }
        public string CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public string MODE_DATETIME { get; set; }
        public string MODE_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
    }
}
