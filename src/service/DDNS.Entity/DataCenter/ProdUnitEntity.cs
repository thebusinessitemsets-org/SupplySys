using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.DataCenter
{
    public class ProdUnitEntity
    {
        public int Id { get; set; }
        public string UNIT_ID { get; set; }
        public string UNIT_NAME { get; set; }
        public string UNIT_MEMO { get; set; }
        public string CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public string MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public string LAST_UPDATEp { get; set; }
        public int STATUS { get; set; }
    }
}
