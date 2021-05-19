using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Yao.PastaProject.Domain.Abstractions
{
    public class AggregateRoot : EntityBase
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [Comment("创建时间")]
        [StringLength(50)]
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Comment("创建人Id")]
        [StringLength(50)]
        public string CreatedById { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        [Comment("创建人姓名")]
        [StringLength(50)]
        public string CreatedByName { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Comment("更新时间")]
        [StringLength(50)]
        public DateTime UpdatedTime { get; set; }
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Comment("更新人Id")]
        [StringLength(50)]
        public string UpdatedById { get; set; }
        /// <summary>
        /// 更新人姓名
        /// </summary>
        [Comment("更新人姓名")]
        [StringLength(50)]
        public string UpdatedByName { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Comment("是否删除")]
        public bool IsDeleted { get; set; }
    }
}
