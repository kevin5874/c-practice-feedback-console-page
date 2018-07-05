using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName;
            string castInput;
            byte pageNumber;
            bool needHelp;
            string positiveExperiences;
            string feedback;
            int hoursStudiesd;
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you on");
            courseName = Console.ReadLine();
            Console.WriteLine("What page Number?");
            castInput = Console.ReadLine();
            try
            {
                pageNumber = Convert.ToByte(castInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid page number");
                pageNumber = 0;
            }
            Console.WriteLine("Do you need any help? Yes or No");
            castInput = Console.ReadLine();
            if(castInput.ToLower() == "yes")
            {
                needHelp = true;
            }
            else if(castInput.ToLower() == "no")
            {
                needHelp = false;
            }
            else
            {
                Console.WriteLine("Invalid answer, please Email if you need help");
                needHelp = false;
            }
            Console.WriteLine("Any positive experiences you'd like to share?");
            positiveExperiences = Console.ReadLine();
            Console.WriteLine("Any other feedback?");
            feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            castInput = Console.ReadLine();
            try
            {
                hoursStudiesd = Convert.ToInt32(castInput);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid number");
            }
            Console.ReadKey();

        }
    }
}
