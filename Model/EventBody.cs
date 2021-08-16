using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    public class EventBody
    {
        public EventBody()
        {
          

        }

        /// <summary>
        /// 用人的单位信息
        /// </summary>
        public ENTERPRISE_INFO[] ENTERPRISE_INFO_LIST;


        /// <summary>
        /// 职业健康档案 
        /// </summary>
        public HEALTH_EXAM_RECORD[] HEALTH_EXAM_RECORD_LIST;


        /// <summary>
        /// 疑似职业病 
        /// </summary>
        public SUSPECTED_OCPD[] SUSPECTED_OCPD_LIST;


        /// <summary>
        /// 职业病病例
        /// </summary>
        public DIAGNOSE_OCPD[] DIAGNOSE_OCPD_LIST;


        /// <summary>
        /// 职业病鉴定
        /// </summary>
        public APPRAISAL_INFO[] APPRAISAL_INFO_LIST;



        /// <summary>
        /// 职业病随访
        /// </summary>
        public FOLLOWUP_INFO[] FOLLOWUP_INFO_LIST;


        /// <summary>
        /// 农药中毒
        /// </summary>
        public NYZD[] NYZD_LIST;


        /// <summary>
        /// 职业性有害因素监测 
        /// </summary>
        public DETECTION_INFO[] DETECTION_INFO_LIST;


         

    }









}
