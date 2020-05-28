using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Lab32_LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grand Circus Lab 32: LINQ Practice");

            int[] nums = { 10, 2330, 12233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //LINQ

            var minimumNum = nums.Min();
            Console.WriteLine($"The minimum value of any element in the list of numbers is {minimumNum}.");

            var maximumNum = nums.Max();
            Console.WriteLine($"The maximum value of any element in the list of numbers is {maximumNum}.");

            var maxUnder1K = nums.Where(n => n < 1000).Max();
            Console.WriteLine($"The maximum value of any element under 1000 is {maxUnder1K}.");

            var CKToM = nums.Where(n => n >= 100000 && n <= 999999);
            Console.WriteLine($"The values between 100,000 and 999,999 are: ");
            foreach (int n in CKToM)
            {
                Console.WriteLine(n);
            }

            var evenCount = nums.Count(n => n % 2 == 0);
            Console.WriteLine($"The number of elements of even value is {evenCount}.");

            var evens = nums.Where(n => n % 2 == 0);
            Console.WriteLine($"The even values are: ");
            foreach (int n in evens)
            {
                Console.WriteLine(n);
            }

            int minAge = students.Min(s => s.Age);
            Student youngestStudent = students.First(s => s.Age == minAge);
            Console.WriteLine($"The youngest student is {youngestStudent.Name} at {youngestStudent.Age} years.");

            int maxAge = students.Max(s => s.Age);
            Student oldestStudent = students.First(s => s.Age == maxAge);
            Console.WriteLine($"The oldest student is {oldestStudent.Name} at {oldestStudent.Age} years.");

            var oldestUnder25 = (from s in students where s.Age < 25 select s).Max();
            Console.WriteLine($"The oldest student under 25 years of age is {oldestUnder25.Name} at {oldestUnder25.Age} years of age.");

            List<Student> evensOver21 = (from s in students where s.Age >= 21 && s.Age % 2 == 0);
            Console.WriteLine("The list of students of even ages over 21 is as follows: ");
            foreach (Student s in evensOver21)
            {
                Console.WriteLine($"{s.Name} is {s.Age} years of age.");
            }

            List<Student> teenagers = (from s in students where s.Age >= 13 && s.Age <= 19);
            Console.WriteLine("The list of teenage students is as follows: ");
            foreach (Student s in teenagers)
            {
                Console.WriteLine($"{s.Name} is a teenager of {s.Age} years.");
            }

            List<Student> startsWVowel = (from s in students where s.Name.ToLower().ToCharArray().First().Equals("a" || "e" || "i" || "o" || "u"));
            Console.WriteLine("The list of students whose names begin with a vowel is as follows: ");
            foreach(Student s in startsWVowel)
            {
                Console.WriteLine($"The name \"{s.Name}\" begins with a vowel.");
            }

            //Combined LINQ Methods Where() and Max()
            //int oddMax = nums.Where(x => x % 2 == 1).Max();
            //Console.WriteLine($"The highest odd value in the list is {oddMax}.");
        }
    }
}
