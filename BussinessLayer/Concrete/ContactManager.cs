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
    public class ContactManager : IContactService
    {
        private IContactDal iContactDal;

        public ContactManager(IContactDal contactDal)
        {
            iContactDal = contactDal;
        }
        public void TAdd(Contact item)
        {
            iContactDal.Insert(item);
        }

        public void TDelete(Contact item)
        {
            iContactDal.Delete(item);
        }

        public Contact TGetById(int id)
        {
            return iContactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return iContactDal.GetList();
        }

        public void TUpdate(Contact item)
        {
            iContactDal.Update(item);
        }
    }
}
