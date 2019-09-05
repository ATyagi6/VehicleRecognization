namespace VehicleRecognizer.Predict.Controllers
{
    using System.Diagnostics;
    using VehicleRecognizer.Predict.Models;
    using Microsoft.AspNetCore.Mvc;
    
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
