using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 四.职业病病例
    /// </summary>
    public class DIAGNOSE_OCPD
    {  
        
        /// <summary>
       /// 数据唯一标识
       /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID = "";


        public ENTERPRISE_INFO_Sub ENTERPRISE_INFO;


        public WORKER_INFO WORKER_INFO;


        /// <summary>
        /// 职业病种类代码（职业病父级名称，见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_TYPE_CODE = string.Empty;
        /// <summary>
        /// 职业病名称代码（见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_NAME_CODE = string.Empty;
        /// <summary>
        /// 其他职业病名称（职业病名称包含其他时，需要填写该字段）
        /// </summary>
        public string DISEASE_NAME_CODE_OTHER = string.Empty;
        /// <summary>
        /// 工种代码
        /// </summary>
        [Required]
        public string WORK_TYPE_CODE = string.Empty;
        /// <summary>
        /// 其他工种名称（工种代码选择其他时，填写该字段）
        /// </summary>
        [Required]
        public string OTHER_WORK_TYPE = string.Empty;
        /// <summary>
        /// 死亡日期
        /// </summary>
        public string DIE_DATE = string.Empty;
        /// <summary>
        /// 开始接害日期
        /// </summary>
        [Required]
        public string HARM_START_DATE = string.Empty;
        /// <summary>
        /// 实际接害工龄
        /// </summary>
        [Required]
        public string HARM_AGE_YEAR = string.Empty;
        /// <summary>
        /// 实际接害工龄
        /// </summary>
        [Required]
        public string HARM_AGE_MONTH = string.Empty;
        /// <summary>
        /// 实际接害工龄
        /// </summary>
        public string HARM_AGE_DAY = string.Empty;
        /// <summary>
        /// 实际接害
        /// </summary>
        public string HARM_AGE_HOUR = string.Empty;
        /// <summary>
        /// 实际接害
        /// </summary>
        public string HARM_AGE_BRANCH = string.Empty;
        /// <summary>
        /// 合并症代码
        /// </summary>
        public string COMPLICATION_CODE = string.Empty;
        /// <summary>
        /// 诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE = string.Empty;
        /// <summary>
        /// 诊断单位名称
        /// </summary>
        [Required]
        public string DIAGNOSE_UNIT_NAME = string.Empty;
        /// <summary>
        /// 诊断单位负责人
        /// </summary>
        [Required]
        public string DIAGNOSE_PERSON = string.Empty;
        /// <summary>
        /// 填表人姓名
        /// </summary>
        [Required]
        public string WRITE_PERSON = string.Empty;
        /// <summary>
        /// 填表人联系电话
        /// </summary>
        public string WRITE_PERSON_TELPHONE = string.Empty;
        /// <summary>
        /// 填表日期
        /// </summary>
        [Required]
        public string WRITE_DATE = string.Empty;
        /// <summary>
        /// 报告人姓名
        /// </summary>
        [Required]
        public string REPORT_PERSON = string.Empty;
        /// <summary>
        /// 报告日期
        /// </summary>
        [Required]
        public string REPORT_DATE = string.Empty;
        /// <summary>
        /// 报告单位名称
        /// </summary>
        [Required]
        public string REPORT_UNIT = string.Empty;
        /// <summary>
        /// 报告人联系电话
        /// </summary>
        [Required]
        public string REPORT_PERSON_TEL = string.Empty;
        /// <summary>
        /// 接触的职业性危害因素代码（见字典职业性危害因素，多个用逗号隔开）
        /// </summary>
        [Required]
        public string FACTOR_CODE = string.Empty;
        /// <summary>
        /// 尘肺病病例类型代码
        /// </summary>
        [Required]
        public string CASETYPE = string.Empty;
        /// <summary>
        /// <!
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        /// 死亡原因代码
        /// </summary>
        public string DIE_REASON = string.Empty;
        /// <summary>
        /// 其他死亡原因（死亡原因选择其他时，填写该字段）
        /// </summary>
        [Required]
        public string OTHER_DIE_REASON = string.Empty;
        /// <summary>
        /// 申请诊断日期
        /// </summary>
        [Required]
        public string APPLY_DIAGNOSE_DATE = string.Empty;
        /// <summary>
        /// 创建地区代码（上报地区）
        /// </summary>
        [Required]
        public string AREA_CODE = string.Empty;
        /// <summary>
        /// 创建机构代码（上报机构）
        /// </summary>
        [Required]
        public string ORG_CODE = string.Empty;
        /// <summary>
        /// 填表人单位名称
        /// </summary>
        [Required]
        public string WRITE_UNIT = string.Empty;
        /// <summary>
        /// 劳动者联系电话
        /// </summary>
        [Required]
        public string WORKER_TELPHONE = string.Empty;
        /// <summary>
        /// 尘肺一期诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE_STAGE_ONE = string.Empty;
        /// <summary>
        /// 尘肺二期诊断日期
        /// </summary>
        public string DIAGNOSE_DATE_STAGE_TWO = string.Empty;
        /// <summary>
        /// 尘肺三期诊断日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE_STAGE_THREE = string.Empty;

        public AUDIT_INFO AUDIT_INFO;

    }
}
