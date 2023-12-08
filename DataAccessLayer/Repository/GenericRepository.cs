using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    //Generic yapı, her defasında örneğin SkillRepository diyerek class olusturup kalıtsal olarak aldıgımız interface icerisindeki metotları cagırmak yerıne tek bir yerde bunları kullanarak kod tekrarından kacınmamızı saglar.
    public class GenericRepository<T> : IGenericDal<T> where T : class //T burada mutlaka bir sınıf olmalı, bir metot, interface ya da başka bir şey olmamalı 
    {
        public void Delete(T p)
        {
            using var c = new Context();
            c.Remove(p);
            c.SaveChanges(); //veri tabanına degisikler kaydolur.
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
        }

        public void Update(T p)
        {
            using var c = new Context();
            c.Update(p);
            c.SaveChanges();
        }
    }
}
