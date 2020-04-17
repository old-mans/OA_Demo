using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Userid { get; set; }
        /// <summary>
        /// 用户账户
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
    }
}
