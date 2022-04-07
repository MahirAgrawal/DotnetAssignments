
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using av.Models;

namespace av.Controllers{
    public class TeacherController : Controller{

        private readonly ApplicationDBContext _db;

        public TeacherController(ApplicationDBContext db){
            this._db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> list = _db.Teachers;
            return View(list);
        }
        public IActionResult Add(){
            return View();
        }


        // [HttpPost]
        // public IActionResult Add([Bind("Name,Class,SubjectId")] Teacher obj){
        //     if (ModelState.IsValid)
        //     {
        //         _db.Teachers.Add(obj);
        //         _db.SaveChanges();
        //         return RedirectToAction("Index");
        //     }

        //     // return View(studobj);
        // }
    }
}
