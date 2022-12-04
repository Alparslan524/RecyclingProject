using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class PersonType : IEntity
    {
        [Key]
        public int PersonTypeId { get; set; }
        public string Type { get; set; }
    }
}
