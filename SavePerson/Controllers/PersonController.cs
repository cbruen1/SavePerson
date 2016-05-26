using System.Web.Mvc;
using SavePerson.Models;

namespace SavePerson.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            var firstName = Session["FirstName"]?.ToString();
            var lastName = Session["LastName"]?.ToString();
            var person = new Person() { FirstName = firstName, LastName = lastName };

            return View("Create", person);
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                Session["FirstName"] = person.FirstName;
                Session["LastName"] = person.LastName;

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
