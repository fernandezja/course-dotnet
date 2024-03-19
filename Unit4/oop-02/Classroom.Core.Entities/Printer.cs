using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public abstract class Printer
    {
        public static string Print(IWithFullName any) {
            return any.FullName;
        }

    }
}
