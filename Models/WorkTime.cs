using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 工作时间表
    /// </summary>
    public class WorkTime
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 早签到时间（上）
        /// </summary>
        public DateTime TopTime { get; set; }
        /// <summary>
        /// 早签到时间（下）
        /// </summary>
        public DateTime UnderTime { get; set; }
        /// <summary>
        /// 晚签到时间
        /// </summary>
        public DateTime WsTime { get; set; }
        /// <summary>
        /// 矿工时间
        /// </summary>
        public DateTime limtime { get; set; }

    }
}
