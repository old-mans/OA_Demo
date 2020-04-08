using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 节假日表
    /// </summary>
    public class Holiday
    {
        /// <summary>
        /// 节假日id
        /// </summary>
        public int HolidayId { get; set; }
        /// <summary>
        /// 假日名称
        /// </summary>
        public string HolidayName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime LastTime { get; set; }

    }
}
