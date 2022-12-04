using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;
namespace Entity.Concrete
{
    public class Person:IEntity
    {
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonTypeId { get; set; }
    }
}
