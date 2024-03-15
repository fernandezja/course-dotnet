using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Course
    {
        public string Title { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; private set; }

        public Course() {
            Students = new List<Student>();
        }

        public Course(string title, Teacher teacher)
        {
            Title = title;
            Teacher = teacher;

            Students = new List<Student>();
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public void Add(List<Student> students)
        {
            Students.AddRange(students);
        }
    }
}
