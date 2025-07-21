namespace Assignment1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1
            //1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Weekdays weekdays = new Weekdays();
            //weekdays.PrintWeekdays();

            #endregion

            #region Q.2
            //2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person("Alaa",20); 
            //people[1] = new Person("Maraim",10);       
            //people[2] = new Person("Khafagy" ,30);




            //foreach (var  Person in people)
            //{

            //    Console.WriteLine($" Name :{Person.Name}, Age :{Person.Age}");
            //}
            #endregion

            #region Q.3
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a Season from the four(Spring, Summer , Autumn , Winter)");
            //string input = Console.ReadLine()!;

            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring :March to May");
            //            break;

            //        case Season.Summer:
            //            Console.WriteLine("Summer : June to August");
            //            break;

            //        case Season.Autumn:
            //            Console.WriteLine("Autmun : september to November");
            //            break;

            //        case Season.Winter:
            //            Console.WriteLine("Winter : December to February");
            //            break;



            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered");
            //}



            #endregion

            #region Q.4
            //  4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permissions  userpermissions =  Permissions.read | Permissions.write;
            //Console.WriteLine($"Current Permissions : {userpermissions}");

            //userpermissions |= Permissions.read | Permissions.Execute;
            //Console.WriteLine($"After Adding Exescute : {userpermissions}");

            //userpermissions &= Permissions.write;
            //Console.WriteLine($"After Removing Write : {userpermissions}");


            //bool hasRead = userpermissions.HasFlag(Permissions.read);
            //Console.WriteLine($"Has read Permissions? {hasRead}");



            #endregion

            #region Q.5
            //5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter a Color ");
            //string input = Console.ReadLine()!;

            //if (Enum.TryParse(input, true, out Colors colors))
            //{
            //    if (colors == Colors.Blue || colors == Colors.Green || colors == Colors.Red)
            //    {
            //        Console.WriteLine($"{colors} is a primary color");

            //    }



            //}
            //else
            //{
            //    Console.WriteLine("This is not Valid Color");
            //}
            #endregion

            #region Q.6
            //6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter X and Y fpr POint P1 : ");
            //double x1=double.Parse(Console.ReadLine()!);
            //double y1 = double.Parse(Console.ReadLine()!);

            //Console.WriteLine("Enter the X and Y from Point P2 :");
            //double x2 = double.Parse(Console.ReadLine()!);
            //double y2= double.Parse(Console.ReadLine()!);

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //Console.WriteLine($"Distance = {Point.Distance(p1,p2)}");
            #endregion

            #region Q.7
            //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{ 
            //   Console.WriteLine($"Enter the name for Person {i+1}");
            //    string name= Console.ReadLine()!;

            //    Console.WriteLine($"Enter the age for Person {i+1}");
            //    int age = int.Parse(Console.ReadLine()!);

            //    people[i] =  new Person (name,age);



            //}

            //Person Oldest = people[0];

            //foreach (Person p in people)
            //{
            //    if (p.Age > Oldest.Age)
            //    { 
            //        Oldest = p;

            //    }
            //}
            //Console.WriteLine($"Oldest Person : {Oldest.Name},Age : {Oldest.Age}");
            #endregion

            #region Part Two
            #region Q.1
            //
            //    Employee emp = new Employee(
            //    id: 1001,
            //    name: "Mariam",
            //    gender: Gender.F,
            //    salary: 12000,
            //    hireDate: new HireDate(10, 5, 2023),
            //    securityLevel: SecurityLevel.Developer
            //);

            //    Console.WriteLine(emp);




            #endregion

            #region Q.2

            //{
            //    HireDate hDate = new HireDate(15, 7, 2022);
            //    Console.WriteLine("Hire Date: " + hDate); // Output: 15/07/2022
            //}

            #endregion

            #region Q.3
            //Console.Write("Enter Gender (M/F): ");
            //string genderInput = Console.ReadLine().ToUpper();

            //while (genderInput != "M" && genderInput != "F")
            //{
            //    Console.Write("Invalid input. Please enter M or F: ");
            //    genderInput = Console.ReadLine().ToUpper();
            //}

            //Gender gender = (Gender)Enum.Parse(typeof(Gender), genderInput);
            #endregion

            #region Q.4
            //Employee emp1 = new Employee (101, "Mariam", SecurityLevel.Guest);
            //Employee emp2 = new Employee (102, "Ali", SecurityLevel.DBA);
            #endregion

            #region Q.6
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ali", Gender.M, 15000, new HireDate(10, 5, 2020), SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Sara", Gender.F, 5000, new HireDate(1, 2, 2023), SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Omar", Gender.M, 20000, new HireDate(15, 9, 2019), SecurityLevel.SecurityOfficer);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
                Console.WriteLine(new string('-', 40));
            }
            #endregion

            #endregion
        }
    }
}
