using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashTriggerModel : AopObject
    {
        /// <summary>
        /// 现金活动号
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// (此项目前废弃不填，请使用scope:auth_cash授权)用户登录账号名：邮箱或手机号。user_id与login_id至少有一个非空，都非空时，以user_id为准。使用开放平台用户授权时，此项和user_id均不填。
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// (此项目前废弃不填，请使用scope:auth_cash授权) 用户唯一标识userId。user_id与login_id至少有一个非空；都非空时，以user_id为准。使用开放平台用户授权时，此项和login_id均不填。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
