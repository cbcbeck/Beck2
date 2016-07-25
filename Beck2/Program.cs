using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beck2
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: "); 
            string name = Console.ReadLine(); 
            Console.WriteLine("Please enter your birth month: "); 
            string month = Console.ReadLine(); 
            StringOperations.BirthMonthMessage(name, month); 
            Console.ReadKey();
        }
        
        public static void BirthMonthMessage(string name, string birth_month)
        {
            string message = string.Empty;
            string bm = birth_month.First().ToString().ToUpper() + birth_month.Substring(1);
             
			   
            if (bm == "January" || bm == "February" || bm == "March" || bm == "May" || bm == "June" || bm == "July" || bm == "September" || bm == "November" || bm == "December")
            {
                message = name + " is a " + bm + " baby!"; 
            }
            else if (bm == "April" || bm == "August" || bm == "October")
            {
                message = name + "is an " + bm + " baby!"; 
            }
            else
            {
                message = ("You did not enter a valid birth month!!"); 
            }
            Console.WriteLine(message); 
        }
    }
}
