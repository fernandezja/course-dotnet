namespace Classroom.Core.Entities.Interfaces
{
    public interface IPerson //: IWithFirstNameAndLastName
    {
        int Age { get; }
        DateOnly Birthdate { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string ToDo();
    }
}