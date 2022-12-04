using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class PersonTypeManager : IPersonTypeService
    {
        IPersonTypeDal _personTypeDal;

        public PersonTypeManager(IPersonTypeDal personTypeDal)
        {
            _personTypeDal = personTypeDal;
        }

        public IResult Add(PersonType personType)
        {
            _personTypeDal.Add(personType);
            return new SuccessResult(Messages.AddedMessages);
        }

        public IResult Delete(PersonType personType)
        {
            _personTypeDal.Delete(personType);
            return new SuccessResult(Messages.DeletedMessages);
        }

        public IDataResult<List<PersonType>> GetAll()
        {
            var result = _personTypeDal.GetAll();
            return new SuccessDataResult<List<PersonType>>(result, Messages.GetAllMessages);
        }

        public IResult Update(PersonType personType)
        {
            _personTypeDal.Update(personType);
            return new SuccessResult(Messages.UpdatedMessages);
        }
    }
}
