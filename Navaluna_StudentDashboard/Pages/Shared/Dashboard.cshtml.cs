using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Navaluna_StudentDashboard.Pages.Shared
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

