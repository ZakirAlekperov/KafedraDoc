using Microsoft.AspNetCore.Mvc;

namespace KafedraDoc.Controllers
{
    public class DocumentsController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
