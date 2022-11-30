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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new SuccessResult(Messages.AddedMessages);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.DeletedMessages);
        }

        public IDataResult<List<Person>> GetAll()
        {
            var result = _personDal.GetAll();
            return new SuccessDataResult<List<Person>>(result, Messages.GetAllMessages);
        }

        public IDataResult<Person> GetByName(string PersonName)
        {
            var result = _personDal.GetAll(P=> P.FirstName == PersonName);
            return new SuccessDataResult<Person>(Messages.GetMessages);
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.UpdatedMessages);
        }
    }
}
