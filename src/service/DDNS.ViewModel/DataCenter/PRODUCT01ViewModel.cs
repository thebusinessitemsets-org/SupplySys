using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.DataCenter
{
    public class PRODUCT01ViewModel
    {
        public int Id { get; set; }
        public string PRCAREA_ID { get; set; }
        public string SUP_ID { get; set; }
        public int SEND_TYPE { get; set; }
        public int TAX_TYPE { get; set; }
        public int Tax { get; set; }
        public decimal SUP_COST { get; set; }
        public decimal SUP_COST1 { get; set; }
        public decimal SUP_COST2 { get; set; }
        public decimal SUP_Return { get; set; }
        public decimal SUP_Return1 { get; set; }
        public decimal SUP_Return2 { get; set; }
        public decimal U_Cost { get; set; }
        public decimal U_Cost1 { get; set; }
        public decimal U_Cost2 { get; set; }
        public decimal U_Ret_COST { get; set; }
        public decimal U_Ret_COST1 { get; set; }
        public decimal U_Ret_COST2 { get; set; }
        public decimal T_Cost { get; set; }
        public decimal T_Cost1 { get; set; }
        public decimal T_Cost2 { get; set; }
        public decimal T_Ret_Cost { get; set; }
        public decimal T_Ret_Cost1 { get; set; }
        public decimal T_Ret_Cost2 { get; set; }
        public decimal COST { get; set; }
        public decimal COST1 { get; set; }
        public decimal COST2 { get; set; }
        public int ENABLE { get; set; }
        public int VISIBLE { get; set; }
        public string BOM_ID { get; set; }
        public DateTime CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public DateTime MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
        public int ORDER_UNIT { get; set; }
        public int ORDER_QUAN { get; set; }
        public int Purchase_UNIT { get; set; }
        public int Purchase_QUAN { get; set; }
        public int SAFE_QUAN { get; set; }
        public decimal PROD_PRICE { get; set; }
    }
}
