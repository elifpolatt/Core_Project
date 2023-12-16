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
    public class SkillManager : IGenericService<Skill>
    {
        private ISkillDal iSkillDal;
        public SkillManager(ISkillDal skillDal)
        {
            iSkillDal = skillDal;
        }
        public void TAdd(Skill item)
        {
           iSkillDal.Insert(item);
        }

        public void TDelete(Skill item)
        {
            iSkillDal.Delete(item);
        }

        public Skill TGetById(int id)
        {
            return iSkillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return iSkillDal.GetList();
        }

        public void TUpdate(Skill item)
        {
            iSkillDal.Update(item);
        }
    }
}
