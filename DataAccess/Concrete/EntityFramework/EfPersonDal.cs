using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, KoyunCoinDB>, IPersonDal
    {
        public List<PersonDetailDto> GetPersonDetailDtos()
        {
            using (KoyunCoinDB context = new KoyunCoinDB())
            {
                var result = from p in context.Persons
                             join c in context.Customers
                             on p.PersonId equals c.PersonId
                             join pt in context.PersonType
                             on p.PersonTypeId equals pt.PersonTypeId
                             join s in context.SHA256
                             on c.SHAId equals s.SHAId
                             select new PersonDetailDto
                             {
                                 PersonId = p.PersonId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 IdentityNumber = p.IdentityNumber,
                                 UserName = p.UserName,
                                 Password = p.Password,
                                 CustomerId = c.CustomerId,
                                 Carbon = c.Carbon,
                                 KYC = c.KYC,
                                 Sha256 = s.Sha256,
                                 Type = pt.Type
                             };
                return result.ToList();
            }
        }
    }
}
