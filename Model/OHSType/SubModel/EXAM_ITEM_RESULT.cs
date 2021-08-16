using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
    public class EXAM_ITEM_RESULT
    {
        /// <summary>
        /// 检查项目父级名称（检查指标名称一级节点名称）
        /// </summary>
        [Required]
        public string EXAM_ITEM_PNAME = string.Empty;
        /// <summary>
        /// 检查项目名称
        /// </summary>
        [Required]
        public string EXAM_ITEM_NAME = string.Empty;
        /// <summary>
        /// 检查项目代码
        /// </summary>
        [Required]
        public string EXAM_ITEM_CODE = string.Empty;
        /// <summary>
        /// 检查结果类型代码
        /// </summary>
        [Required]
        public string EXAM_RESULT_TYPE = string.Empty;
        /// <summary>
        /// 检查结果
        /// </summary>
        [Required]
        public string EXAM_RESULT = string.Empty;
        /// <summary>
        /// 检查项目计量单位（只有检查结果为数字类型的需要填写，没有时可不填写
        /// </summary>
        public string EXAM_ITEM_UNIT_CODE = string.Empty;
        /// <summary>
        /// 参考值范围小值（只有检查结果为数字类型的需要填写，没有时可不填写
        /// </summary>
        public string REFERENCE_RANGE_MIN = string.Empty;
        /// <summary>
        /// 参考值范围大值（只有检查结果为数字类型的需要填写，没有时可不填写
        /// </summary>
        public string REFERENCE_RANGE_MAX = string.Empty;
        /// <summary>
        /// 是否异常（见字典检查结果是否异常）
        /// </summary>
        [Required]
        public string ABNORMAL = string.Empty;


    }
}
