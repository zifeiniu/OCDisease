using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.OHSContry
{


    /// <summary>
    /// 调用方在此初始化
    /// </summary>
    public  class OHSContryStartup
    {

        public static void InitConfig() 
        {
            //先初始化 SQL 相关
            //HOSDBHelper.QueryFunc

            OHSGlobalInfo.InitBaseInfo();



        }



    }
}
