using System.Collections.Generic;
namespace  VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            string userName = "Utsal";
            int luckyNumber = 8;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants ----

            Circle circle = new Circle();

            Console.WriteLine($"Circle.PI = {Circle.PI}");

            // ---- Task 3: data types and type conversion ----

            byte tiny = 200;
            short small = 30000;
            int wholeNumber = 42;
            long largeNumber = 100000L;
            float decimalFloat = 3.14f;
            double decimalDouble = 3.14159;
            decimal money = 99.99m;
            char letter = 'A';
            bool isStudent = true;

            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");
            Console.WriteLine($"int    = {wholeNumber}   (type: int)");
            Console.WriteLine($"long   = {largeNumber}  (type: long)");
            Console.WriteLine($"float  = {decimalFloat}  (type: float)");
            Console.WriteLine($"double = {decimalDouble} (type: double)");
            Console.WriteLine($"decimal = {money}   (type: decimal)");
            Console.WriteLine($"char   = {letter}      (type: char)");
            Console.WriteLine($"bool   = {isStudent}     (type: bool)");



             // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };
            Console.WriteLine($"Array elements: {string.Join(", ", numbers)}");
            Array.Sort(numbers);
            Console.WriteLine($"Array Sort : {string.Join(", ", numbers)}");
            Array.Reverse(numbers);
            Console.WriteLine($"Array Reverse : {string.Join(", ", numbers)}");

            for (int i = 0; i < numbers.Length; i++)
{
            Console.WriteLine($"  [{i}] = {numbers[i]}");
}           
        Console.WriteLine($"IndexOf(19)  = {Array.IndexOf(numbers, 19)}");
        Console.WriteLine($"IndexOf(100) = {Array.IndexOf(numbers, 100)}");


        //task 5: type conversion
         DateTime birthDate = new DateTime(2005, 10, 12);
         DateTime today = DateTime.Now;
         TimeSpan age = today - birthDate;
         int years = (int)(age.TotalDays / 365);

         Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
         Console.WriteLine($"Today: {today.ToShortDateString()}");
         Console.WriteLine($"Age: {age.TotalDays} days");
         Console.WriteLine($"Age in years: {years} years");
         Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");


         //task 6: string methods
          List<string> fruits = new() { "Apple", "Mango", "Banana" };
          fruits.Add("Orange");
          fruits.Remove("Mango");
          foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Dictionary<int, string> byId = new()
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};
byId.Add(4, "Orange");

foreach (KeyValuePair<int, string> item in byId)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

        }
    }
}