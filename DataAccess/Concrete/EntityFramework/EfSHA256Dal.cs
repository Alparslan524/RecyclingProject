using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSHA256Dal : EfEntityRepositoryBase<SHA256, KoyunCoinDB>, ISHA256Dal
    {
    }
}
