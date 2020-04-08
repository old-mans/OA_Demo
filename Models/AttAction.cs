using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 活动表  考勤表
    /// </summary>
    public class AttAction
    {
        /// <summary>
        /// 员工号
        /// </summary>
        public int ActionID { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public int Employeeid { get; set; }
        /// <summary>
        /// 早签到时间
        /// </summary>
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// 签退时间
        /// </summary>
        public DateTime LastTime { get; set; }
        /// <summary>
        /// 所在部门
        /// </summary>
        public int StateID { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
    }
}
