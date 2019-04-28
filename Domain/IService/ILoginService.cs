using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IService
{
    public interface ILoginService
    {
        /// <summary>
        /// 检验是否登录成功
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task CheckLoginInfo(string userName, string password);
    }
}
