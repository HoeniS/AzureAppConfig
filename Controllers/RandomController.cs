using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class RandomController: Controller
    {
        private readonly IFeatureManager _featureManager;

        public RandomController(IFeatureManagerSnapshot featureManager)
        {
            _featureManager = featureManager;
        }

        [FeatureGate(MyFeatureFlags.Random)]
        public IActionResult Index()
        {
            return View();
        }
    }
}