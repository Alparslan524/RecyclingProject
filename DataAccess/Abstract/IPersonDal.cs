using Core.DataAccess;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {
        List<PersonDetailDto> GetPersonDetailDtos();
    }
}
