using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Security;
namespace DAY01_G01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //Console.WriteLine("Enter your Number:");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Number is: " + Number);

            #endregion


            #region Q2



            //Console.Write("Enter a string containing numbers: "); 
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Number is: " + input); //unhandle exeption

            #endregion


            #region Q3

            //float Num1 = 2.5f, Num2 = 3.4f;
            //float Sum;
            //Sum = Num1 + Num2;
            //Console.WriteLine("Result = " + Sum); 
            //Console.ReadLine();

            #endregion


            #region Q4

            //Console.Write("Enter a string : "); 
            //string input = Console.ReadLine();
            //Console.Write("Enter a Index : "); 
            //int Index = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sub String1: " + input.Substring(Index));
            //Console.ReadLine();


            #endregion


            #region Q5


            //int Num1 = 10;
            //    int Num2 = Num1;
            //
            //    Console.WriteLine("Original Value: " + Num1); //10
            //    Console.WriteLine("Copied Value: " + Num2); //10
            //
            //Num2 = 20;
            //
            //Console.WriteLine("Original Value after change: " + Num1); //10
            //Console.WriteLine("Copied Value after change: " + Num2);   //20  
            //Console.ReadLine();

            #endregion


            #region Q7


            //Console.Write("Enter the first Name: ");
            //string firstname = Console.ReadLine();
            //
            //Console.Write("Enter the second Name: ");
            //string secondname = Console.ReadLine();
            //
            //string fullname = firstname + " " + secondname;
            //
            //Console.WriteLine("Full Name: " + fullname);
            //
            //Console.ReadLine();



            #endregion


            #region Q8

            //Console.Write("Enter the principal amount : ");
            //double principal = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the rate of interest : ");
            //double rate = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the time in years : ");
            //double time = double.Parse(Console.ReadLine());
            //
            //double interest = (principal * rate * time) / 100;
            //
            //Console.WriteLine("The calculated simple interest is: " + interest);
            //
            //Console.ReadLine();
            //

            #endregion

            #region Q9

            //Console.Write("Enter your weight in kilograms: ");
            //double weight = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter your height in meters: ");
            //double height = double.Parse(Console.ReadLine());
            //
            //double bmi = weight / (height * height);
            //
            //Console.WriteLine("Your BMI is: " + bmi);
            //
            //Console.ReadLine();

            #endregion

            #region Q10

            //Console.Write("Enter the temperature in degrees: ");
            //int temperature = int.Parse(Console.ReadLine());
            //
            //string result = (temperature < 10) ? "Just Cold"  :
            //(temperature > 30) ? "Just Hot" :
            //"Just Good";
            //
            //Console.WriteLine("The temperature is: " + result);
            //
            //Console.ReadLine();
            //
            #endregion


            #region Q11

    
                Console.Write("Enter the day: ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Enter the month: ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Enter the year: ");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine($"Today's date: {day} , {month} , {year}");
                Console.WriteLine($"Today's date: {day} / {month} / {year}");
                Console.WriteLine($"Today's date: {day} – {month} – {year}");

                Console.ReadLine();
       
        #endregion

           // 12 = C
           // 13 = F
           // 14 = D
           // 15 = D






    }



}
}
