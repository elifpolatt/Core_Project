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
    public class AboutManager : IAboutService
    {
        IAboutDal iAboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            iAboutDal= aboutDal;
        }
       
        public void TAdd(About item)
        {
            iAboutDal.Insert(item);
        }

        public void TDelete(About item)
        {
            iAboutDal.Delete(item);
        }

        public About TGetById(int id)
        {
            return iAboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
            return iAboutDal.GetList();
        }

        public void TUpdate(About item)
        {
            iAboutDal.Update(item);
        }
    }
}
