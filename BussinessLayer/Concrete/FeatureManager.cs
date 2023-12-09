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
    public class FeatureManager : IGenericService<Feature>
    {
        private IFeatureDal iFeatureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            iFeatureDal = featureDal;
        }

        public void TAdd(Feature item)
        {
            iFeatureDal.Insert(item);
        }

        public void TDelete(Feature item)
        {
            iFeatureDal.Delete(item);
        }

        public Feature TGetById(int id)
        {
            return iFeatureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return iFeatureDal.GetList();
        }

        public void TUpdate(Feature item)
        {
            iFeatureDal.Update(item);
        }
    }
}
