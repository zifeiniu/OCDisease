using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
     
    public class OHSHeader
    {
        /// <summary>
        /// 机构编码-当前时间（yyyyMMddHHmmssSSS）-5 位随机码<
        /// </summary>
        public string DocumentId = string.Empty;


        /// <summary>
        /// -数据操作类型 Add,Update,Delete
        /// </summary>
        public string OperateType = string.Empty;


        /// <summary>
        /// <!--业务活动标识 职业病系统--> (默认职业病)
        /// </summary>
        public string BusinessActivityIdentification = "NEWOMAR";


        /// <summary>
        /// 上报机构代码
        /// </summary>
        public string ReportOrgCode = string.Empty;


        /// <summary>
        /// 上报机构授权码
        /// </summary>
        public string License = string.Empty;


        /// <summary>
        /// 上报地区代码
        /// </summary>
        public string ReportZoneCode = string.Empty;


    }
}
