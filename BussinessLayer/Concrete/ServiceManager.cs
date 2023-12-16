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
    public class ServiceManager : IServiceService
    {
        IServiceDal iServiceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            iServiceDal = serviceDal;
        }
        public void TAdd(Service item)
        {
            iServiceDal.Insert(item);
        }

        public void TDelete(Service item)
        {
            iServiceDal.Delete(item);
        }

        public Service TGetById(int id)
        {
            return iServiceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return iServiceDal.GetList();
        }

        public void TUpdate(Service item)
        {
            iServiceDal.Update(item);
        }
    }
}
