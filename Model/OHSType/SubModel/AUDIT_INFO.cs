using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
    public class AUDIT_INFO
    {

        /// <summary>
        /// 审核状态代码
        /// </summary>
        [Required]
        public string AUDITSTATUS = string.Empty;

        /// <summary>
        /// 审核意见
        /// </summary>
        [Required]
        public string AUDITINFO = string.Empty;

        /// <summary>
        /// 审核时间
        /// </summary>
        [Required]
        public string AUDITDATE = string.Empty;

        /// <summary>
        /// 审核人姓名
        /// </summary>
        [Required]
        public string AUDITOR_NAME = string.Empty;

        /// <summary>
        /// 审核机构
        /// </summary>
        public string AUDIT_ORG = string.Empty;



    }
}
