using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {

        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {

            //foreach examples
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel("Paulie", DateTime.Parse("2005-04-05"), Gender.Male));
            people.Add(new PersonModel("Trismegistus", DateTime.Parse("2-04-05"), Gender.Male));
            people.Add(new PersonModel("Cleopatra", DateTime.Parse("1000-04-05"), Gender.Female));

            //note that the people list collection is not a KVP dictionary, yet below it is assigned into
            //ViewData["people"] because ViewData is a IDictionary derived KVP collection, so people
            //in fact becomes an object type, and will be accessible and typecastable inside the Razor View page
            ViewData["people"] = people;

            //viewbag does same as viewdata, but using properties instead of ViewData KVP
            //simplified syntax alternative with default casting if the data is assigned to ref of same original type
            //unlike ViewData that requires casting the value type back into original class type from ViewData object
            ViewBag.people = people;

            //the expected location route of the Viewfile is /Views/Home/ by default, the server looks for the View file that has the same name as the action method here Index, inside the folder with the same controller class here Home, which is an expected folder inside at project root Views folder.
            //so if the controller name was Page2Controller and the actionMethod was Home(), the expected route would be Views/Page2/Home.cshtml
            //this default hierarchy or folder location can be changed and another ViewName is passed as param1 ex: View("AnotherViewFileName")
            return View(); //returns Index.cshtml

            //note that the model passed to the View, if any, is only one Model class instance. so if a View requires more than one Model, say for example, User and Product that he wants to buy, the View can only receive one class, so a wrapper class would have to be made to work around this, for example UserAndProductWrapper can be a class tha stores the reference to User and Product in two properties, then UserAndProductWrapper is passed to the view, and expected as the @model in the view.
            //this example Wrapper is not implemented here for brevity sake, but is simple enough to understand in case more than one Data Model is needed per View

            //a strongly typed View type, is where the View stipulates an
            //@model classType of expected data model type, which inside the view
            //will be assigned to Model keyword and accessible in the view
            //so the expected object must be returned in the View() call
            return View(people);

            //specifying the ViewName will search the given name amongst the available Views with .cshtml extension, in this case organized into the Views folder, Index.cshtml
            //so view files can have C# and HTML code
            //return new ViewResult() { ViewName = "Index" };
        }

        //in this example a single person's details are fetched from the list
        [Route("person-details/{name}")]
        public IActionResult PersonDetails(string? name)
        {
            if (name == null)
            {
                return Content("person name cannot be null");
            }

            //supposing this collection below is actually on a database
            //which is accessed here to search for the valid "person name"
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel("Paulie", DateTime.Parse("2005-04-05"), Gender.Male));
            people.Add(new PersonModel("Trismegistus", DateTime.Parse("2000-04-05"), Gender.Male));
            people.Add(new PersonModel("Cleopatra", DateTime.Parse("1800-04-05"), Gender.Female));


            //and designate it as the person object that is passed to the View
            //LINC expression that finds and returneds the first instance of
            //the search for the same Name
            PersonModel selectedPerson = people.Where(personIterated => personIterated.Name == name).FirstOrDefault();

            //note that the target ViewName can be specified as a string, whereass if not specified, the app will look for the View with the same name as the actionMethod
            //if no target view or object instance is passed to the viewModel, then the view name is default actionMethod name and Model will be null inside viewName.cshtml
            return View("PersonDetails", selectedPerson); 
        }
    }
}
