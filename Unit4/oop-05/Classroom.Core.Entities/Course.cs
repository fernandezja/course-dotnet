
namespace Classroom.Core.Entities
{
    public class Course
    {
        public string Title { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; private set; }

        public Course()
        {
            Students = new();
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }
    }
}
