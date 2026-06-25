using _3.ExtentionMethod.Models;

namespace _3.ExtentionMethod.DataAccess;

public static class DB
{
    private static List<Student> _students = new List<Student>()
        {
            new Student{Id = 1, Name= "Fatime", Surname = "Abdulsoy", Age = 15, Score = 10.5},
            new Student{Id = 2, Name= "Yusuf", Surname = "Bagirov", Age = 16, Score = 11.5},
            new Student{Id = 3, Name= "Amil", Surname = "Eyvazli", Age = 20, Score = 8.5},
            new Student{Id = 4, Name= "Cavid", Surname = "Ibadzade", Age = 20, Score = 12},
            new Student{Id = 5, Name= "Ilham", Surname = "Namazov", Age = 18, Score = 5},
            new Student{Id = 6, Name= "Nicat", Surname = "Nabizade", Age = 15, Score = 6},
            new Student{Id = 7, Name= "Xayyam", Surname = "Qasimov", Age = 19, Score = 9},
            new Student{Id = 8, Name= "Zahra", Surname = "Shixalizade", Age = 19, Score = 11.8},
            new Student{Id = 9, Name= "Ismayil", Surname = "Mammadli", Age = 15, Score = 8.2}
        };

    public static List<Student> GetStudents()
    {
        return _students;
    }

    public static Group GetGroupInfo()
    {
        return new Group
        {
            Id = 1,
            Name = "FSDE",
            Students = _students
        };
    }
}
