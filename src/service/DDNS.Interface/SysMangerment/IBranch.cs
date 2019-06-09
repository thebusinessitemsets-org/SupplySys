using DDNS.Entity.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SysMangerment
{
    public interface IBranch
    {
        Task<bool> Add(BranchEntity branchEntity);
        Task<bool> Del(int id);
        Task<bool> Update(BranchEntity branchEntity);
        Task<BranchEntity> Get(int id);
        Task<IEnumerable<BranchEntity>> Get(string name);
    }
}
