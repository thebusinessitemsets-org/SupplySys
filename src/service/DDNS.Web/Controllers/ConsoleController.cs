﻿using DDNS.Provider.LoginLog;
using DDNS.Provider.Users;
using DDNS.ViewModel.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DDNS.Web.Controllers
{
    [Authorize]
    public class ConsoleController : Controller
    {
        private readonly ManagerProvider _usersProvider;
        private readonly LoginLogProvider _loginLogProvider;

        public ConsoleController(ManagerProvider usersProvider, LoginLogProvider loginLogProvider)
        {
            _usersProvider = usersProvider;
            _loginLogProvider = loginLogProvider;
        }

        /// <summary>
        /// 框架页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirst(u => u.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _usersProvider.GetUserInfo(Convert.ToInt32(userId));

            return View(user);
        }

        /// <summary>
        /// 默认显示页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Home()
        {
            var userId = HttpContext.User.FindFirst(u => u.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _usersProvider.GetUserInfo(Convert.ToInt32(userId));

            var log = await _loginLogProvider.GetLastLoginLog(Convert.ToInt32(userId));

            var info = new UserInfoViewModel
            {
                LoginName = user.LoginName,
                EMP_EMAIL = user.EMP_EMAIL
              
            };
             
            return View(info);
        }
    }
}