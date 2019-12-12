using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName;
            String LastName;
            String FullName = "";
            string input;

            Console.Write("Please enter your first name:");
            input = Console.ReadLine();
            FirstName = input;

            Console.Write("Please enter your Last name:");
            input = Console.ReadLine();
            LastName = input;

            FullName = string.Concat(FirstName.ToUpper()," ", LastName.ToUpper());
            Console.WriteLine("Your full name is: "+ FullName);

            Console.Write("Please enter a text:");
            input = Console.ReadLine();
            String text1 = input;

            Console.Write("Please enter a string you want to replace:");
            input = Console.ReadLine();
            string OldString = input;

            Console.Write("Please enter a string that will replace '" + OldString + "' :");
            input = Console.ReadLine();
            string NewString = input;

            text1 = text1.Replace(OldString, NewString);
            Console.WriteLine("The new text is: " + text1);

            Console.Write("Please enter a text:");
            input = Console.ReadLine();
            string text2 = input;

            Console.Write("Please enter a string you want to remove:");
            input = Console.ReadLine();
            OldString = input;

            int indexOfOldString = text2.IndexOf(OldString);
            String Newtext2 = text2.Remove(indexOfOldString, OldString.Length); 
            Console.WriteLine("The new text is: " + Newtext2);


            Console.Write("Please enter a string or just press enter: ");
            input = Console.ReadLine();
            string text3 = input;

            if (string.IsNullOrEmpty(text3))
            {
                Console.WriteLine("String null sau gol.");
            }
            else
            {
                Console.WriteLine("Stringul are continut: " + text3);
            }

        }
    }
}
