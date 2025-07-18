using System;

namespace OOP_4
{


    #region Part 01

    #region Q1
    //internal class Calculator
    //{
    //    public int Add (int x, int y)
    //    {
    //        return x + y;
    //    }
    //    
    //    public int Add (int x , int y , int z)
    //    {
    //        return x + y + z;
    //    }
    //
    //    public double Add (double x ,  double y )
    //    {
    //        return x + y;
    //    }
    //}
    #endregion

    #region Q2
    //internal class Rectangle
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    public int Area()
    //    {
    //        Width = 0;
    //        Height = 0;
    //        Console.WriteLine("***********************");
    //        Console.WriteLine("The Area of Rectangle Is : ");
    //        return Width * Height;
    //    }
    //
    //    public int Area(int width , int height)
    //    {
    //        Width = width ;
    //        Height = height ;
    //        Console.WriteLine("***********************");
    //        Console.WriteLine("The Area of Rectangle Is : ");
    //        return (Width * Height);
    //    }   
    //
    //    public int Area(int Size)
    //    {
    //        Width = Size;
    //        Height = Size;
    //        Console.WriteLine("***********************");
    //        Console.WriteLine("The Area of Rectangle Is : ");
    //        return Width * Height;
    //    }
    //
    //}
    #endregion

    #region Q3
    //internal class Complex
    //{
    //    public int Real { get; set; }
    //    public int Imag { get; set; }
    //
    //    public static Complex operator +(Complex left, Complex right)
    //    {
    //        return new Complex()
    //        {
    //            Real = (left ?.Real ?? 0) + (right ?.Real ?? 0),
    //            Imag = (left ?.Imag ?? 0) + (right ?.Imag ?? 0),
    //        };
    //    }
    //
    //    public static Complex operator -(Complex left, Complex right)
    //    {
    //        return new Complex()
    //        {
    //            Real = (left?.Real ?? 0) - (right?.Real ?? 0),
    //            Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
    //        };
    //    }
    //
    //    public override string ToString()
    //    {
    //        return $"{Real} + {Imag}i";
    //    }
    //}
    #endregion

    #region Q4
    //public class Employee
    //{
    //    public virtual void Work()
    //    {
    //        Console.WriteLine("Employee Is Working");
    //    }
    //}
    //
    //public class Manager : Employee
    //{
    //    public override void Work()
    //    {
    //        base.Work();
    //        Console.WriteLine("Manager Is Managing");
    //    }
    //}
    #endregion

    #region Q5
    //public class BaseClass
    //{
    //    public virtual void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from BaseClass");
    //    }
    //}
    //
    //public class DerivedClass1 : BaseClass 
    //{
    //    public override void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass1");
    //    }
    //}
    //
    //public class DerivedClass2 : BaseClass
    //{
    //    public new void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass2");
    //    }
    //}
    #endregion


    #endregion

