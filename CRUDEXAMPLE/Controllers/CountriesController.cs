using Microsoft.AspNetCore.Mvc;

namespace CRUDPROJECT.Controllers
{
    [Route("[controller]")]
    public class CountriesController : Controller
    {
        [Route("UploadFromExcel")]
        public IActionResult UploadFromExcel()
        {
            return View();
        }
    }
}
