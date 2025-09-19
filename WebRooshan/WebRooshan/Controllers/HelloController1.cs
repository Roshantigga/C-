/*Convention Summary  tutorial taken for LaunchCode youtube channel

Controller name: HelloController1 → maps to route /Hello/...

Action name: Index() → maps to /Hello/Index

View file: /Views/{ControllerNameWithoutController}/{ActionName}.cshtml*/
using Microsoft.AspNetCore.Mvc;

namespace WebRooshan.Controllers
{
     //without route this it will be conventional routing the url will go like : localhost:5001/{nameof class i.e. HelloController1/Index} like this other wise it will Attribute based here                    //url: localhost:5001/helloworld should write the url like this 
    public class HelloController1 : Controller
    {
        //[Route("hello")]
        //[HttpGet("")]
        //GET: /<CONTROLLER>/
        public IActionResult Index()
        {
            string html = "<h1> Hello world!</h1>";
            return Content(html, "text/html");
        }

        //GET: /hellocontroller1/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]//without this if we want to print the name then we can use url/Welcome?name=Roshan  like this
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
