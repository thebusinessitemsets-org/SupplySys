using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SupplyCenter
{
    public interface IColOrder01
    {
        Task<bool> AddColOrder01(ColOrder01Entity colorder01Entity);
        //Task<bool> DelColOrder01(int id);
        Task<bool> UpdateColOrder01(ColOrder01Entity colorder01Entity);
        Task<ColOrder01Entity> ColOrder01(int id);
        Task<IEnumerable<ColOrder01Entity>> ColOrder01List(int id);
    }
}
