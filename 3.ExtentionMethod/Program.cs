using _3.ExtentionMethod.CustomExtentions;
using _3.ExtentionMethod.DataAccess;

namespace _3.ExtentionMethod;

public class Program
{
    static void Main(string[] args)
    {
        // LINQ => Generic extention methodlar toplusun

        var students = DB.GetStudents();

        // var ageCondition = students
        //                     .Where(x => x.Age >= 18)
        //                     .ToList();
        // 
        // foreach (var item in ageCondition)
        // {
        //     Console.WriteLine(item);
        // }

        // students.ForEach(x => Console.WriteLine($"Fullname: {x.Name} {x.Surname}"));

        // var data = students.FirstOrDefault(x=> x.Score > 11);
        // var data2 = students.LastOrDefault(x=> x.Score > 11);
        // 
        // Console.WriteLine(data);
        // Console.WriteLine(data2);


        // var data = students.Where(x => x.Id > 3)
        //             .Skip(2)
        //             .Take(2);
        // 
        // foreach (var item in data)
        // {
        //     Console.WriteLine(item);
        // }


        // Console.WriteLine(students.Sum(x => x.Score) / students.Count); ;
        // Console.WriteLine(students.Average(x => x.Score)); 


        //var datas = students.OrderBy(x => x.Score);
        // var datas = students.OrderByDescending(x => x.Score);
        // 
        // foreach (var item in datas)
        // {
        //     Console.WriteLine(item);
        // }

        // Extention method

        var name = "Kamran";

        Console.WriteLine(name.HasSymbol("Kam"));

        var myList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(myList.MiddleElement());

    }
}
