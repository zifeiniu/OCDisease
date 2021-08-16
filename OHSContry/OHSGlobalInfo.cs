using OHSUploadLibrary.Model;
using OHSUploadLibrary.OHSContry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary
{
    /// <summary>
    /// 全局配置信息
    /// </summary>
    public static  class OHSGlobalInfo
    {

        /// <summary>
        /// 机构编码
        /// </summary>
        public static string ReportOrgCode;

        public static string License;

        public static string ReportZoneCode;



        public static void InitBaseInfo() 
        {
            
            HOSContryCache.Init();
          

        }




        public static OHSHeader GetOhsHeader() 
        {
            OHSHeader header = new OHSHeader();

            header.OperateType = "Add";

            

            header.ReportOrgCode = ReportOrgCode;
            header.License = License;
            header.ReportZoneCode = ReportZoneCode;


         
            return header;
        }



    }
}
