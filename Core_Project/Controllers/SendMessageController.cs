using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SendMessageController : Controller
    {
        private MessageManager messageManager = new MessageManager(new EfMessageDal());

        [HttpPost]
        public IActionResult Index(Message message)
        {
            message.Date = DateTime.Now.ToLocalTime();
            message.Status = true;
            messageManager.TAdd(message);
            return Redirect("/HomePage/Index#contact");
        }
    }
}
