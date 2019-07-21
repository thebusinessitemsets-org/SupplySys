using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface ISTOCK01
    {
        Task<bool> AddSTOCK01s(List<STOCK01Entity> sTOCK01Entities);
        Task<bool> DelSTOCK01(int id);
        Task<bool> UpdateSTOCK01(STOCK01Entity sTOCK01Entity);
        Task<STOCK01Entity> STOCK01(int id);
        Task<IEnumerable<STOCK01Entity>> STOCK01List();
    }
}
