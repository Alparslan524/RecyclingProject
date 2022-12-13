using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, KoyunCoinDB>, ICustomerDal
    {
        public List<PersonalDetailsDto> GetPersonalDetailsDtos()
        {
            using(KoyunCoinDB context = new KoyunCoinDB())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             join s in context.SHA256
                             on c.SHAId equals s.SHAId
                             select new PersonalDetailsDto
                             {
                                 Id = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CustomerId = c.CustomerId,
                                 Carbon = c.Carbon,
                                 KYC = c.KYC,
                                 SHAId = s.SHAId,
                                 Sha256 = s.Sha256
                             };
                return result.ToList();
            }
        }
    
    }
}
