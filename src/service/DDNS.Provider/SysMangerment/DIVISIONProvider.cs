using DDNS.DataModel.SysMangerment;
using DDNS.Entity.SysMangerment;
using DDNS.Interface.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SysMangerment
{
    public class DIVISIONProvider:IDIVISION
    {
        private readonly DIVISIONDataModel _data;
        public DIVISIONProvider(DIVISIONDataModel data)
        {
            _data = data;
        }

        public Task<bool> Add(DIVISIONEntity dIVISIONEntity)
        {
            return _data.Add(dIVISIONEntity);
        }

        public Task<bool> Del(int id)
        {
            return _data.Del(id);
        }

        public Task<bool> Update(DIVISIONEntity dIVISIONEntity)
        {
            return _data.Update(dIVISIONEntity);
        }

        public Task<DIVISIONEntity> Get(int id)
        {
            return _data.Get(id);
        }

        public Task<IEnumerable<DIVISIONEntity>> Get(string divName)
        {
            return _data.Get(divName);
        }

    }
}
