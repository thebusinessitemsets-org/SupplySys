using DDNS.DataModel.SysMangerment;
using DDNS.Entity.SysMangerment;
using DDNS.Interface.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SysMangerment
{
    public class BranchProvider:IBranch
    {
        private readonly BranchDataModel _data;
        public BranchProvider(BranchDataModel data)
        {
            _data = data;
        }

        public Task<bool> Add(BranchEntity branchEntity)
        {
            return _data.Add(branchEntity);
        }

        public Task<bool> Del(int id)
        {
            return _data.Del(id);
        }

        public Task<bool> Update(BranchEntity branchEntity)
        {
            return _data.Update(branchEntity);
        }

        public Task<BranchEntity> Get(int id)
        {
            return _data.Get(id);
        }

        public Task<IEnumerable<BranchEntity>> Get(string name)
        {
            return _data.Get(name);
        }


    }
}
