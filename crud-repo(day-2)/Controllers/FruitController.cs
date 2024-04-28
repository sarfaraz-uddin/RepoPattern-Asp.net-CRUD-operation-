using crud_repo_day_2_.Data;
using crud_repo_day_2_.Models;
using crud_repo_day_2_.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace crud_repo_day_2_.Controllers
{
    
    public class FruitController : Controller
    {
        private readonly IFruit repoo;

        public FruitController(IFruit repo)
        {
            repoo = repo;
        }
        public IActionResult Index()
        {
            var list = repoo.Index();
            return View(list);
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult add(Fruit fr)
        {
            repoo.Insert(fr);
            return RedirectToAction("Index");
        }
        public IActionResult delete(int id)
        {
            repoo.deletedata(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult edit(int id)
        {
            var data=repoo.edit(id);
            return View(data);  
        }
        [HttpPost]
        public IActionResult edit(Fruit fruit)
        {
            repoo.editdata(fruit);
            return RedirectToAction("Index");
        }

    }
}
