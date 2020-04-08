using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 考勤状态表
    /// </summary>
    public class State
    {
        /// <summary>
        /// 考勤主键ID
        /// </summary>
        public int StateID { get; set; }
        /// <summary>
        /// 考勤名称
        /// </summary>
        public string StateName { get; set; }
    }
}
