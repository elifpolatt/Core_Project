using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View();
        }

        
    }
}
