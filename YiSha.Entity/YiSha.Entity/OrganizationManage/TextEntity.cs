using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrganizationManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-04-30 15:28
    /// 描 述：测试实体类
    /// </summary>
    [Table("crm_text")]
    public class TextEntity : BaseEntity
    {
        /// <summary>
        /// 时间
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? Addtime { get; set; }
        /// <summary>
        /// text
        /// </summary>
        /// <returns></returns>
        public string Text { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        /// <returns></returns>
        public string User { get; set; }
        /// <summary>
        /// 用户2
        /// </summary>
        /// <returns></returns>
        public string User2 { get; set; }
    }
}
