using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IPersonTypeService
    {
        IDataResult<List<PersonType>> GetAll();
        IResult Delete(PersonType personType);
        IResult Add(PersonType personType);
        IResult Update(PersonType personType);
    }
}
