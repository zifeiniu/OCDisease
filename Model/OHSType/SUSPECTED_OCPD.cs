using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 三.疑似职业病
    /// </summary>
    public class SUSPECTED_OCPD
    {

        [XmlAttribute(AttributeName = "ID")]
        public string ID;

        /// <summary>
        /// 用人单位信息
        /// </summary>
        public ENTERPRISE_INFO_Sub ENTERPRISE_INFO = new ENTERPRISE_INFO_Sub();

        /// <summary>
        /// -劳动者信息
        /// </summary>
        public WORKER_INFO WORKER_INFO = new WORKER_INFO();

        /// <summary>
        /// 职业病种类代码（职业病父级名称，见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_TYPE_CODE = string.Empty;
        /// <summary>
        /// 职业病名称代码（见字典职业病种类
        /// </summary>
        [Required]
        public string DISEASE_NAME_CODE = string.Empty;
        /// <summary>
        /// 其他职业病名称（职业病名称包含其他时，需要填写该字段）
        /// </summary>
        [Required]
        public string DISEASE_NAME_CODE_OTHER = string.Empty;
        /// <summary>
        /// 工种代码
        /// </summary>
        [Required]
        public string WORK_TYPE_CODE = string.Empty;
        /// <summary>
        /// 其他工种名称（工种选择其他时需要填写该字段）
        /// </summary>
        [Required]
        public string other_work_type = string.Empty;
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
        /// 发现日期
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE = string.Empty;
        /// <summary>
        /// 发现单位名称
        /// </summary>
        [Required]
        public string DIAGNOSE_UNIT_NAME = string.Empty;
        /// <summary>
        /// 发现单位负责人
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
        [Required]
        public string WRITE_PERSON_TELPHONE = string.Empty;
        /// <summary>
        /// 填表日期
        /// </summary>
        [Required]
        public string WRITE_DATE = string.Empty;
        /// <summary>
        /// 报告人姓名
        /// </summary>
        public string REPORT_PERSON = string.Empty;
        /// <summary>
        /// 报告单位名称
        /// </summary>
        [Required]
        public string REPORT_UNIT = string.Empty;
        /// <summary>
        /// 报告日期
        /// </summary>
        [Required]
        public string REPORT_DATE = string.Empty;
        /// <summary>
        /// 职业性化学中毒分类代码
        /// </summary>
        [Required]
        public string OCCUPATION_POISONING_TYPE_CODE = string.Empty;
        /// <summary>
        /// 接触的职业性有害因素代码（见字典职业性有害因素，多个用逗号隔开）
        /// </summary>
        [Required]
        public string FACTOR_CODE = string.Empty;
        /// <summary>
        /// 接触的其他职业性有害因素名称（接触的职业性有害因素包含其他时，需填写该数据）
        /// </summary>
        [Required]
        public string FACTOR_CODE_OTHER = string.Empty;
        /// <summary>
        /// <!
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        /// 创建地区代码(上报地区)
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
        /// 报告人联系电话
        /// </summary>
        [Required]
        public string REPORT_PERSON_TEL = string.Empty;
        /// <summary>
        /// 劳动者联系电话
        /// </summary>
        [Required]
        public string WORKER_TELPHONE = string.Empty;


        /// <summary>
        /// 审核信息
        /// </summary>
        public AUDIT_INFO AUDIT_INFO = new AUDIT_INFO();

    }
}
