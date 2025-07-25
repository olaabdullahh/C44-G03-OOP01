using System.ComponentModel;
using System.Diagnostics;

namespace assignment
{
    internal class Program
    {
        public static void OrintWeekDay()
        {
           
        }
        static void Main(string[] args)
        {
            #region Q1
            // Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then,
            // write a C# program that prints out all the days of the week using this Enum.

            //foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}


            #endregion

            #region Q2
            // Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            // Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            // Note range for seasons ( spring march to may , summer June to August , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season name: ");

            //SeasOn season;
            //Enum.TryParse(Console.ReadLine(), out season);
            //  switch (season)
            //    {
            //        case SeasOn.Spring:
            //            Console.WriteLine("Rang: march to may");
            //            break;
            //        case SeasOn.Summer:
            //            Console.WriteLine("Rang: June to August");
            //            break;
            //        case SeasOn.Autumn:
            //            Console.WriteLine("Rang: September to November");
            //            break;
            //        case SeasOn.Winter:
            //            Console.WriteLine("Rang: December to February");
            //            break;
            //    }




            #endregion

            #region Q3
            // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable


           
            //Permessions userPerm = Permessions.None; 
            //Console.WriteLine("Adding permessions : ");
            //userPerm = userPerm | Permessions.Read;  
            //userPerm |= Permessions.Execute;//
            //Console.WriteLine(userPerm);
            //userPerm = userPerm ^ Permessions.Execute; 
            //Console.WriteLine("Removing permessions");
            //Console.WriteLine(userPerm);

            

            #endregion

            #region Q4
            //Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message
            //indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a Color name: ");

            //Color color;
            //Enum.TryParse(Console.ReadLine(), out color);
            //switch (color)
            //{
            //    case Color.red:
            //    case Color.green:
            //    case Color.blue:
            //        Console.WriteLine("the input color is a primary color");
            //        break;
            //    default:
            //        Console.WriteLine("the input color is not a primary color");
            //        break ;

            //}

            #endregion

        }
    }
}
