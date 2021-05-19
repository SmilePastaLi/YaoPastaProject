using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Yao.PastaProject.Domain.Abstractions
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString("N");
        }
        [Key]
        [Comment("主键")]
        [StringLength(50)]
        [Required]
        public string Id { get; private set; }
    }
}
