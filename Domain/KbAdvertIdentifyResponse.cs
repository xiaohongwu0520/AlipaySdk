using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertIdentifyResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertIdentifyResponse : AopObject
    {
        /// <summary>
        /// 返回码  success: 成功  invalid-arguments: 无效参数  retry-exception: 异常请重试
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 主键的值
        /// </summary>
        [XmlElement("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 主键类型
        /// </summary>
        [XmlElement("identify_type")]
        public string IdentifyType { get; set; }
    }
}
