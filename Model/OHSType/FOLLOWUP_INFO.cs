using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 六.职业病随访 
    /// </summary>
    public class FOLLOWUP_INFO
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID = "";


        /// <summary>
        /// 用人单位
        /// </summary>
        public ENTERPRISE_INFO ENTERPRISE_INFO;


        /// <summary>
        /// -劳动者信息
        /// </summary>
        public WORKER_INFO WORKER_INFO;


        /// <summary>
        /// 病例信息
        /// </summary>
        public FOLLOWUP_INFO_DIAGNOSE_INFO DIAGNOSE_INFO;

        /// <summary>
        /// 随访日期
        /// </summary>
        [Required]
        public string FOLLOWUP_DATE = string.Empty;
        /// <summary>
        /// 随访机构
        /// </summary>
        [Required]
        public string FOLLOWUP_ORG_NAME = string.Empty;
        /// <summary>
        /// 记录创建时间
        /// </summary>
        [Required]
        public string CREATE_DATE = string.Empty;
        /// <summary>
        /// 随访方式代码（见字典随访方式）
        /// </summary>
        [Required]
        public string FOLLOWUP_TYPE = string.Empty;
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
        /// 现住址代码
        /// </summary>
        [Required]
        public string ADDRESS_CODE = string.Empty;
        /// <summary>
        /// 现住址详细地址信息
        /// </summary>
        [Required]
        public string VILLAGE = string.Empty;
        /// <summary>
        /// 是否缴纳工伤保险, 0 否 1 是
        /// </summary>
        [Required]
        public string IS_INSURANCE = string.Empty;
        /// <summary>
        /// 缴纳工伤保险时间
        /// </summary>
        [Required]
        public string INSURANCE_DATE = string.Empty;


        /// <summary>
        /// 随访项目
        /// </summary>
        public FOLLOWUP_RESULT[] FOLLOWUP_RESULT_LIST;
    }



    public class FOLLOWUP_INFO_DIAGNOSE_INFO
    {

        /// <summary>
        /// -诊断日期-
        /// </summary>
        [Required]
        public string DIAGNOSE_DATE;

        /// <summary>
        /// 职业病名称代码（见字典职业病种类）
        /// </summary>
        [Required]
        public string DISEASE_NAME_CODE;

    }
}
