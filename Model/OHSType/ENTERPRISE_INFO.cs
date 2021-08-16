using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{


    /// <summary>
    /// 一.用人单位信息，职业病健康档案用  (ENTERPRISE_INFO 的子集，可能不一样。所以没有使用继承)
    /// </summary>
    public class ENTERPRISE_INFO_Sub
    {

        /// <summary>
        ///用人单位名称
        /// </summary>
        [Required]
        public string ENTERPRISE_NAME = string.Empty;
        /// <summary>
        /// 统一社会信用代码(18 位)
        /// </summary>
        [Required]
        public string CREDIT_CODE = string.Empty;
        /// <summary>
        /// 经济类型代码
        /// </summary>
        [Required]
        public string ECONOMIC_TYPE_CODE = string.Empty;
        /// <summary>
        /// 行业类别代码
        /// </summary>
        [Required]
        public string INDUSTRY_CATEGORY_CODE = string.Empty;
        /// <summary>
        /// 企业规模代码
        /// </summary>
        [Required]
        public string BUSINESS_SCALE_CODE = string.Empty;
        /// <summary>
        /// 所属地区代码
        /// </summary>
        [Required]
        public string ADDRESS_CODE = string.Empty;
        /// <summary>
        /// 用人单位详细地址
        /// </summary>
        [Required]
        public string ADDRESS_DETAIL = string.Empty;
        /// <summary>
        /// 邮政代码
        /// </summary>
        public string ADDRESS_ZIP_CODE = string.Empty;
        /// <summary>
        /// 用人单位联系人
        /// </summary>
        [Required]
        public string ENTERPRISE_CONTACT = string.Empty;
        /// <summary>
        /// 联系电话
        /// </summary>
        [Required]
        public string CONTACT_TELPHONE = string.Empty;
        /// <summary>
        /// 用人单位所在区全名称（如：北京市市辖区海淀区）
        /// </summary>
        [Required]
        public string ALL_NAME = string.Empty;


    }

    /// <summary>
    /// 用人单位信息
    /// </summary>
    public class ENTERPRISE_INFO
    {

        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string ID;

        /// <summary>
        /// 用人单位名称
        /// </summary>
        [Required]
        public string ENTERPRISE_NAME = string.Empty;
        /// <summary>
        /// 统一社会信用代码(18 位)
        /// </summary>
        [Required]
        public string CREDIT_CODE = string.Empty;
        /// <summary>
        /// 所属地区代码
        /// </summary>
        [Required]
        public string ADDRESS_CODE = string.Empty;
        /// <summary>
        /// 经济类型代码
        /// </summary>
        [Required]
        public string ECONOMIC_TYPE_CODE = string.Empty;
        /// <summary>
        /// 行业类别代码
        /// </summary>
        [Required]
        public string INDUSTRY_CATEGORY_CODE = string.Empty;
        /// <summary>
        /// 企业规模代码
        /// </summary>
        [Required]
        public string BUSINESS_SCALE_CODE = string.Empty;
        /// <summary>
        /// 详细地址
        /// </summary>
        [Required]
        public string ADDRESS_DETAIL = string.Empty;
        /// <summary>
        /// 邮政代码
        /// </summary>
        public string ADDRESS_ZIP_CODE = string.Empty;
        /// <summary>
        /// 单位联系人
        /// </summary>
        [Required]
        public string ENTERPRISE_CONTACT = string.Empty;
        /// <summary>
        /// 单位联系电话
        /// </summary>
        [Required]
        public string CONTACT_TELPHONE = string.Empty;
        /// <summary>
        /// 是否为子公司，0 表示否，1 表示是
        /// </summary>
        [Required]
        public string ISSUBSIDIARY = string.Empty;
        /// <summary>
        /// 子公司二级代码（当为子公司需填写）
        /// </summary>
        [Required]
        public string TWOLEVELCODE = string.Empty;
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
        public string WRITE_UNIT = string.Empty;
        /// <summary>
        /// 填表人名称
        /// </summary>
        [Required]
        public string WRITE_PERSON = string.Empty;
        /// <summary>
        /// 填表人电话
        /// </summary>
        [Required]
        public string WRITE_PERSON_TEL = string.Empty;
        /// <summary>
        /// 填表日期
        /// </summary>
        [Required]
        public string WRITE_DATE = string.Empty;
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
        /// 报告人电话
        /// </summary>
        [Required]
        public string REPORT_PERSON_TEL = string.Empty;
        /// <summary>
        /// 报告日期
        /// </summary>
        [Required]
        public string REPORT_DATE = string.Empty;


        public AUDIT_INFO AUDIT_INFO = new AUDIT_INFO ();

    }
}
