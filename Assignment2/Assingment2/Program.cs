//Created By: Jordan Hamilton
//Date: 16/03/24
//Purpose: allows the user to manipulate the properties of a rectangle
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

class Assingment2
{
    public static void Main(string[] args)
    {
        int length = 0, width = 0;

        //enters a loop to get the length from the user
        bool hasPassed = false;
        while (!hasPassed)
        {
            try
            {
                Console.WriteLine("Please Enter The Length of The Rectangle!");
                length = int.Parse(Console.ReadLine());

                if (length == 0)
                {
                    throw new Exception();
                }
                if (length > 0)
                {
                    hasPassed = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter An Integer Value Greater than 0");
            }
        }

        //Enters a Loop to get the Width
        bool hasPassedAgain = false;
        while (!hasPassedAgain)
        {
            try
            {
                Console.WriteLine("Please Enter The Width of The Rectangle!");
                width = int.Parse(Console.ReadLine());

                if (width == 0)
                {
                    throw new Exception();
                }
                if (width > 0)
                {
                    hasPassedAgain = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter An Integer Value Greater than 0");
            }

        }

        //creates the rectangle with the user defined parameters
        Assignment2.Rectangle rect = new Assignment2.Rectangle();
        rect.setLength(length);
        rect.setWidth(width);

        //main program loop
        bool running = true;
        while (running)
        {
            //Shows the user the Menu
            Console.WriteLine("Program Menu:");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Permimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            int input = int.Parse(Console.ReadLine());

            if (input == 7)
            {
                Environment.Exit(0);
            }
            if (input <= 0 || input >= 8)
            {
                Console.WriteLine("Please Enter An Integer Value Between 1 and 7");
            }
            if (input == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("The Length is: " + rect.GetLength());
            }
            if (input == 2)
            {
                int newLength = 0;
                bool gettingLength = true;
                while (gettingLength)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What Would you like to Change the Length to?");
                    newLength = int.Parse(Console.ReadLine());

                    if (newLength < 1)
                    {
                        Console.WriteLine("Value Cannot be Less than 1!");
                    }
                    else
                    {
                        gettingLength = false;
                    }
                }

                rect.setLength(newLength);
                Console.WriteLine("The New Length is: " + newLength);
            }
            if (input == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("The Width is: " + rect.GetWidth());
            }
            if (input == 4)
            {
                int newWidth = 0;
                bool gettingWidth = true;
                while (gettingWidth)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What Would you Like to Change the Width to?");
                    newWidth = int.Parse(Console.ReadLine());

                    if (newWidth < 1)
                    {
                        Console.WriteLine("Value Cannot Be Less Than 1!");
                    }
                    else
                    {
                        gettingWidth = false;
                    }
                }

                rect.setWidth(newWidth);
                Console.WriteLine("The new Width is: " + newWidth);
            }
            if (input == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("The Perimeter of this Rectangle is: " + rect.getPerimeter());
            }
            if (input == 6)
            {
                Console.WriteLine("");
                Console.WriteLine("The Area of The Rectangle is: " + rect.getArea());
            }

            Console.WriteLine("");
        }
    }
}
