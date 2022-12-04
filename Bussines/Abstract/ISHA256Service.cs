using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ISHA256Service
    {
        IDataResult<List<SHA256>> GetAll();
        IResult Delete(SHA256 sha256);
        IResult Add(SHA256 sha256);
        IResult Update(SHA256 sha256);
    }
}
