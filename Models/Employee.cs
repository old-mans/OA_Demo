using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 员工id
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int AdeptID { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime JoinTime { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Number { get; set; }
    }
}
