using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class PortfolioManager : IGenericService<Portfolio>
    {
        private IPortfolioDal iPortfolioDal;
        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            iPortfolioDal = portfolioDal;
        }
        public void TAdd(Portfolio item)
        {
            iPortfolioDal.Insert(item);
        }

        public void TDelete(Portfolio item)
        {
            iPortfolioDal.Delete(item);
        }

        public Portfolio TGetById(int id)
        {
            return iPortfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return iPortfolioDal.GetList();
        }

        public void TUpdate(Portfolio item)
        { 
            iPortfolioDal.Update(item);
        }
    }
}
