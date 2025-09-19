using Microsoft.AspNetCore.Mvc;

namespace WebRooshan.Controllers
{
    //[Route("hello")] //without this it will be conventional routing the url will go like : localhost:5001/{nameof class i.e. HelloController1/Index} like this other wise it will Attribute based here                    //url: localhost:5001/helloworld should write the url like this 
    public class HelloController1 : Controller
    {
        //[HttpGet("")]
        //GET: /<CONTROLLER>/
        public IActionResult Index()
        {
            string html = "<h1> Hello world!</h1>";
            return Content(html, "text/html");
        }
    }
}
