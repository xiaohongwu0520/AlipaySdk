using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 红包名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动号
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        [XmlElement("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动文案,用户在账单中看到的红包描述
        /// </summary>
        [XmlElement("prize_msg")]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式, fixed为固定金额,random为随机金额
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动已发放金额
        /// </summary>
        [XmlElement("send_amount")]
        public string SendAmount { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包总个数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
