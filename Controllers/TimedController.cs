using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class TimedController: Controller
    {
        private readonly IFeatureManager _featureManager;

        public TimedController(IFeatureManagerSnapshot featureManager)
        {
            _featureManager = featureManager;
        }

        [FeatureGate(MyFeatureFlags.Timed)]
        public IActionResult Index()
        {
            return View();
        }
    }
}