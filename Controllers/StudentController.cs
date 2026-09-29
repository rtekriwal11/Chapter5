/*using Chapter2MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter2MVC.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> allStudents = new List<Student>();
        static List<string> allCourses = new List<string> { "Java", "C#", "Agile" };

        public IActionResult AllStudent()
        {
            return View(allStudents);
        }
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            allStudents.Add(student);
            return RedirectToAction("AllStudent");
        }
        //IActionResult  is used whenever the return type is View()
        public IActionResult Course()
        {
            //allCourses--> Courses
            ViewData["Courses"] = allCourses;
            return View();
        }

        public IActionResult AddCourse()
        {
            return View();
        }
        //HTTPPOST HANDLES ALL THE DATA INCOMING TO ADDCOURSE
        //METHOD
        //IT RECIEVES A COURSETITLE, AND THEN IT PROCESSES IT
        [HttpPost]
        public IActionResult AddCourse(string courseTitle)
        {
            allCourses.Add(courseTitle);
            return RedirectToAction("Course", "Student");
        }

        public string CheckGrade()
        {
            return "Your grade is A.";
        }

        public string CheckRealGrade(string name, int score)
        {
            char letterGrade;

            if (score >= 90)
                letterGrade = 'A';
            else if (score >= 80)
                letterGrade = 'B';
            else if (score >= 70)
                letterGrade = 'C';
            else if (score >= 60)
                letterGrade = 'D';
            else if (score >= 50)
                letterGrade = 'E';
            else letterGrade = 'F';

            return $" The Student {name}'s grade is {letterGrade}";
        }
    }
}
*/