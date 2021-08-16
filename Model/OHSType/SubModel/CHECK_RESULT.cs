using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    public class CHECK_RESULT
    {
        /// <summary>
        /// 职业性危害因素代码（见字典职业性危害因素）
        /// </summary>
        [Required]
        public string FACTOR_CODE = string.Empty;
        /// <summary>
        /// 工作场所名称
        /// </summary>
        [Required]
        public string WORKPLACE_NAME = string.Empty;
        /// <summary>
        /// 岗位/工种名称
        /// </summary>
        [Required]
        public string POSITION_NAME = string.Empty;
        /// <summary>
        /// 浓度/强度类型代码
        /// </summary>
        [Required]
        public string DENSITY_TYPE_CODE = string.Empty;
        /// <summary>
        /// 浓度/强度单位名称
        /// </summary>
        [Required]
        public string DENSITY_UNIT_NAME = string.Empty;
        /// <summary>
        /// 监测结果
        /// </summary>
        [Required]
        [XmlElement("CHECK_RESULT")]
        public string CHECK_RESULT_INFO = string.Empty;
        /// <summary>
        /// 监测日期
        /// </summary>
        [Required]
        public string CHECK_DATE = string.Empty;
        /// <summary>
        /// 合格情况（01:合格;02:不合格）
        /// </summary>
        [Required]
        public string IS_STANDARD = string.Empty;
        /// <summary>
        /// 检测结果最小值
        /// </summary>
        [Required]
        public string CHECK_RESULT_MIN = string.Empty;
        /// <summary>
        /// 检测结果最大值
        /// </summary>
        [Required]
        public string CHECK_RESULT_MAX = string.Empty;


    }
}
