using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{
    #region Q.1
    //public enum WeekDays :Byte
    //{ 
    //   Monday,
    //   Tuesday,
    //   Wednesday,
    //   Thursday,
    //   Friday,
    //   Saturday,
    //   Sunday
    //}
    //internal class Weekdays
    //{

    //    public void  PrintWeekdays() 
    //    {
    //        Console.WriteLine("Days of the Week : ");

    //        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
    //        { 
    //           Console.WriteLine($"{day.ToString()}");

    //        }


    //    }

    //}
    #endregion

    #region Q.2

    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name , int age) 
    //    { 

    //     Name = name;
    //      Age = age;  

    //    }



    //}

    #endregion

    #region  Q.3
    //public enum Season : Byte
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter

    //}
    //internal class season
    //{


    //}


    #endregion

    #region Q.4
    //public enum Permissions
    //{ 
    //  None=0,
    //  read=1, 
    //  write=2,
    //  Delete=4,
    //  Execute=8

    //}

    #endregion

    #region Q.5
    //public enum Colors
    //{ 
    //  Red,
    //  Green,
    //  Blue


    //}
    #endregion

    #region Q.6
    //public struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //    public Point(double x, double y)
    //    {
    //        X= x;
    //        Y= y;
    //    }

    //    public static double Distance(Point p1, Point p2)
    //    {

    //        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));


    //    }

    //}
    #endregion

    #region Q.7
    //    public struct Person
    //    {
    //        public string Name { get; set; }
    //        public int Age { get; set; }

    //        public Person(string name, int age)
    //        {
    //            Name = name;
    //            Age = age;

    //        }

    //}

    #endregion

    #region Part two 
    #region  Q.1

    //public enum Gender
    //{
    //    M,
    //    F
    //}

    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA,
        

    //}

    //public class HireDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HireDate(int day, int month, int year)
    //    {

    //        Day = (day >= 1 && day <= 31) ? day : 1;
    //        Month = (month >= 1 && month <= 12) ? month : 1;
    //        Year = (year >= 1900 && year <= DateTime.Now.Year) ? year : 2000;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{

    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public double Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    public Gender Gender { get; set; }


    //    public Employee(int id, string name, Gender gender, double salary, HireDate hireDate, SecurityLevel securityLevel)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        Salary = salary > 0 ? salary : 0;
    //        HireDate = hireDate;
    //        SecurityLevel = securityLevel;
    //    }


    //    public override string ToString()
    //    {
    //        return $"Employee ID: {ID}\n" +
    //               $"Name: {Name}\n" +
    //               $"Gender: {Gender}\n" +
    //               $"Security Level: {SecurityLevel}\n" +
    //               $"Salary: {string.Format("{0:C}", Salary)}\n" +
    //               $"Hire Date: {HireDate}\n";
    //    }
    //}






}










#endregion

#region Q.2
//public class HireDate
//{

//public int Day { get; set; }
//public int Month { get; set; }
//public int Year { get; set; }


//public HireDate(int day, int month, int year)
//{

//    Day = (day >= 1 && day <= 31) ? day : 1;

//    Month = (month >= 1 && month <= 12) ? month : 1;


//    Year = (year >= 1900 && year <= DateTime.Now.Year) ? year : 2000;
//}


//public HireDate()
//{
//    Day = 1;
//    Month = 1;
//    Year = 2000;
//}


//public override string ToString()
//{
//    return $"{Day:D2}/{Month:D2}/{Year}";
//}
//}
#endregion

#region Q.3 

//public enum Gender
//{
//    M, 
//    F 
//}





#endregion

#region Q.4
//public enum SecurityLevel
//{
//    Guest,
//    Developer,
//    Secretary,
//    DBA
//}
#endregion

#region Q.5
//public class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int  Security { get; set; }
//    public double Salary { get; set; }
//    public int  HireDate { get; set; }
//    public string  Gender { get; set; }

//    public Employee(int id, string name, string gender, double salary, int hireDate, int security)
//    {
//        ID = id;
//        Name = name;
//        Gender = gender;
//        Salary = salary;
//        HireDate = hireDate;
//        Security = security;
//    }

//    public override string ToString()
//    {
//        return $"ID: {ID}\n" +
//               $"Name: {Name}\n" +
//               $"Gender: {Gender}\n" +
//               $"Security Level: {Security}\n" +
//               $"Hire Date: {HireDate}\n" +
//               $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}";
//    }
//}
#endregion

#region Q.6

public enum Gender
{
    M, 
    F  
}
public enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA,
    SecurityOfficer 
}
public class HireDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HireDate(int day, int month, int year)
    {
        if (day < 1 || day > 31) day = 1;
        if (month < 1 || month > 12) month = 1;
        if (year < 1900) year = 2000;

        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public double Salary { get; set; }
    public HireDate HireDate { get; set; }
    public SecurityLevel Security { get; set; }

    public Employee(int id, string name, Gender gender, double salary, HireDate hireDate, SecurityLevel security)
    {
        ID = id;
        Name = name;
        Gender = gender;
        Salary = salary > 0 ? salary : 0;
        HireDate = hireDate;
        Security = security;
    }

    public override string ToString()
    {
        return $"ID: {ID}\n" +
               $"Name: {Name}\n" +
               $"Gender: {Gender}\n" +
               $"Security Level: {Security}\n" +
               $"Hire Date: {HireDate}\n" +
               $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\n";
    }
}



#endregion


#endregion



















