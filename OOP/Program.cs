using Common;
namespace OOP
{

    enum WeekDays
    {
        Sunday, Monday, Tuseday, Wednesday, Thursday, Friday, Saturday
    }

    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    enum Permissions
    {
        None = 0, 
        Read = 1 << 0, 
        Write = 1 << 1, 
        Delete = 1 << 2, 
        Execute = 1 << 3
    }

    enum Colors
    {
        Red, Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeB t = new TypeB();
            //Console.WriteLine(t.d);
            #region Question1
            //1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its
            //members. Then, write a C# program that prints out all the days of the week using this enum.

                //foreach (string day in Enum.GetNames(typeof(WeekDays)))
                //{
                //    Console.WriteLine(day);
                //}

                foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                {
                    Console.WriteLine(day);
                }
            #endregion

            #region Question2
            //2.Define a struct "Person" with properties "Name" and "Age". Create an array of three
            //"Person" objects and populate it with data. Then, write a C# program to display
            //the details of all the persons in the array.

            //Person[] PersonArray = new Person[3];

            //PersonArray[0] = new Person("Mahmoud", 25);
            //PersonArray[1] = new Person("ahmeddd", 22);
            //PersonArray[2] = new Person("aliiiii", 20);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Name : {PersonArray[i].Name}, Age : {PersonArray[i].Age}");
            //}
            #endregion

            #region Question3
            //3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter)
            //as its members. Write a C# program that takes a season name as input from the user
            //and displays the corresponding month range for that season. Note range for seasons
            //( spring march to may , summer june to august , autumn September to November ,
            //winter December to February)

            //Console.Write("Enter Season Name : ");
            //string SeasonName = Console.ReadLine();

            //Season s1 = Season.Spring;
            //Season s2 = Season.Summer;
            //Season s3 = Season.Autumn;
            //Season s4 = Season.Winter;
            //if (SeasonName == Convert.ToString(s1))
            //    Console.WriteLine("corresponding month range for that season spring march to may");
            //else if (SeasonName == Convert.ToString(s2))
            //    Console.WriteLine("corresponding month range for that season summer june to august");
            //else if (SeasonName == Convert.ToString(s3))
            //    Console.WriteLine("corresponding month range for that season autumn September to November");
            //else if (SeasonName == Convert.ToString(s4))
            //    Console.WriteLine("corresponding month range for that season winter December to February");
            //else Console.WriteLine("Wrong Input");

            #endregion

            #region Question4
            //4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //● Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            //Permissions userPermissions = Permissions.None;

            //// Add permissions to the variable
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //// Check if a specific permission exists
            //CheckPermission(userPermissions, Permissions.Read);
            //CheckPermission(userPermissions, Permissions.Execute);

            //// Remove a permission
            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing 'Write': {userPermissions}");

            //// Add 'Delete' permission
            //userPermissions |= Permissions.Delete;
            //Console.WriteLine($"Permissions after adding 'Delete': {userPermissions}");

            #endregion

            #region Question5
            //5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a
            //message indicating whether the input color is a primary color or not.

            //Console.Write("Enter a color name:");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(typeof(Colors), input, true, out var result))
            //    Console.WriteLine($"{input} is a primary color.");
            //else
            //    Console.WriteLine($"{input} is not a primary color.");

            #endregion

            #region Question6
            //6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the
            //distance between them.

            //Console.WriteLine("Enter the coordinates of the first point (X1, Y1):");
            //int x1 = Convert.ToInt16(Console.ReadLine());
            //int y1 = Convert.ToInt16(Console.ReadLine());
            //Point point1 = new Point(x1, y1);

            //Console.WriteLine("Enter the coordinates of the second point (X2, Y2):");
            //int x2 = Convert.ToInt16(Console.ReadLine());
            //int y2 = Convert.ToInt16(Console.ReadLine());
            //Point point2 = new Point(x2, y2);   

            //double distance = CalculateDistance(point1, point2);
            //Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region Question7
            //7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program
            //that takes details of 3 persons as input from the user and displays the name and
            //age of the oldest person.

            //string name;
            //int age;
            //Person[] PersonArrayInput = new Person[3];
            //for (int i = 0; i < PersonArrayInput.Length; i++)
            //{
            //    Console.WriteLine($"Enter Data of person number {i+1}");
            //    name = Console.ReadLine();
            //    age = Convert.ToInt32(Console.ReadLine());
            //    PersonArrayInput[i] = new Person(name, age);
            //}
            //int oldest = 0;
            //string oldestName = "";
            //for (int i = 0; i < 3; i++)
            //{
            //    if(oldest < PersonArrayInput[i].Age)
            //    {
            //        oldest = PersonArrayInput[i].Age;
            //        oldestName = PersonArrayInput[i].Name;
            //    }
            //}
            //Console.WriteLine($"the name and age of the oldest person is {oldestName}, {oldest}");

            #endregion

        }

        #region CalculateDistanceFunction
        static double CalculateDistance(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            }
        #endregion

        #region CheckPermission
        static void CheckPermission(Permissions currentPermissions, Permissions checkPermission)
        {
            if ((currentPermissions & checkPermission) == checkPermission)
            {
                Console.WriteLine($"Permission '{checkPermission}' exists.");
            }
            else
            {
                Console.WriteLine($"Permission '{checkPermission}' does not exist.");
            }
        }

        #endregion
    }
}
