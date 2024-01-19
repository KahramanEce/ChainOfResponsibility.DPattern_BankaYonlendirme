using Chain_of__Responsibility.DesignPattern.ChainOfResponsibility;
using Chain_of__Responsibility.DesignPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chain_of__Responsibility.DesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model) 
        {
             Employee treasurer=new Treasurer();
            Employee managerAssistant = new Manager();
            Employee manager=new Manager();
            Employee areaDirector=new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();

        }
    }
}
