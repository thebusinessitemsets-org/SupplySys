using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.SupplyCenter
{
    public class ColOrder01EditViewModel
    {
        public string SHOP_ID { get; set; }
        public string COL_ID { get; set; }
        public int SNo { get; set; }
        public string PROD_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal COST_PRICE { get; set; }
        public decimal STD_UNIT { get; set; }
        public int STD_CONVERT { get; set; }
        public decimal STD_QUAN { get; set; }
        public decimal STD_PRICE { get; set; }
    }
}
