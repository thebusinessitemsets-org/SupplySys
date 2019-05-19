using DDNS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.DataModel.SupplyCenter
{
    public class ColOrder01DataModel
    {
        private readonly DDNSDbContext _content;

        public ColOrder01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

    }
}
