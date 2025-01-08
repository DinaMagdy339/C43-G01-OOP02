using System.Diagnostics.Metrics;
using System.Drawing;

namespace assign02oop
{
    internal class Program
    {
        static void Main(String[] args)
        {
            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];
            //person[0] = new Person("Ahmed", 4);
            //person[1] = new Person("Mona", 19);
            //person[2] = new Person("Dina", 12);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Name : {person[i].Name} , Age : {person[i].Age}");
            //}
            #endregion


            #region 2-Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the first point:");
            //Console.Write("X: ");
            //int x1 = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Y: ");
            //int y1 = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("Enter the second point:");
            //Console.Write("X: ");
            //int x2 = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Y: ");
            //int y2 = int.Parse(Console.ReadLine() ?? "0");


            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //Console.WriteLine($"The distance between the two points is: {Point.Distance(p1, p2)}");



            #endregion

            #region 3-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine() ?? "0";
            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine() ?? "0");
            //    person[i] = new Person(name, age);
            //}

            //Person oldestPerson = person[0];
            //for (int i = 1; i < person.Length; i++)
            //{
            //    if (person[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person[i];
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");


            #endregion

            #region 4-

            //Rectangle R1 = new Rectangle(7,-5);
            
            //R1.DisplayInfo();
            
            

            #endregion



        }
    }
}

