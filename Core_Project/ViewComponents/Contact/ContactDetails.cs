using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
