using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Navaluna_StudentDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { Name = "Alice",   Score = 85 },
                new Student { Name = "Bob",     Score = 92 },
                new Student { Name = "Charlie", Score = 72 },
                new Student { Name = "Diana",   Score = 88 }
            };
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
   
}

