namespace Lab32_LinqPractice
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() 
        { 
        
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}