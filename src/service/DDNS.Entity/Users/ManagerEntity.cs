using System;

namespace DDNS.Entity.Users
{
    public class ManagerEntity
    {
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginTime { get; set; }
        public int BranchID { get; set; }
        public int BranchType { get; set; }
        public int SHOP_ID { get; set; }
        public int DIVISION_ID { get; set; }
        public int IsEnable { get; set; }
        public string EMP_ID { get; set; }
        public string EMP_NAME { get; set; }
        public string EMP_Birthday { get; set; }
        public string EMP_ADD { get; set; }
        public string EMP_TEL { get; set; }
        public string EMP_ZIP { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_MOBILE { get; set; }
        public string EMP_MEMO { get; set; }
        public int EMP_ENABLE { get; set; }
        public int EMP_SEX { get; set; }
        public string EMP_CodeID { get; set; }
        public int EMP_LEVEL { get; set; }
        public string EMP_BDATE { get; set; }
        public string EMP_EDATE { get; set; }
        public decimal EMP_WAGE { get; set; }
        public int EMP_Education { get; set; }
        public string CRT_DATETIME { get; set; }
        public string CRT_USER_ID { get; set; }
        public string MOD_DATETIME { get; set; }
        public string MOD_USER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public int STATUS { get; set; }
    }
}