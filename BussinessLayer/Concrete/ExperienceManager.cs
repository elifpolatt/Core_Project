using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private IExperienceDal iExperienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            iExperienceDal = experienceDal;
        }

        public void TAdd(Experience item)
        {
            iExperienceDal.Insert(item);
        }

        public void TDelete(Experience item)
        {
            iExperienceDal.Delete(item);
        }

        public Experience TGetById(int id)
        {
            return iExperienceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return iExperienceDal.GetList();
        }

        public void TUpdate(Experience item)
        {
            iExperienceDal.Update(item);
        }
    }
}
