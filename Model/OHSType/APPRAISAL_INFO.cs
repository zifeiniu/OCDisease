using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 五.职业病鉴定
    /// </summary>
    public class APPRAISAL_INFO
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID = "";


        public ENTERPRISE_INFO_Sub ENTERPRISE_INFO;


        /// <summary>
        /// 劳动者信息
        /// </summary>
        public WORKER_INFO WORKER_INFO;


        /// <summary>
        ///  病例信息
        /// </summary>
        public DIAGNOSE_INFO DIAGNOSE_INFO;

        /// <summary>
        /// 鉴定机构统一社会信用代码(诊断机构统一社会信用代码)
        /// </summary>
        [Required]
        public string DIAGNOSE_UNIT_CREDIT_CODE = string.Empty;
        /// <summary>
        /// 申请鉴定日期
        /// </summary>
        [Required]
        public string APPLY_INDENTIFY_DATE = string.Empty;
        /// <summary>
        /// 鉴定日期
        /// </summary>
        [Required]
        public string INDENTIFY_DATE = string.Empty;
        /// <summary>
        /// 鉴定结论代码（见字典鉴定结论）
        /// </summary>
        [Required]
        public string IDENTIFY_COMPLETION_CODE = string.Empty;
        /// <summary>
        /// 鉴定机构名称
        /// </summary>
        [Required]
        public string IDENTIFY_ORG_NAME = string.Empty;
        /// <summary>
        /// 鉴定机构代码
        /// </summary>
        [Required]
        public string IDENTIFY_ORG_CODE = string.Empty;
        /// <summary>
        /// <!
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        /// 诊断单位名称
        /// </summary>
        public string DIAGNOSE_UNIT_NAME = string.Empty;
        /// <summary>
        /// 申请诊断日期
        /// </summary>
        public string APPLY_DIAGNOSE_DATE = string.Empty;
        /// <summary>
        /// 创建地区
        /// </summary>
        [Required]
        public string AREA_CODE = string.Empty;
        /// <summary>
        /// 创建机构
        /// </summary>
        [Required]
        public string ORG_CODE = string.Empty;
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
        /// 填表人单位名称
        /// </summary>
        [Required]
        public string WRITE_UNIT = string.Empty;
        /// <summary>
        /// 报告人姓名
        /// </summary>
        [Required]
        public string REPORT_PERSON = string.Empty;
        /// <summary>
        /// 报告人联系电话
        /// </summary>
        [Required]
        public string REPORT_PERSON_TEL = string.Empty;
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
        /// 劳动者联系电话
        /// </summary>
        [Required]
        public string WORKER_TELPHONE = string.Empty;


        /// <summary>
        /// 鉴定结论与诊断不一致或与首次鉴定不一致时需填写的内容
        /// </summary>
        public COMPLETION_ATYPISM COMPLETION_ATYPISM;



        public AUDIT_INFO AUDIT_INFO;
        
    }
}
