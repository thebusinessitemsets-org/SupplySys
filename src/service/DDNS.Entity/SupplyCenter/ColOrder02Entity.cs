﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.SupplyCenter
{
    public class ColOrder02Entity
    {
        public int Id { get; set; }
        public string SHOP_ID { get; set; }
        public string COL_ID { get; set; }
        public int SNo { get; set; }
        public string Import_Shop { get; set; }
        public string PROD_ID { get; set; }
        public decimal OUT_QUAN { get; set; }
        public decimal SUP_QUAN { get; set; }
        public decimal STD_QUAN { get; set; }

    }
}
