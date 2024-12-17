using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Assignment15.Pages
{
    public class IndexModel : PageModel
    {
        public List<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
        private static List<ToDoItem> toDoList = new List<ToDoItem>();
        private static int idCounter = 1;

        public void OnGet()
        {
            ToDoItems = toDoList;
        }

        public IActionResult OnPostAdd(string task)
        {
            if (!string.IsNullOrWhiteSpace(task))
            {
                toDoList.Add(new ToDoItem { Id = idCounter++, Task = task, IsCompleted = false });
            }
            return RedirectToPage();
        }

        public IActionResult OnPostComplete(int id)
        {
            var item = toDoList.Find(t => t.Id == id);
            if (item != null)
            {
                item.IsCompleted = true;
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int id)
        {
            toDoList.RemoveAll(t => t.Id == id);
            return RedirectToPage();
        }
    }

    public class ToDoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
    }
}
// Compare this snippet from Assignment%2015/Assignment%2015/Assignment%2015/Pages/Index.cshtml: