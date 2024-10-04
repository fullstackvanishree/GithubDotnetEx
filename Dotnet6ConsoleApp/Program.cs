// ShortCut Keys
//Console.Writeline-----cw+tab
//comment multiple line at one time----Ctrl+KC
//uncomment multiple line at one time----Ctrl+KU
//alignment----Ctrl+kd
using Dotnet6ConsoleApp.Constants;
using System.Runtime.InteropServices;
using System.Text;

namespace Dotnet6ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region datatypes
            //Explicit type declaration
            //int productId = 101;
            //string productName = "TV";
            //float rating = 4.4F;
            //decimal price = 400.23M;
            ////Console.WriteLine(productId);
            ////Console.WriteLine(productName);
            ////Console.WriteLine(rating);
            //Console.WriteLine($"ProductId::{productId}\tProductName::{productName}\tRating::{rating}\tPrice::{price}");
            ////Implicit type Declaration
            //var category = "Electronics";
            #endregion
            #region UserInput
            //Get Product name from the user and print it back to the console window
            //Console.WriteLine("Enter the Product Name::");
            //string product_Name = Console.ReadLine();
            //Console.WriteLine("enter the Product price::");
            //int productPrice = int.Parse(Console.ReadLine());
            //int productPrice=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"ProductName::{product_Name}\tproductPrice::{productPrice}");
            #endregion
            #region Nullable Types
            //int marks = default;

            //bool isPassed= default;
            //string name = default;
            //Console.WriteLine($"Default int::{marks}\nDefault for bool::{isPassed}\ndefault for string::{name}");
            //int? rollNum = null;
            //string city = null;
            ////assigning nullable type to non-nullable type
            //int regNum = rollNum ?? 0;
            #endregion
            #region Boxing and Unboxing
            //int marks = 23;
            //double marks1 = marks;
            //double percentage = 23.456;
            //int marks2 = (int)percentage;
            //string name = "vani";
            ////boxing
            //object input1 = marks;
            ////object input2 = name;
            ////unboxing
            //int input2 = (int)input1;
            #endregion
            #region Var and Dynamic Keywords

            //var name = "vani";
            //dynamic city;
            //city = "bangalore";
            #endregion
            #region String Builder
            //string msg = "C#";
            //string msg1 = "Training";
            //string msg3 = msg + msg1;

            //StringBuilder sb = new StringBuilder();
            //sb.Append(msg);//c#
            //sb.Append("");
            //sb.Append("msg1");

            //Console.WriteLine(sb.Capacity);

            //DateTime startTime;
            //DateTime endTime;
            //TimeSpan totalTime;
            //string s = "";
            //startTime = DateTime.Now;
            //for(int i=0;i<10000;i++ )
            //{
            //    s += i;
            //}
            //endTime= DateTime.Now;
            //totalTime = endTime - startTime;
            //Console.WriteLine($"Total time taken is :::{totalTime}");//0.9555
            //Console.WriteLine(startDate);

            //StringBuilder sb = new StringBuilder();
            //startTime = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.Append(i);
            //}
            //endTime = DateTime.Now;
            //totalTime = endTime - startTime;
            //Console.WriteLine($"Total time taken is :::{totalTime}");//0.0037

            #endregion
            #region enums
            //int status = 0;
            //if (status == (int)TicketStatus.Booked)
            //{
            //    Console.WriteLine("Ticket is booked");
            //}
            //else if (status == (int)TicketStatus.Available)
            //{
            //    Console.WriteLine("ticket available");
            //}
            //else
            //{
            //    Console.WriteLine("no tickets");
            //}
            //Console.WriteLine(TicketStatus.Booked);

            #endregion
            int a = 5;//0101
            int b = 10;//1010
            int result = a & b;
            Console.WriteLine(result);

            int marks = 100;
            
            
            Console.WriteLine(marks);
            Console.WriteLine("hello");
            Console.WriteLine("Adding statement for github demo");
           

            /* Accept product name & product price from the user
            if the product price is > 50000 give a discount of 1000Rs
            total amount customer has to pay is ProductPrice - discount + gst(18 % of productprice)
             print the product Name along with amount to be paid
            "Your order amount for {productName} is {TotalAmount}"*/

            /* Accept user Input for temperature,
             if the input is above 100--display msg High Temperature 
              other wise display a message Normal
            implement this check using ternary Opeartor
             */

            /* you are building a system where  optional settings may not be provided by the user. 
             * If a setting is null,  assign a default value. 
             * How would you use the null-coalescing operator (??) to achieve this in C#? 
          
        */
        }
    }

}
