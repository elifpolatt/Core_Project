using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Feature
{
    //ViewComponent classından miras alacak. (ViewComponent PartialView gibidir.)
    //ViewComponent'ler, parçalı görünümler veya kullanıcı arabirimindeki belirli bileşenler oluşturmanıza yardımcı olan bağımsız ve yeniden kullanılabilir bileşenlerdir. Bu bileşenler, bir Controller veya Razor Page gibi bir Controller sınıfı içermez ve kendi iş mantığınızı uygulayabilir
    //ViewComponent'ler genellikle karmaşık sayfa yapısına veya belirli bir işlevselliğe sahip olan ve birden fazla sayfada kullanılabilen bileşenler için idealdir. 

    
    public class FeatureList : ViewComponent
    {
        private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
