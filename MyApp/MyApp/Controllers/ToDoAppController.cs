using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using Newtonsoft.Json;
using NuGet.Configuration;
using System;

namespace MyApp.Controllers
{
    public class ToDoAppController : Controller
    {

        private ToDoAppContext _context;

        public ToDoAppController(ToDoAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var ToDoList = _context.ToDoAppModels.ToList();
            return View(ToDoList);
        }


        [HttpPost]
        public IActionResult Add(ToDoAppModel todo)
        {
            _context.ToDoAppModels.Add(todo);
            _context.SaveChanges();

            var objectToDo = JsonConvert.SerializeObject(todo);

            return Json(objectToDo);

        }
        [HttpGet]
        public IActionResult Remove(int id=0) {

            var todo = _context.ToDoAppModels.Find(id);

            if (todo != null)
            {
                _context.Remove(todo);
            }
            _context.SaveChanges();

            return Ok();

        }
        
    }
}
