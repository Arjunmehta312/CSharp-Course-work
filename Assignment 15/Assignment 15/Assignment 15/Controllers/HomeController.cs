using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment15.Controllers
{
    public class HomeController : Controller
    {
        private static List<ToDoItem> toDoList = new List<ToDoItem>();
        private static int idCounter = 1;

        public IActionResult Index()
        {
            return View(toDoList);
        }

        [HttpPost]
        public IActionResult Add(string task)
        {
            if (!string.IsNullOrWhiteSpace(task))
            {
                toDoList.Add(new ToDoItem { Id = idCounter++, Task = task, IsCompleted = false });
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            var item = toDoList.Find(t => t.Id == id);
            if (item != null)
            {
                item.IsCompleted = true;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            toDoList.RemoveAll(t => t.Id == id);
            return RedirectToAction("Index");
        }
    }
}
