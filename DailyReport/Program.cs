using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");       //Displaying Greeting Message
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");    //Displaying question
            string name = Console.ReadLine();           //declaring variable and assigning value based on user input
            Console.WriteLine("Hello " + name + ", please answer all questions.");      //Personal Greeting message
            Console.WriteLine("What course are you on?"); 
            string course = Console.ReadLine();         //declaring variable and assigning value based on user input
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();      //declaring variable and assigning value based on user input
            int pageNumberConverted = Convert.ToInt16(pageNumber);   //declaring another variable that has the value of the converted value of the previous answer in case it is needed later for mathematical operation
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();  //declaring variable and assigning value based on user input
            bool helpNeeded = Convert.ToBoolean(help);  //declaring another variable that has the value of the converted value of the previous answer in case it is needed later for logical operation
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine(); //declaring variable and assigning value based on user input
            Console.WriteLine("Is there any other feedback you`d like to share? Please be specific.");
            string feedback = Console.ReadLine(); //declaring variable and assigning value based on user input
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();  //declaring variable and assigning value based on user input
            byte hoursStudied = Convert.ToByte(hours);  //declaring another variable that has the value of the converted value of the previous answer in case it is needed later for mathematical operation
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.WriteLine("Press enter to exit program.");
            Console.ReadLine();
        }
    }
}
