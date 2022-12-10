using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
    public class PersonDetailDto : IDto
    {
        public int PersonId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public double Carbon { get; set; }
        public double KYC { get; set; }
        public string Sha256 { get; set; }

    }
}
