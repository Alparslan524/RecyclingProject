﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;
namespace Entity.Concrete
{
    public class Garbage:IEntity
    {
        [Key]
        public short TypeID { get; set; }
        public string Type { get; set; }
        public float Carbon { get; set; }
    }
}
