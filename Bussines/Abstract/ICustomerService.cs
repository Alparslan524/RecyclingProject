﻿using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Delete(Customer customer);
        IResult Add(Customer customer);
        IResult Update(Customer customer);

        IDataResult<List<PersonalDetailsDto>> GetPersonalDetailsDto();
    }
}
