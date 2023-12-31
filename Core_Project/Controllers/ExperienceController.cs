﻿using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ExperienceController : Controller
    {
        private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.deger1 = "Deneyim Listesi";
            ViewBag.deger2 = "Deneyimler";
            ViewBag.deger3 = "Deneyim Listesi";

            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.deger1 = "Deneyim Ekleme";
            ViewBag.deger2 = "Deneyimler";
            ViewBag.deger3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.deger1 = "Güncelle";
            ViewBag.deger2 = "Deneyimler";
            ViewBag.deger3 = "Deneyim Güncelleme";
            var values = experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
