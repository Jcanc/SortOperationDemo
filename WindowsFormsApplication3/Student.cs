using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3 {
    public class Student {
        /// <summary>
        /// 主键id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        ///// <summary>
        ///// 出生日期
        ///// </summary>
        //public DateTime BirthDate { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int Seq { get; set; }
    }
}
