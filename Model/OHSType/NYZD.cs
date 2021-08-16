using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 七.农药中毒
    /// </summary>
    public class NYZD
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID = "";

        /// <summary>
        /// 劳动者
        /// </summary>
        public WORKER_INFO WORKER_INFO;

        /// <summary>
        ///  诊断日期 
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE = string.Empty;
        /// <summary>
        ///  农药中毒毒物名称代码 
        /// </summary>
        [Required]
        public string PESTICIDE_POISONING_NAME = string.Empty;
        /// <summary>
        ///  其他毒物（农药中毒毒物选择其他时，填写该字段） 
        /// </summary>
        [Required]
        public string OTHER_INFO = string.Empty;
        /// <summary>
        ///  农药中毒原因类型代码 
        /// </summary>
        [Required]
        public string PESTICIDE_POISONING_CAUSE_TYPE_CODE = string.Empty;
        /// <summary>
        ///  转归代码 
        /// </summary>
        [Required]
        public string OUTCOME = string.Empty;
        /// <summary>
        ///  死亡日期 
        /// </summary>
        public string DIE_DATE = string.Empty;
        /// <summary>
        ///  农药中毒发生地区代码 
        /// </summary>
        [Required]
        public string ADDRESS_CODE = string.Empty;
        /// <summary>
        ///  农药中毒发生地区详细地址 
        /// </summary>
        [Required]
        public string VILLAGE = string.Empty;
        /// <summary>
        ///  诊断单位名称 
        /// </summary>
        [Required]
        public string DIAGNOSE_UNIT_NAME = string.Empty;
        /// <summary>
        ///  诊断单位负责人 
        /// </summary>
        [Required]
        public string DIAGNOSE_PERSON = string.Empty;
        /// <summary>
        ///  填表人姓名 
        /// </summary>
        [Required]
        public string WRITE_PERSON = string.Empty;
        /// <summary>
        ///  填表人联系电话 
        /// </summary>
        [Required]
        public string WRITE_PERSON_TELPHONE = string.Empty;
        /// <summary>
        ///  填表日期 
        /// </summary>
        [Required]
        public string WRITE_DATE = string.Empty;
        /// <summary>
        ///  报告人姓名 
        /// </summary>
        [Required]
        public string REPORT_PERSON = string.Empty;
        /// <summary>
        ///  报告日期 
        /// </summary>
        [Required]
        public string REPORT_DATE = string.Empty;
        /// <summary>
        ///  报告单位名称 
        /// </summary>
        [Required]
        public string REPORT_UNIT = string.Empty;
        /// <summary>
        ///  报告人联系电话 
        /// </summary>
        [Required]
        public string REPORT_PERSON_TEL = string.Empty;
        /// <summary>
        ///  备注 
        /// </summary>
        public string REMARK = string.Empty;
        /// <summary>
        ///  创建地区代码（上报地区） 
        /// </summary>
        [Required]
        public string AREA_CODE = string.Empty;
        /// <summary>
        ///  创建机构代码（上报机构） 
        /// </summary>
        [Required]
        public string ORG_CODE = string.Empty;
        /// <summary>
        ///  填表单位名称
        /// </summary>
        [Required]
        public string WRITE_UNIT = string.Empty;
        /// <summary>
        ///  劳动者联系电话 
        /// </summary>
        [Required]
        public string WORKER_TELPHONE = string.Empty;


        public AUDIT_INFO AUDIT_INFO;

    }
}
