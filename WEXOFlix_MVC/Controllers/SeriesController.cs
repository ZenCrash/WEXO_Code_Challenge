using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace WEXOFlix_MVC.Controllers
{
    public class SeriesController : Controller
    {
        public SeriesController()
        {

        }

        //-----------------------------------------------------------------------------
        /* Index Page & Getall                                                       */
        //-----------------------------------------------------------------------------

        private string _format = "json";
        private string _language = "da";
        private string _programType = "series";

        public async Task<ActionResult> Index()
        {
            string Langu;

            //Establish Connection
            var client = ApiHelper.InitializeClient("https://feed.entertainment.tv.theplatform.eu/f/jGxigC/bb-all-pas?form=" + _format + "&lang=" + _language + "&byProgramType=" + _programType);

            //HTTP GetALL
            var ResponseTask = await client.GetAsync();


            return View();
        }
    }
}
