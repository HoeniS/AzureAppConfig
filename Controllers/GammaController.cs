using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class GammaController: Controller
    {
        private readonly IFeatureManager _featureManager;

        public GammaController(IFeatureManagerSnapshot featureManager)
        {
            _featureManager = featureManager;
        }

        [FeatureGate(MyFeatureFlags.Gamma)]
        public IActionResult Index()
        {
            return View();
        }
    }
}