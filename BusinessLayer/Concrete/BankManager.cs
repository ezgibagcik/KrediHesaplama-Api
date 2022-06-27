using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BankManager : IBankService
    {
        IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        #region CRUD Islemleri
        public List<Bank> GetList()
        {
            return _bankDal.GetListAll();
        }

        public void TAdd(Bank t)
        {
            _bankDal.Insert(t);
        }

        public void TDelete(Bank t)
        {
            _bankDal.Delete(t);
        }

        public Bank TGetById(int id)
        {
            return _bankDal.GetById(id);
        }

        public void TUpdate(Bank t)
        {
            _bankDal.Update(t);
        }
        #endregion CRUD Islemleri
    }
}
