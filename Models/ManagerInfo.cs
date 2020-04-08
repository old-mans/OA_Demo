using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 人员登陆表
    /// </summary>
    public class ManagerInfo
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ManagerId { get; set; }
        /// <summary>
        /// 登陆人名称
        /// </summary>
        public int LoginName { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public int ComID { get; set; }

    }
}
