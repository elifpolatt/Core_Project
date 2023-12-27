using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        private SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.deger1 = "Yetenek Listesi";
            ViewBag.deger2 = "Yetenekler";
            ViewBag.deger3  = "Yetenek Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.deger1 = "Yetenek Ekleme";
            ViewBag.deger2 = "Yetenekler";
            ViewBag.deger3 = "Yetenek Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.deger1 = "Güncelle";
            ViewBag.deger2 = "Yetenekler";
            ViewBag.deger3 = "Yetenek Güncelleme";
            var values = skillManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
