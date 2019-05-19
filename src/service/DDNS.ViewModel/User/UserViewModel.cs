using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string LoginPass { get; set; }
        public DateTime LoginTime { get; set; }
        public string LoginIp { get; set; }
        public int LoginCount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int IsMultiUser { get; set; }
        public int Branch_Id { get; set; }
        public string Branch_Code { get; set; }
        public string Branch_Name { get; set; }
        public string Position_Id { get; set; }
        public string Position_Name { get; set; }
        public int IsWork { get; set; }
        public int IsEnable { get; set; }
        public string CName { get; set; }
        public string EName { get; set; }
        public string PhotoImg { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public string NativePlace { get; set; }
        public string NationalName { get; set; }
        public string Record { get; set; }
        public string GraduateCollege { get; set; }
        public string GraduateSpecialty { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Qq { get; set; }
        public string Msn { get; set; }
        public string Address { get; set; }
        public string Content { get; set; }
        public int Manager_Id { get; set; }
        public string Manager_CName { get; set; }
        public string SHOP_ID { get; set; }
        public string SHOP_NAME1 { get; set; }
    }
}
