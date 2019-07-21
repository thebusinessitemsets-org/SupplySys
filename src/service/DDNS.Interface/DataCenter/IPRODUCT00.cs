using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface IPRODUCT00
    {
        Task<bool> AddPRODUCT00s(List<PRODUCT00Entity> pRODUCT00Entities);
        Task<bool> DelPRODUCT00(int id);
        Task<bool> UpdatePRODUCT00(PRODUCT00Entity pRODUCT00Entity);
        Task<PRODUCT00Entity> PRODUCT00(int id);
        Task<IEnumerable<PRODUCT00Entity>> PRODUCT00List();
    }
}
