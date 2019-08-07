using DDNS.Entity.AppSettings;
using DDNS.Entity.Users;
using DDNS.Provider.LoginLog;
using DDNS.Provider.Users;
using DDNS.Utility;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.User;
using DDNS.Web.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDNS.Web.API.Users
{
    [Route("api")]
    [ApiController]
    [Authorize]
    [PermissionFilter]
    public class UsersApiController : ControllerBase
    {
        private readonly ManagerProvider _usersProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<UsersApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public UsersApiController(ManagerProvider usersProvider, LoginLogProvider loginLogProvider, IStringLocalizer<UsersApiController> localizer, IOptions<TunnelConfig> config)
        {
            _usersProvider = usersProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("users")]
        public async Task<ResponseViewModel<List<UsersViewModel>>> Users(int page, int limit, string userName, string email, int status,string token)
        {
            var users = new List<UsersViewModel>();

            var list = await _usersProvider.UserList(userName, email, status, token);

            var curList = list.ToList().Skip(limit * (page - 1)).Take(limit).ToList();
            curList.ForEach(x =>
            {
                var vm = new UsersViewModel
                {
                    ID = x.ID
                    ,LoginName= x.LoginName
                    ,LoginPassword= x.LoginPassword
                    ,LoginTime= x.LoginTime
                    //,BranchID= x.BranchID
                    ,BranchType= x.BranchType
                    ,SHOP_ID= x.SHOP_ID
                    ,DIVISION_ID= x.DIVISION_ID
                    ,IsEnable= x.IsEnable
                    ,EMP_ID= x.EMP_ID
                    ,EMP_NAME= x.EMP_NAME
                    ,EMP_Birthday= x.EMP_Birthday
                    ,EMP_ADD= x.EMP_ADD
                    ,EMP_TEL= x.EMP_TEL
                    ,EMP_ZIP= x.EMP_ZIP
                    ,EMP_EMAIL= x.EMP_EMAIL
                    ,EMP_MOBILE= x.EMP_MOBILE
                    ,EMP_MEMO= x.EMP_MEMO
                    ,EMP_ENABLE= x.EMP_ENABLE
                    ,EMP_SEX= x.EMP_SEX
                    ,EMP_CodeID= x.EMP_CodeID
                    ,EMP_LEVEL= x.EMP_LEVEL
                    ,EMP_BDATE= x.EMP_BDATE
                    ,EMP_EDATE= x.EMP_EDATE
                    ,EMP_WAGE= x.EMP_WAGE
                    ,EMP_Education= x.EMP_Education
 
                };

                users.Add(vm);
            });

            var result = new ResponseViewModel<List<UsersViewModel>>
            {
                Count = list.ToList().Count,
                Data = users
            };

            return result;
        }
         

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add_user")]
        public async Task<ResponseViewModel<bool>> AddUser(EditUserViewModel vm)
        {
            var data = new ResponseViewModel<bool>();

            var _user = await _usersProvider.GetUserInfo(vm.LoginName);
            if (_user != null)
            {
                data.Code = 1;
                data.Msg = _localizer["username"];

                return data;
            }
            _user = await _usersProvider.GetUserInfo(vm.EMP_EMAIL);
            if (_user != null)
            {
                data.Code = 1;
                data.Msg = _localizer["email"];

                return data;
            }

            var user = new ManagerEntity
            { 
                LoginName = vm.LoginName
                ,LoginPassword = vm.LoginPassword
                    ,
                LoginTime = vm.LoginTime
                    //,
                //BranchID = vm.BranchID
                    ,
                BranchType = vm.BranchType
                    ,
                SHOP_ID = vm.SHOP_ID
                    ,
                DIVISION_ID = vm.DIVISION_ID
                    ,
                IsEnable = vm.IsEnable
                    ,
                EMP_ID = vm.EMP_ID
                    ,
                EMP_NAME = vm.EMP_NAME
                    ,
                EMP_Birthday = vm.EMP_Birthday
                    ,
                EMP_ADD = vm.EMP_ADD
                    ,
                EMP_TEL = vm.EMP_TEL
                    ,
                EMP_ZIP = vm.EMP_ZIP
                    ,
                EMP_EMAIL = vm.EMP_EMAIL
                    ,
                EMP_MOBILE = vm.EMP_MOBILE
                    ,
                EMP_MEMO = vm.EMP_MEMO
                    ,
                EMP_ENABLE = vm.EMP_ENABLE
                    ,
                EMP_SEX = vm.EMP_SEX
                    ,
                EMP_CodeID = vm.EMP_CodeID
                    ,
                EMP_LEVEL = vm.EMP_LEVEL
                    ,
                EMP_BDATE = vm.EMP_BDATE
                    ,
                EMP_EDATE = vm.EMP_EDATE
                    ,
                EMP_WAGE = vm.EMP_WAGE
                    ,
                EMP_Education = vm.EMP_Education
            };

            data.Data = await _usersProvider.AddUser(user);

            return data;
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("edit_user")]
        public async Task<ResponseViewModel<bool>> EditUser(int userId, EditUserViewModel vm)
        {
            var data = new ResponseViewModel<bool>();

            var user = await _usersProvider.GetUserInfo(userId);

            if (vm.LoginName != user.LoginName)
            {
                if (await _usersProvider.GetUserInfo(vm.LoginName) != null)
                {
                    data.Code = 1;
                    data.Msg = _localizer["username"];

                    return data;
                }
            }
            if (vm.EMP_EMAIL != user.EMP_EMAIL)
            {
                if (await _usersProvider.GetUserInfo(vm.EMP_EMAIL) != null)
                {
                    data.Code = 1;
                    data.Msg = _localizer["email"];

                    return data;
                }
            }

            user.LoginName = vm.LoginName;
            user.EMP_EMAIL = vm.EMP_EMAIL;
            if (!string.IsNullOrEmpty(vm.LoginPassword))
            {
                user.LoginPassword = MD5Util.TextToMD5(vm.LoginPassword);
            }

            data.Data = await _usersProvider.UpdateUser(user);

            return data;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("del_user")]
        public async Task<ResponseViewModel<bool>> DeleteUser(int userId)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _usersProvider.DeleteUser(userId)
            };

            return data;
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("disable_user")]
        public async Task<ResponseViewModel<bool>> DisableUser(int userId)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _usersProvider.DisableUser(userId)
            };

            return data;
        }

        /// <summary>
        /// 解除禁用
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("remove_disable")]
        public async Task<ResponseViewModel<bool>> RemoveDisable(int userId)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _usersProvider.RemoveDisable(userId)
            };

            return data;
        }

        /// <summary>
        /// 重置Token
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("reset_token")]
        public async Task<ResponseViewModel<bool>> ResetToken(int userId)
        {
            var data = new ResponseViewModel<bool>();

            var user = await _usersProvider.GetUserInfo(userId);
            if (user != null)
            {
                //var oldToken = user.AuthToken;
                //var newToken = GuidUtil.GetGuid();

                //try
                //{
                //    await FileUtil.ResetUserToken(_tunnelConfig.FilePath, oldToken, newToken);
                //}
                //catch (Exception e)
                //{
                //    data.Code = 1;
                //    data.Msg = e.Message;

                //    return data;
                //}

                //user.AuthToken = newToken;
            }

            data.Data = await _usersProvider.UpdateUser(user);

            return data;
        }
    }
}