    #region Part 02
    //public class Duration
    //{
    //    public int Hours { get; private set; }
    //    public int Minutes { get; private set; }
    //    public int Seconds { get; private set; }
    //
    //    public Duration(int hours, int minutes, int seconds)
    //    {
    //        int totalSeconds = hours * 3600 + minutes * 60 + seconds;
    //        SetFromTotalSeconds(totalSeconds);
    //    }
    //
    //    public Duration(int totalSeconds)
    //    {
    //        SetFromTotalSeconds(totalSeconds);
    //    }
    //
    //    private void SetFromTotalSeconds(int totalSeconds)
    //    {
    //        Hours = totalSeconds / 3600;
    //        totalSeconds %= 3600;
    //        Minutes = totalSeconds / 60;
    //        Seconds = totalSeconds % 60;
    //
    //        if (Hours == 0 && Minutes > 0 && Seconds >= 0)
    //            Hours = 0;
    //    }
    //
    //    public override string ToString()
    //    {
    //        string output = "";
    //        if (Hours > 0)
    //            output += $"Hours: {Hours}, ";
    //        if (Minutes > 0 || Hours > 0)
    //            output += $"Minutes: {Minutes}, ";
    //        output += $"Seconds: {Seconds}";
    //        return output;
    //    }
    //
    //
    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Duration d)
    //        {
    //            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
    //        }
    //        return false;
    //    }
    //
    //    public override int GetHashCode()
    //    {
    //        return (Hours, Minutes, Seconds).GetHashCode();
    //    }
    //
    //    public int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;
    //
    //    // Using Syntax Suger
    //    public static Duration operator +(Duration d1, Duration d2)
    //        => new Duration(d1.TotalSeconds + d2.TotalSeconds);
    //
    //    public static Duration operator +(Duration d, int seconds)
    //        => new Duration(d.TotalSeconds + seconds);
    //
    //    public static Duration operator +(int seconds, Duration d)
    //        => new Duration(d.TotalSeconds + seconds);
    //
    //    public static Duration operator -(Duration d1, Duration d2)
    //        => new Duration(Math.Max(0, d1.TotalSeconds - d2.TotalSeconds));
    //
    //    public static Duration operator ++(Duration d)
    //        => new Duration(d.TotalSeconds + 60);
    //
    //    public static Duration operator --(Duration d)
    //        => new Duration(Math.Max(0, d.TotalSeconds - 60));
    //
    //    public static bool operator >(Duration d1, Duration d2)
    //        => d1.TotalSeconds > d2.TotalSeconds;
    //
    //    public static bool operator <(Duration d1, Duration d2)
    //        => d1.TotalSeconds < d2.TotalSeconds;
    //
    //    public static bool operator >=(Duration d1, Duration d2)
    //        => d1.TotalSeconds >= d2.TotalSeconds;
    //
    //    public static bool operator <=(Duration d1, Duration d2)
    //        => d1.TotalSeconds <= d2.TotalSeconds;
    //
    //    public static bool operator true(Duration d) => d.TotalSeconds > 0;
    //    public static bool operator false(Duration d) => d.TotalSeconds == 0;
    //
    //    public static explicit operator DateTime(Duration d)
    //        => new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Implementation
            #region Implement Q1
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(5, 7));
            //Console.WriteLine(calculator.Add(2.5, 7.7));
            //Console.WriteLine(calculator.Add(7, 8, 9));
            #endregion

            #region Implement Q2
            //Rectangle rec = new Rectangle();
            //Console.WriteLine(rec.Area());
            //Console.WriteLine(rec.Area(5));
            //Console.WriteLine(rec.Area(5 , 4));
            #endregion

            #region Implement Q3
            //Complex C1 = new Complex()
            //{
            //    Real = 5,
            //    Imag = 3,
            //};
            //
            //Complex C2 = new Complex()
            //{
            //    Real = 2,
            //    Imag = 4,
            //};
            //
            //Complex C3 = default;
            //C3 = C1 + C2;
            //
            //Complex C4 = default;
            //C4 = C2 - C1;
            //
            //Console.WriteLine($"C1 : {C1}");
            //Console.WriteLine($"C2 : {C2}");
            //Console.WriteLine($"C3 : {C3}");
            //Console.WriteLine($"C4 : {C4}");

            #endregion

            #region Implement Q4
            // Manager manager = new Manager();
            // manager.Work();
            #endregion

            #region Implement Q5
            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //// it will print her message "Message from BaseClass"
            //
            //BaseClass derived1 = new DerivedClass1();
            //derived1.DisplayMessage();
            //// the override Will use Dynamic Binding and will change the Message
            //// to "Message from DerivedClass1"
            //// can access the object 
            //
            //BaseClass derived2 = new DerivedClass2();
            //derived2.DisplayMessage();
            //// the New Keyword is a method hiding or Static Binding and will print BaseClass Message
            //// "Message from BaseClass"
            //// cannot access the object and will refere to the Reference

            #endregion

            #endregion

            #region Part 02 Implementation

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);
            //Console.WriteLine("*********************************");
            //Duration D2 = new Duration(7800);  
            //Console.WriteLine(D2);
            //Console.WriteLine("*********************************");
            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D3 = D1 + D2;
            //Console.Write("D3 = D1 + D2 Is : ");
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D3 = D1 + 7800;
            //Console.Write("D3 = D1 + 7800 Is : ");
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D3 = 666 + D3;
            //Console.Write("D3 = 666 + D3 Is : ");
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D3 = ++D1;
            //Console.Write("D3 = ++D1 Is : ");
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D3 = --D2;
            //Console.Write("D3 = --D1 Is : ");
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //
            //D1 = D1 - D2;
            //Console.Write("D1 = D1 - D2 Is : ");
            //Console.WriteLine(D1);
            //Console.WriteLine("*********************************");
            //
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine("Date Time Is : ");
            //Console.WriteLine(Obj);

            #endregion
        }
    }
}
