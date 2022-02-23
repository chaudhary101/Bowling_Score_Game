using System;

namespace InterviewPreparationTest
{
    class GFG
    {

        // readonly variables
        public readonly int myvar1;
        public readonly int myvar2;

        // Values of the readonly
        // variables are assigned
        // Using constructor
        public GFG(int b, int c)
        {

            myvar1 = b;
            myvar2 = c;
            Console.WriteLine("Display value of myvar1 {0}, " +
                            "and myvar2 {1}", myvar1, myvar2);
        }

        // Main method
        static public void Main()
        {
            GFG obj1 = new GFG(100, 200);
        }
    }

    //public class Program
    //{
    //    public static readonly int a; 
    //    static void Main(string[] args)
    //    {
    //        var isNumeric = int.TryParse("123", out int n);

    //        object a = 10;
    //        object b = 20;
    //        object c = 2 + 9000000000000;
    //        Console.WriteLine(c);

    //        string s1 = "asdf";
    //        string s2 = s1;
    //        s1 = s1 + "as";
    //        Console.WriteLine(isNumeric);
    //        getdate(25,0);

    //    }

    //    public static void getdate(int i , int j)
    //    {
    //        try
    //        {
    //            a = i;

    //            int t = i / j;
    //            Console.WriteLine(t);
    //        }
    //        catch (Exception ex)
    //        {

    //            throw;
    //        }
           

             
    //    }
    //}
}
