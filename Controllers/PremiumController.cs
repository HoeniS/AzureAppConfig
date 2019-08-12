using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class PremiumController: Controller
    {
        private readonly IFeatureManager _featureManager;

        public PremiumController(IFeatureManagerSnapshot featureManager)
        {
            _featureManager = featureManager;
        }

        [FeatureGate(MyFeatureFlags.Premium)]
        public IActionResult Index()
        {
            return View();
        }
    }
}