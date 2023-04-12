using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Yasin", "hesenli", 65, true);
            Student s2 = new Student("Eltun", "Mikayilzade", 65, true);
            Student s3 = new Student("Hakim", "Dugi", 65, false);
            Student[] Students = new Student[] { s, s2, s3 };
            Group group =new Group("1ci",Students);
            group.Add(s);
            group.GetAll();
            group.GetOnlinestudents();
            group.Getoflinestudents();
              
        }
    }
   class Person
    {

        public string Name;
        public string Surname;
        public int Age;
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    class Student:Person
    {
        public bool Isonline;
        public Student(string name, string surname, int age,bool isonline) :base(name,surname,age)
        {
            Isonline = isonline;
        }
    }
    class Group
    {
        public string GroupName;
        public Student[] Student;

        public Group(string groupname, Student[] students)
        {
            GroupName = groupname;
            Student = students;
        }
        public void Add(Student student)
        {
            Console.WriteLine("Elave edilen Telebe:");
            Array.Resize(ref Student, Student.Length + 1);
            Student[Student.Length-1] = student;
            Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
            
        }
        public void GetAll()
        {
            Console.WriteLine("Butun Telebeler:");
            foreach(Student student in Student)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");

            }

        }
        public void GetOnlinestudents()
        {
            Console.WriteLine("Onlayn oxuyan telebeler:");
            foreach (var student in Student)
            {
                if (student.Isonline)
                {
                    Console.WriteLine($"{ student.Name} { student.Surname} {student.Age}");
                }
            }
        }
        public void Getoflinestudents()
        {
            Console.WriteLine("Oflayn oxuyan telebelr:");
            foreach(var student in Student)
            {
                if(!student.Isonline)
                {
                    Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");

                }
            }
        }
            
    }
    
}


