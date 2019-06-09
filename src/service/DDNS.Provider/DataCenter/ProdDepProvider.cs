using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class ProdDepProvider : IProdDep
    {
        public readonly ProdDepDataModel _data;
        public ProdDepProvider(ProdDepDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddProdDep(ProdDepEntity prodDepEntity)
        {
            return _data.AddProdDep(prodDepEntity);
        }

        public Task<bool> DelProdDep(int ID)
        {
            return _data.DelProdDep(ID);
        }

        public Task<bool> UpdateProdDep(ProdDepEntity prodDepEntity)
        {
            return _data.UpdateProdDep(prodDepEntity);
        }

        public Task<ProdDepEntity> ProdDep(int id)
        {
            return _data.ProdDep(id);
        }

        public Task<IEnumerable<ProdDepEntity>> ProdDepList()
        {
            return _data.ProdDepList();
        }
    }
}
