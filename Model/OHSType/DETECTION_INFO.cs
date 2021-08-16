using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 八.职业性有害因素监测
    /// </summary>
    public class DETECTION_INFO
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID = "";


        public ENTERPRISE_INFO_Sub ENTERPRISE_INFO;


        /// <summary>
        /// 职工总数
        /// </summary>
        [Required]
        public string ALL_WORKER_SUM = string.Empty;
        /// <summary>
        /// 产工人数生
        /// </summary>
        [Required]
        public string PRO_WORKER_SUM = string.Empty;
        /// <summary>
        /// 接触有害有毒作业人数
        /// </summary>
        [Required]
        public string EXPOSE_HAZARD_WORKER_SUM = string.Empty;
        /// <summary>
        /// 检测单位名称
        /// </summary>
        [Required]
        public string CHECK_ORGAN_NAME = string.Empty;
        /// <summary>
        /// 检测单位联系人
        /// </summary>
        [Required]
        public string CHECK_ORGAN_PERSON = string.Empty;
        /// <summary>
        /// 填表人
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
        /// 报告人
        /// </summary>
        [Required]
        public string REPORT_PERSON = string.Empty;
        /// <summary>
        /// 报告日期
        /// </summary>
        [Required]
        public string REPORT_DATE = string.Empty;
        /// <summary>
        /// <!
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        /// 创建地区代码
        /// </summary>
        [Required]
        public string AREA_CODE = string.Empty;
        /// <summary>
        /// 创建机构代码
        /// </summary>
        [Required]
        public string ORG_CODE = string.Empty;
        /// <summary>
        /// 填表单位名称
        /// </summary>
        [Required]
        public string WRITE_UNIT = string.Empty;
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


        public CHECK_RESULT[] CHECK_RESULT_LIST;

        public AUDIT_INFO AUDIT_INFO;

    }
}
