﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public int PersonId { get; set; }
        public float Carbon { get; set; }
        public float KYC { get; set; }
        public int SHAId { get; set; }
    }
}