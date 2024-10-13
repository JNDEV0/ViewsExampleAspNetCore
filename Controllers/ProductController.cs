using Microsoft.AspNetCore.Mvc;

//this empty controller used just to explain a concept of shared views.
//if multiple controllers, in this example Home and Product controllers,
//need to access the same view, in this case ProductsAll view in the shared folder
//perhaps Home controller has another route, /see-products/ with same actionMethod name
//Home controller would look for Views/Home/ProductsAll.cshtml 
//Product controller would look for Views/Product/ProductsAll.cshtml 
//the view file is in neither location, they would each then look at the Shared folder
//for the view file, and would both be able to access the Shared folder and find
//Views/Shared.ProductsAll.cshtml, so the point is this view by being inside the
//preset named folder Shared, can be accessed by any controller, as a last check
//after searching the corresponding View/ControllerName folder
namespace ViewsExample.Controllers
{
    public class ProductController : Controller
    {
        [Route("products/all")]
        public IActionResult ProductsAll()
        {
            return View(); 
        }
    }
}
