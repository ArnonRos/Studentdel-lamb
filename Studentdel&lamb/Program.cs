using Studentdel_lamb;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Class1
{
    public class Program
    {
        public delegate bool classFilter(Student student);
        public static bool IsExcellent(Student student)
        {
            return student.Name == "Avi";
        }




        static void Main(string[] args)
        {

            classFilter myFilter = IsExcellent;

            /*myFilter += delegate (Student student) 
            { 
                return student.StudentClass == "יב10"; 
            };*/
            /*myFilter += (Student student) =>
            {
                return student.StudentClass == "יב10";
            };*/
            myFilter += student => student.StudentClass == "יב10";
            Func<Student, string> func2 = Student => Student.Name.ToUpper();
            Action<Student> action = student => Console.WriteLine("Name: " + student.Name + "Class: " + student.StudentClass);
            Predicate<Student> predicate = student => student.Name.Length > 4;
            Action<Student> nameAndClass = student => Console.WriteLine(student.Name);
            nameAndClass += student => Console.WriteLine(student.StudentClass);
            Student student = new Student();
            student.Name = "Ido";
            student.StudentClass = "יב10";
            bool booly = myFilter(student);
            Console.WriteLine(booly);
            nameAndClass(student);
            List<Student> students = new List<Student> { };
            int countYB2 = students.Count(student => student.StudentClass == "יב2");
            Student FindNoa = students.Find(student => student.Name == "Noa");
            List<Student> YB3 = students.Where(student => student.StudentClass == "יב3").ToList();




        }
    }
}