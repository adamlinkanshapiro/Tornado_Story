using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändrar färg på texten
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You are leaving you house during a storm, you see the tornado heading for you.");
            Console.WriteLine("You have 2 choises, run to your basement or take your car, what do you do?");

            Console.WriteLine("Car or Basement");

            string userInput;
            userInput = Console.ReadLine().ToLower();


            // Läser in valet från användaren
            if (userInput == "car")
            {
                // Ändrar fär på texten
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You start to drive, seeing the tornado riping your house apart behind you, youre thinking....where should I go?");
                Console.WriteLine("You remember that your boss has a bunker and you start to head but when you get there its, should you stop and call him or keep going?");

                Console.WriteLine("Stop or Keep Going");
                userInput = Console.ReadLine().ToLower();

                // Läser in valet från användaren
                if (userInput == "stop")
                {
                    Console.WriteLine("You kncok on the big metal doors to the nuclear protected bunker but there is no answer, but the you remember that he is on vacation.");
                    Console.WriteLine("You look back and see a huge tornado tumbling towoards you, you get sucked up and the you're dead......:(");
                }

                // Läser in valet från användaren
                else if (userInput == "keep going")
                {
                    Console.WriteLine("You see that you have a full tank of fuel and a Toyota Supra MK4 with a turbo so you kick it and escapse the tornado");
                }
            }

            // Läser in valet från användaren
            else if (userInput == "basement")
            {
                // Ändrar färg på texten
                Console.ForegroundColor = ConsoleColor.Magenta;


                Console.WriteLine("You runt down to the basement and close the doors behind you, you can hear the tornado heading for you");
                Console.WriteLine("The tornado runs over you house and the door slams open, what will you do? Close the door or hide under a table?");

                Console.WriteLine("Close or Hide");
                userInput = Console.ReadLine().ToLower();

                // Läser in valet från användaren
                if (userInput == "close")
                {
                    Console.WriteLine("You go up to close the door and the tornade runs over your head and you are dead....:(");
                }

                // Läser in valet från användaren
                else if (userInput == "hide")
                {
                    Console.WriteLine("The tornado passes over your house but you are safe");
                }

            }

            Console.ReadLine();

        }



    }



}


