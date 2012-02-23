using System.Web.Mvc;
using Ch.TimeTweet.CrossCutting.Common.Mapping;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;

namespace Ch.TimeTweet.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMasterDataUnitOfWork _uow;

        public HomeController(IMasterDataUnitOfWork uow)
        {
            _uow = uow;
        }

        public ActionResult Index()
        {                                 
            var foo2 = _uow.Company.SelectAll();
            var foo4 = _uow.Employee.EagerDeepLoad(o => o.Company);
            var foo5 = _uow.Employee.EagerLoad(c => c.Company);
            var demo5 = foo5;
            var demo4 = foo4;
            return View(foo2);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(ActionName.Index);
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Home/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(ActionName.Index);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(ActionName.Index);
            }
            catch
            {
                return View();
            }
        }
    }
}
