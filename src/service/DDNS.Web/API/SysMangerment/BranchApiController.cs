using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.SysMangerment;
using DDNS.Provider.LoginLog;
using DDNS.Provider.SysMangerment;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.SysMangerment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.API.SysMangerment
{
    [Route("api")]
    [ApiController]
    public class BranchApiController : ControllerBase
    {
        private readonly BranchProvider _branchProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<BranchApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public BranchApiController(BranchProvider branchProvider, LoginLogProvider loginLogProvider, IStringLocalizer<BranchApiController> localizer, IOptions<TunnelConfig> config)
        {
            _branchProvider = branchProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("addBranch")]
        public async Task<ResponseViewModel<bool>> AddBranch(BranchViewModel branchViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var branch = new BranchEntity
            {
                Code = branchViewModel.Code,
                Name = branchViewModel.Name,
                Level = branchViewModel.Level

            };

            data.Data = await _branchProvider.Add(branch);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("delBranch")]
        public async Task<ResponseViewModel<bool>> DelBranch(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _branchProvider.Del(id)
            };

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchEditViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("updateBranch")]
        public async Task<ResponseViewModel<bool>> UpdateBranch(int id, BranchEditViewModel branchEditViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var branch = await _branchProvider.Get(id);

            branch.Code = branchEditViewModel.Code;
            branch.Name = branchEditViewModel.Name;
            branch.Level = branchEditViewModel.Level;

            data.Data = await _branchProvider.Update(branch);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBranch")]
        public async Task<BranchEntity> Get(int id)
        {
            return await _branchProvider.Get(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBranchList")]
        public async Task<IEnumerable<BranchEntity>> Get(string name)
        {
            var list = await _branchProvider.Get(name);

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;

        }
    }
}