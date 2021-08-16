using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
   public class EXAM_CONCLUSION
    {
        /// <summary>
        /// <!—职业病危害因素代码
        /// </summary>
        [Required]
        public string ITAM_CODE = string.Empty;
        /// <summary>
        /// 危害因素名称
        /// </summary>
        [Required]
        public string ITAM_NAME = string.Empty;
        /// <summary>
        /// <!—体检结论代码
        /// </summary>
        [Required]
        public string EXAM_CONCLUSION_CODE = string.Empty;
        /// <summary>
        /// 疑似职业病代码（见字典职业病类型，当体检结论位疑似职业病时，需填写该字段）
        /// </summary>
        [Required]
        public string YSZYB_CODE = string.Empty;
        /// <summary>
        /// 职业禁忌证名称（当体检结论是职业禁忌症时，需填写该字段）
        /// </summary>
        [Required]
        public string ZYJJZ_NAME = string.Empty;
        /// <summary>
        /// 其他疾病或异常描述（当体检结论是其他疾病或异常时，需填写该字段）
        /// </summary>
        [Required]
        public string QTJB_NAME = string.Empty;
        /// <summary>
        /// 监测类型代码
        /// </summary>
        [Required]
        public string JC_TYPE = string.Empty;

    }
}
