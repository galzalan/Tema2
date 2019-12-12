using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        public enum GenderType
        {
            Female = 1,
            Male = 2
        }
        static void Main(string[] args)
        {
            DateTime CurrentDate = DateTime.Now;
            int age;
            int? gender = null;

            Console.Write("Please provide the year when yoo were born:");
            string input = Console.ReadLine();
            int BirthYear = int.Parse(input);

            Console.Write("Please provide the month when yoo were born:");
            input = Console.ReadLine();
            int BirthMonth = int.Parse(input);

            Console.Write("Please provide the day when yoo were born:");
            input = Console.ReadLine();
            int BirthDay = int.Parse(input);

            Console.Write("Please provide Your gender. M for male or F for female:");
            input = Console.ReadLine();


            if (input.Equals("f") || input.Equals("F"))
            {
                gender = (int)GenderType.Female;
            }
            else if (input.Equals("m") || input.Equals("M"))
            {
                gender = (int)GenderType.Male;
            }

            DateTime BirthDate = new DateTime(BirthYear, BirthMonth, BirthDay);
            TimeSpan diff = CurrentDate.Subtract(BirthDate);
            age = diff.Days;
            age = age / 365;

            if (gender != null)
            {
                if (gender == 1)
                {
                    if (age > 63)
                    {
                        Console.WriteLine("You were born on "+ BirthDate.ToString("dd/MMM/yyyy") + " and you are "+age+" years old retired female.");
                    }
                    else
                    {
                        Console.WriteLine("You were born on " + BirthDate.ToString("dd/MMM/yyyy") + " and you are " + age + " years old female who will retire at the age 63");
                    }
                }
                else
                {
                    if (age > 65)
                    {
                        Console.WriteLine("You were born on " + BirthDate.ToString("dd/MMM/yyyy") + " and you are " + age + " years old retired male.");
                    }
                    else
                    {
                        Console.WriteLine("You were born on " + BirthDate.ToString("dd/MMM/yyyy") + " and you are " + age + " years old male who will retire at the age 65");
                    }
                }
            }
        }
    }
}
