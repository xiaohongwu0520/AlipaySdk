using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyApplyCreateModel : AopObject
    {
        /// <summary>
        /// 申请金额，默认以元为单位，支持精确到小数点后2位，为了便于传输，调用方需要把double类型的金额转换为string类型
        /// </summary>
        [XmlElement("apply_lmt")]
        public string ApplyLmt { get; set; }

        /// <summary>
        /// 客户的身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，01:身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 会员的登录账号，比如支付宝登录账号，一般为手机号或邮箱
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 联系手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 运营产品码
        /// </summary>
        [XmlElement("op_pd_code")]
        public string OpPdCode { get; set; }

        /// <summary>
        /// 外部机构定义的客户编号
        /// </summary>
        [XmlElement("out_mem_id")]
        public string OutMemId { get; set; }

        /// <summary>
        /// 外部流水号,唯一标识客户的一笔贷款申请。格式：日期(8位)+序列号(8位）,序列号是数字，如00000001（必须是16位且符合该格式）。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员站点
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }
    }
}
