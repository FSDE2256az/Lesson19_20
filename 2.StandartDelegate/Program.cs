namespace _2.StandartDelegate;


// Delegate => Funksiyalar -i icerisinde saxlayir, FUNC toplu

// 1. Custom => bizim ozumuz yaratdigimiz
// 2. Standart => C# / .Net uzerinde gelenler ( Linq methodlarinda ( Extention methodlar toplusu ) ) 

//      2.1. Action     ( 0-16 parametr )   | void tipinde cvb qaytarir
//      2.2. Predicate  ( 1 parametr )      | bool tipinde cvb qaytarir 
//      2.3. Func       ( 0-16 parametr )   | void-den diger tiplerde qaytarir



public class Program
{
    static void CustomMethod() => Console.WriteLine("Custom method");
    static void CustomMethodWithParametr(int age, string name) => Console.WriteLine($"Name: {name} | Age: {age}");

    static bool IsEven(int number) => number % 2 == 0;

    static int Some() => 5;
    static string Some2(int number) => $"Number: {number}";

    static void Main(string[] args)
    {
        // int[] number = [1, 3, 4, 65];
        // number.FirstOrDefault();

        #region Action
        // 
        // // Parametrsiz
        // 
        // Action action1 = null!;
        // 
        // action1 += CustomMethod;
        // 
        // action1 += () => Console.WriteLine("Xayyam acar sozu gelen ders sorucam senden....");
        // 
        // action1 += delegate ()
        // {
        //     Console.WriteLine("Xayyam derse haziliqli gel....");
        // };
        // 
        // action1.Invoke();
        // 
        // // action1.Invoke();
        // 
        // 
        // // Parametrli
        // 
        // Action<int, string> action2 = null;
        // 
        // action2 += CustomMethodWithParametr;
        // 
        // action2.Invoke(16, "Isi");

        #endregion

        #region Predicate

        // Predicate<int> predicate = null!;
        // predicate += IsEven;


        // predicate += (int number) => number > 0;

        // Console.WriteLine(predicate.Invoke(15));

        #endregion

        #region Functor

        // Func<int> func = null!;
        // 
        // // func += Some;
        // // Console.WriteLine(func.Invoke());
        // 
        // Func<int, string> func2 = null!;
        // func2 += Some2;
        // Console.WriteLine(func2.Invoke(255));

        #endregion

        // Task: 

        // Action / Predicate / Func => heresine aid 3 numune yazirsiz
        // 1. Funk
        // 2. Anonymous
        // 3. Lamb

        // #region Action
        // Example1();
        // #endregion

        #region Predicate

        // int[] numArr = { 5, 10, 12, 34 };
        // Predicate<int> pred = null!;
        // pred += Example2;
        // 
        // pred += delegate (int number)
        // {
        //     return number % 3 == 0;
        // };
        // 
        // pred += (int number) => number % 5 == 0;
        // 
        // Console.WriteLine(pred.Invoke(numArr[0]));
        #endregion

        #region Funktor

        // Func<string, string> funk = null!;
        // funk += Example3;
        //
        // funk += delegate (string str)
        // {
        //     return str.ToLower();
        // };
        //
        // funk += (string str) => str.ToUpper();
        // Console.WriteLine(funk.Invoke("There is a message"));

        #endregion

    }

    static void Example1() => Console.WriteLine("Example 1");
    static bool Example2(int num) => num % 5 == 0;
    static string Example3(string txt) => $"Text: {txt}";


}
