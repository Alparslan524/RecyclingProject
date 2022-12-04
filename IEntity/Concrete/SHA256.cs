using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class SHA256 : IEntity
    {
        [Key]
        public int SHAId { get; set; }
        public int CustomerId { get; set; }
        public string Sha256 { get; set; }
    }
}
