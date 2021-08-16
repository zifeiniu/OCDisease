using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    public class FOLLOWUP_RESULT
    {
        /// <summary>
        /// 随访项目代码
        /// </summary>
        [Required]
        public string FOLLOWUP_ITEM_TYPE_CODE = string.Empty;
        /// <summary>
        /// 随访项目名称
        /// </summary>
        [Required]
        public string FOLLOWUP_ITEM_NAME = string.Empty;
        /// <summary>
        /// 随访结果(见字典随访结果)
        /// </summary>
        [Required]
        [XmlElement("FOLLOWUP_RESULT")]
        public string FOLLOWUP_RESULTInfo = string.Empty;

    }
}
