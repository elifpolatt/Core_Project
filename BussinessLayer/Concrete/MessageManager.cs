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
    public class MessageManager : IMessageService
    {
        private IMessageDal iMessageDal;

        public MessageManager(IMessageDal messageDal)
        {
            iMessageDal = messageDal;
        }
        public void TAdd(Message item)
        {
            iMessageDal.Insert(item);
        }

        public void TDelete(Message item)
        {
            iMessageDal.Delete(item);
        }

        public Message TGetById(int id)
        {
            return iMessageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return iMessageDal.GetList();
        }

        public void TUpdate(Message item)
        {
            iMessageDal.Update(item);
        }
    }
}
