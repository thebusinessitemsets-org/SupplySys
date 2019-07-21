using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface IPRODUCT01
    {
        Task<bool> AddPRODUCT01s(List<PRODUCT01Entity> pRODUCT01Entities);
        Task<bool> DelPRODUCT01(int id);
        Task<bool> UpdatePRODUCT01(PRODUCT01Entity pRODUCT01Entity);
        Task<PRODUCT01Entity> PRODUCT01(int id);
        Task<IEnumerable<PRODUCT01Entity>> PRODUCT01List();
    }
}
