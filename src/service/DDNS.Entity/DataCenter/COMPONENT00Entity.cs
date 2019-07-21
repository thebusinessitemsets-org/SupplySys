using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.DataCenter
{
    public class COMPONENT00Entity
    {
        public int Id { get; set; }
        public string COM_ID { get; set; }
        public string PROD_ID { get; set; }
        public int Num { get; set; }
        public decimal WEIGHT { get; set; }
        public int DefaultCOM { get; set; }
        public int QUAN1 { get; set; }
        public int QUAN2 { get; set; }
        public int DefQuan { get; set; }
        public decimal BOM_Cost { get; set; }
        public DateTime ExpDateTime { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
    }
}
