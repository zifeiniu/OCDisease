using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
   public class WORKER_INFO
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string WORKER_NAME = string.Empty;

        /// <summary>
        /// 身份证件类型代码
        /// </summary>
        [Required]
        public string ID_CARD_TYPE_CODE = string.Empty;

        /// <summary>
        /// 身份证件号码
        /// </summary>
        [Required]
        public string ID_CARD = string.Empty;

        /// <summary>
        /// 性别代码
        /// </summary>
        [Required]
        public string GENDER_CODE;

        /// <summary>
        /// 出生日期
        /// </summary>
        [Required]
        public string BIRTH_DATE;


        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string EMERGENCY_CONTACT;


        /// <summary>
        /// 紧急联系电话
        /// </summary>
        public string CONTACT_INFORMATION;

       

    }


}
