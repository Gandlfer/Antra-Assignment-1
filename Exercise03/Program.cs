namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1a
            //FizzBuzz
            /*
            for (int i = 1; i <= 100; i++) 
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output == "")
                {
                    Console.WriteLine(i);
                    continue;
                }
                Console.WriteLine(output);

            }
            */

            //1b
            //Creates an infinite loop because byte gets overflowed over to 0 after reaching 255

            /*
            int max = 500;
            if (max>byte.MaxValue)
            {
                Console.WriteLine("Byte can get overflowed");
            }
            */


            // 2

            /*
            for(int i  = 0; i < 5; i++) { 
                string space = "";
                string star = "";
                for (int j = 0; j < 4-i; j++)
                {
                  space+= " ";
                }
                for (int j = 0; j < 1+ (2*i); j++)
                {
                    star += "*";
                }
                Console.WriteLine(space + star+space);
            }
            */

            // 3.
            /*
            int correctNumber = new Random().Next(3) + 1;
            Console.Write("Enter a Number: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Answer out of range 1 - 3");
            }
            else if (guessedNumber == correctNumber)
            {
                Console.WriteLine("You guessed the correct number");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Low");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("High");
            }
            */

            // 4.
            /*
            DateTime today = DateTime.Today;
            DateTime birthDate = new DateTime(1996, 12, 25);
            int daysOld = Convert.ToInt32(today.Subtract(birthDate).TotalDays);
            Console.WriteLine("Days Old: "+ daysOld);
            int anniversaryDays = 10000 - (daysOld % 10000);
            DateTime anniversaryDate = today.AddDays(anniversaryDays);
            Console.WriteLine("Next 10000 days anniversary: " + anniversaryDate.ToString("MM/dd/yyyy"));
            */

            // 5.
            /*
            DateTime today = DateTime.Now;
            DateTime Morning = new DateTime(today.Year, today.Month, today.Day, 6, 0, 0);
            DateTime Afternoon = new DateTime(today.Year, today.Month, today.Day, 12, 0, 0);
            DateTime Evening = new DateTime(today.Year, today.Month, today.Day, 18, 0, 0);
            DateTime Night = new DateTime(today.Year, today.Month, today.Day, 21, 0, 0);
            if (today >= Night || today < Morning)
            {
                Console.WriteLine("Good Night");
            }
            if (today >= Morning && today < Afternoon)
            {
                Console.WriteLine("Good Morning");
            }
            if (today >= Afternoon && today < Evening)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (today >= Evening && today < Night)
            {
                Console.WriteLine("Good Evening");
            }
            */

            // 6.
            /*
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 0; y <= 24; y += x)
                {
                    if (y != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            */







        }
    }
}
