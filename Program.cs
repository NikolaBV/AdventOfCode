using System;

void DayOne()
{
    String line;
    int value = 50;
    int zeroCounter = 0;
    try
    {
        StreamReader streamReader = new StreamReader("C:\\Programming\\C#\\AdventOfCode\\assets\\day1\\rotations.txt");
        line = streamReader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);

            char direction = line[0];
            string distanceInString = "";

            if (line.Length > 3)
            {
                Console.WriteLine("");
            }
            distanceInString = line.Substring(1, line.Length - 1);

            int distance = Int32.Parse(distanceInString);

            if (direction == 'L')
            {
                value = value - distance;

            }
            else if (direction == 'R')
            {
                value = value + distance;
            }

            while (value < 0)
            {
                value = value + 100;
            }

            while (value > 99)
            {
                value = value - 100;
            }

            if (value == 0)
            {
                zeroCounter = zeroCounter + 1;
            }
            line = streamReader.ReadLine();
        }

        streamReader.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }

    Console.WriteLine("Password is: " + zeroCounter);
}


void DayTwo()
{
    String line;

    try
    {
        StreamReader streamReader = new StreamReader("C:\\Programming\\C#\\AdventOfCode\\assets\\day1\\rotations.txt");
        line = streamReader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
        }

        streamReader.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
}
//DayOne();