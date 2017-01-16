using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertAdvSingleVoucherResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvSingleVoucherResponse : AopObject
    {
        /// <summary>
        /// 推广内容
        /// </summary>
        [XmlElement("content")]
        public KbAdvertAdvContent Content { get; set; }

        /// <summary>
        /// 券标的
        /// </summary>
        [XmlElement("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
