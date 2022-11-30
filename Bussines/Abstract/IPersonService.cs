using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IResult Delete(Person person);
        IResult Add(Person person);
        IResult Update(Person person);
        IDataResult<Person> GetByName(string PersonName);
    }
}
