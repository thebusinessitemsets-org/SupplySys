using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Entity.SysMangerment
{
    public class WebLogEntity
    {
        public int ID { get; set; }
        public int ManagerID{ get; set; }
        public string CNAME{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Notes{ get; set; }

    }
}
