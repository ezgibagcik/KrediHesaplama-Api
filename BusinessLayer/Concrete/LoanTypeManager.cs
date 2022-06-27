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
    public class LoanTypeManager : ILoanTypeService
    {
        ILoanTypeDal _loanTypeDal;
        public LoanTypeManager(ILoanTypeDal loanTypeDal)
        {
            _loanTypeDal = loanTypeDal;
        }

        #region CRUD Islemleri
        public List<LoanType> GetList()
        {
            return _loanTypeDal.GetListAll();
        }

        public void TAdd(LoanType t)
        {
            _loanTypeDal.Insert(t);
        }

        public void TDelete(LoanType t)
        {
            _loanTypeDal.Delete(t);
        }

        public LoanType TGetById(int id)
        {
            return _loanTypeDal.GetById(id);
        }

        public void TUpdate(LoanType t)
        {
            _loanTypeDal.Update(t);
        }
        #endregion CRUD Islemleri
    }
}
