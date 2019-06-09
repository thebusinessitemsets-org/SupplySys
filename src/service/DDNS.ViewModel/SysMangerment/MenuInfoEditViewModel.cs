using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.ViewModel.SysMangerment
{
    public class MenuInfoEditViewModel
    {
        //public int ID { get; set; }
        public string NAME { get; set; }
        public string URL { get; set; }
        public int ParentID { get; set; }
        public int Sort { get; set; }
        public int Depth { get; set; }
        public int IsDisplay { get; set; }
        public int IsMenu { get; set; }
    }
}
