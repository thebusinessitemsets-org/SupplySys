using DDNS.Entity;
using DDNS.Entity.Users;
using DDNS.Utility;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDNS.DataModel.Users
{
    public class ManagerDataModel
    {
        private readonly DDNSDbContext _content;
        public ManagerDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddUser(ManagerEntity user)
        {
            await _content.Manager.AddAsync(user);
            return await _content.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUser(int id)
        {
            var _user = await _content.Manager.FindAsync(id);
            if (_user != null)
            {
                _user.IsEnable = (int)ManagerDeleteEnum.Deleted;
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DisableUser(int id)
        {
            var _user = await _content.Manager.FindAsync(id);
            if (_user != null)
            {
                _user.IsEnable = (int)ManagerStatusEnum.Disable;
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        /// <summary>
        /// 解除禁用
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> RemoveDisable(int id)
        {
            var _user = await _content.Manager.FindAsync(id);
            if (_user != null)
            {
                _user.IsEnable = (int)ManagerStatusEnum.Normal;
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUser(ManagerEntity user)
        {
            var _user = await _content.Manager.FindAsync(user.ID);
            if (_user != null)
            {
                _user = user;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ManagerEntity> GetUserInfo(int id)
        {
            return await _content.Manager.FindAsync(id);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<ManagerEntity> GetUserInfo(string userName, string password)
        {
            var user = await _content.Manager.FirstOrDefaultAsync(u => (u.LoginName == userName || u.EMP_EMAIL == userName) && u.LoginPassword == MD5Util.TextToMD5(password) && u.STATUS == 1);


            return await _content.Manager.FirstOrDefaultAsync(u => (u.LoginName == userName || u.EMP_EMAIL == userName) && u.LoginPassword == MD5Util.TextToMD5(password) && u.STATUS == 1);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<ManagerEntity> GetUserInfo(string userName)
        {
            try {
                return await _content.Manager.FirstOrDefaultAsync(u => u.LoginName == userName || u.EMP_EMAIL == userName);
            }
            catch (System.Exception ex)
            {
                string err = ex.Message;
            }

            return await _content.Manager.FirstOrDefaultAsync(u => u.LoginName == userName || u.EMP_EMAIL == userName);

        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ManagerEntity>> UserList(string userName = null, string email = null, int status = 0, string token = null)
        {
            var list = await _content.Manager.Where(x => x.IsEnable == (int)ManagerDeleteEnum.Normal).ToListAsync();

            if (!string.IsNullOrEmpty(userName))
            {
                list = list.Where(x => x.LoginName.Contains(userName)).ToList();
            }
            if (!string.IsNullOrEmpty(email))
            {
                list = list.Where(x => x.EMP_EMAIL.Contains(email)).ToList();
            }
             

            list = list.Where(x => x.IsEnable == status).OrderByDescending(x => x.LoginTime).ToList();

            return list;
        }
         

    }
}