using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yao.PastaProject.Domain.Abstractions;

namespace Yao.PastaProject.Domain.Models
{
    [Table("user")]
    public class User: AggregateRoot
    {
        [Comment("帐号")]
        [StringLength(36)]
        [Required]
        public string Account { get; private set; }

        [Comment("密码")]
        [StringLength(36)]
        [Required]
        public string Password { get; private set; }

        //[Comment("余额")]
        //[Column(TypeName = "decimal(18, 2)")]
        //[Required]
        //public decimal Money { get; set; }

        //[Comment("是否删除")]
        //[Column(TypeName = "tinyint(1)")]
        //[Required]
        //public bool Deleted { get; private set; }

        //[Comment("创建人")]
        //[StringLength(20)]
        //[Required]
        //public string Creater { get; private set; }

        //[Comment("创建时间")]
        //[Required]
        //public DateTime CreateTime { get; private set; }

        //[Comment("修改人")]
        //[StringLength(20)]
        //[Required]
        //public string Modifyer { get; private set; }

        //[Comment("修改时间")]
        //[Required]
        //public DateTime ModifyTime { get; private set; }

        //public void SetCreater(string name)
        //{
        //    Creater = name;
        //    CreateTime = DateTime.Now;
        //    SetModifyer(name);
        //}

        //public void SetModifyer(string name)
        //{
        //    Modifyer = name;
        //    ModifyTime = DateTime.Now;
        //}
    }
}
