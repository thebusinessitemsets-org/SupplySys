using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface ISTOCK00
    {
        Task<bool> AddSTOCK00s(List<STOCK00Entity>  sTOCK00Entities);
        Task<bool> DelSTOCK00(int id);
        Task<bool> UpdateSTOCK00(STOCK00Entity  sTOCK00Entity);
        Task<STOCK00Entity> STOCK00(int id);
        Task<IEnumerable<STOCK00Entity>> STOCK00List();
    }
}
