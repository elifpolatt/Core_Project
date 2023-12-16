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
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal iTestimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            iTestimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial item)
        {
            iTestimonialDal.Insert(item);
        }

        public void TDelete(Testimonial item)
        {
            iTestimonialDal.Delete(item);
        }

        public Testimonial TGetById(int id)
        {
            return iTestimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return iTestimonialDal.GetList();
        }

        public void TUpdate(Testimonial item)
        {
            iTestimonialDal.Update(item);
        }
    }
}
