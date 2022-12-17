using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines.Concrete
{
    public class SHA256Manager : ISHA256Service
    {
        ISHA256Dal _sHA256Dal;

        public SHA256Manager(ISHA256Dal sHA256Dal)
        {
            _sHA256Dal = sHA256Dal;
        }

        public IResult Add(SHA256 sha256)
        {
            _sHA256Dal.Add(sha256);
            return new SuccessResult(Messages.AddedMessages);
        }

        public IResult Delete(SHA256 sha256)
        {
            _sHA256Dal.Delete(sha256);
            return new SuccessResult(Messages.DeletedMessages);
        }

        public IDataResult<List<SHA256>> GetAll()
        {
            var result = _sHA256Dal.GetAll();
            return new SuccessDataResult<List<SHA256>>(result.ToList(), Messages.GetAllMessages);
        }

        public IDataResult<SHA256> GetByAdress(string adress)
        {
                var result = _sHA256Dal.Get(G => G.Sha256 == adress);
                return new SuccessDataResult<SHA256>(result, Messages.GetMessages);   
        }

        public IResult Update(SHA256 sha256)
        {
            _sHA256Dal.Update(sha256);
            return new SuccessResult(Messages.UpdatedMessages);
        }
    }
}
