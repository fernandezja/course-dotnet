
namespace Classroom.Core.Entities
{
    public class Course: IName
    {
        public string Title { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public string Name
        {
            get { return Title; }
            set { Title = value; }
        }
    }
}
