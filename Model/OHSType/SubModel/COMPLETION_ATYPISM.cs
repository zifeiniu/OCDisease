using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
    public class COMPLETION_ATYPISM
    {
        /// <summary>
        /// 尘肺病病例类型代码
        /// </summary>
        public string CASETYPE = string.Empty;
        /// <summary>
        /// 职业性化学中毒分类代码
        /// </summary>
        [Required]
        public string COMPLETION_POISONING_TYPE_CODE = string.Empty;
        /// <summary>
        /// 尘肺一期诊断日期
        /// </summary>
        [Required]
        public string COMPLETION_DATE_STAGE_ONE = string.Empty;
        /// <summary>
        /// 尘肺二期诊断日期
        /// </summary>
        [Required]
        public string COMPLETION_DATE_STAGE_TWO = string.Empty;
        /// <summary>
        /// 尘肺三期诊断日期
        /// </summary>
        [Required]
        public string COMPLETION_DATE_STAGE_THREE = string.Empty;


    }
}
