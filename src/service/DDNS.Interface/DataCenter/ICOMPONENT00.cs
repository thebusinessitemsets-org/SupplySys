using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface ICOMPONENT00
    {
        Task<bool> AddCOMPONENT00s(List<COMPONENT00Entity> cOMPONENT00Entities);
        Task<bool> DelCOMPONENT00(int id);
        Task<bool> UpdateCOMPONENT00(COMPONENT00Entity cOMPONENT00Entity);
        Task<COMPONENT00Entity> COMPONENT00(int id);
        Task<IEnumerable<COMPONENT00Entity>> COMPONENT00List();
    }
}
