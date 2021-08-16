using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 二.职业病健康档案
    /// </summary>
   public class HEALTH_EXAM_RECORD
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID="";


        /// <summary>
        /// 用人单位信息
        /// </summary>
        public ENTERPRISE_INFO_Sub ENTERPRISE_INFO = new ENTERPRISE_INFO_Sub();


        /// <summary>
        /// 劳动者信息
        /// </summary>
        public WORKER_INFO WORKER_INFO = new WORKER_INFO();



        /// <summary>
        /// 检查类型代码
        /// </summary>
        [Required]
        public string EXAM_TYPE_CODE = string.Empty;
        /// <summary>
        /// 体检日期
        /// </summary>
        [Required]
        public string EXAM_DATE = string.Empty;
        /// <summary>
        /// <!—体检危害因素代码
        /// </summary>
        [Required]
        public string FACTOR_CODE = string.Empty;
        /// <summary>
        /// 其他危害因素具体名称（如果危害因素选择其他，需要在这里填写具体的危害因素名称）
        /// </summary>
        [Required]
        public string FACTOR_OTHER = string.Empty;
        /// <summary>
        /// 填表人名称
        /// </summary>
        [Required]
        public string WRITE_PERSON = string.Empty;
        /// <summary>
        /// 填表人电话
        /// </summary>
        [Required]
        public string WRITE_PERSON_TELPHONE = string.Empty;
        /// <summary>
        /// 填表日期
        /// </summary>
        [Required]
        public string WRITE_DATE = string.Empty;
        /// <summary>
        /// 填表单位名称
        /// </summary>
        [Required]
        public string REPORT_ORGAN_CREDIT_CODE = string.Empty;
        /// <summary>
        /// <!
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        /// 工种代码
        /// </summary>
        [Required]
        public string WORK_TYPE_CODE = string.Empty;
        /// <summary>
        /// 其他工种名称（工种选择其他时，需要在这里保存具体工种的名字）
        /// </summary>
        [Required]
        public string OTHER_WORK_TYPE = string.Empty;
        /// <summary>
        /// 开始接害日期
        /// </summary>
        [Required]
        public string HARM_START_DATE = string.Empty;
        /// <summary>
        /// <!—实际接害工龄
        /// </summary>
        [Required]
        public string HARM_AGE_YEAR = string.Empty;
        /// <summary>
        /// <!—实际接害工龄
        /// </summary>
        [Required]
        public string HARM_AGE_MONTH = string.Empty;
        /// <summary>
        /// 是否复查（见字典是否复查）
        /// </summary>
        public string IS_REVIEW = string.Empty;
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
        /// 报告单位名称
        /// </summary>
        [Required]
        public string REPORT_UNIT = string.Empty;
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
        /// 接触的职业病危害因素代码
        /// </summary>
        [Required]
        public string CONTACT_FACTOR_CODE = string.Empty;


        /// <summary>
        /// 体检结论信息
        /// </summary>
        public EXAM_CONCLUSION[] EXAM_CONCLUSION_LIST;



        /// <summary>
        /// 检查项目信息
        /// </summary>
        public EXAM_ITEM_RESULT[] EXAM_ITEM_RESULT_LIST;

        public AUDIT_INFO AUDIT_INFO;

    }
}
