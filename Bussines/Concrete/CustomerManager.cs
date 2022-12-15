using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddedMessages);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.DeletedMessages);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var result = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result.ToList(), Messages.GetAllMessages);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.UpdatedMessages);
        }

        public IDataResult<List<PersonalDetailsDto>> GetPersonalDetailsDto()
        {
            return new SuccessDataResult<List<PersonalDetailsDto>>(_customerDal.GetPersonalDetailsDtos(), Messages.PersonDetailsListed);
        }

        public IDataResult<List<PersonalDetailsDto>> GetByEmail(string email)
        {
            
            return new SuccessDataResult<List<PersonalDetailsDto>>(_customerDal.GetByEmail(email),"kulanıcı listelendi");

        }

        public IResult UpdateById( int carbonValue, int id)
        {
            Customer customer = new Customer();
            customer = _customerDal.Get(c => c.CustomerId == id);
            customer.Carbon = carbonValue;
            _customerDal.Update(customer);
            return new SuccessResult("carbon güncellendi");
        }
    }
}
