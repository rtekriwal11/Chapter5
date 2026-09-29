
namespace Chapter2MVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        // ? --> means we can have null value for this property,
        // if we don't use ? then it
        // will be a required property and cannot be null
        public string? StudentName { get; set; }
        public decimal GPA { get; set; }

    }
}