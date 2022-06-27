using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class InterestRateManager : IInterestRateService
    {
        IInterestRateDal _interestRateDal;
        public InterestRateManager(IInterestRateDal interestRateDal)
        {
            _interestRateDal = interestRateDal;
        }

        #region CRUD Islemleri
        public List<InterestRate> GetList()
        {
            return _interestRateDal.GetListAll();
        }

        public void TAdd(InterestRate t)
        {
            _interestRateDal.Insert(t);
        }

        public void TDelete(InterestRate t)
        {
            _interestRateDal.Delete(t);
        }

        public InterestRate TGetById(int id)
        {
            return _interestRateDal.GetById(id);
        }

        public void TUpdate(InterestRate t)
        {
            _interestRateDal.Update(t);
        }
        #endregion CRUD Islemleri
    }
}
