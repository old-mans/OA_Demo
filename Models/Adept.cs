using System;

namespace Models
{
    /// <summary>
    /// 企业部门表
    /// </summary>
    public class Adept
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public int AdeptID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string AdeptName { get; set; }
        /// <summary>
        /// 部门描述
        /// </summary>
        public string AdeptDes { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public int ComID { get; set; }
    }
}
