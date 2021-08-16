using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
   public class DIAGNOSE_INFO
    {
        /// <summary>
        /// 诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE = string.Empty;
        /// <summary>
        /// 诊断职业病种类代码（职业病父级名称，见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_TYPE_CODE = string.Empty;
        /// <summary>
        /// 诊断职业病名称代码（见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_NAME_CODE = string.Empty;
        /// <summary>
        /// 尘肺病病例类型代码
        /// </summary>
        [Required]
        public string CASETYPE = string.Empty;
        /// <summary>
        /// 职业性化学中毒分类代码
        /// </summary>
        public string OCCUPATION_POISONING_TYPE_CODE = string.Empty;
        /// <summary>
        /// 尘肺一期诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE_STAGE_ONE = string.Empty;
        /// <summary>
        /// 尘肺二期诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE_STAGE_TWO = string.Empty;
        /// <summary>
        /// 尘肺三期诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE_STAGE_THREE = string.Empty;

    }
}
