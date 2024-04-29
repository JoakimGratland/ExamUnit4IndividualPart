using System;
using System.IO;

class FileReader
{
    static void Main(string[] args)
    {
        int counterRedWasPressed = 0;
        int counterBlueWasPressed = 0;
        int counterGreenWasPressed = 0;
        int counterYellowWasPressed = 0;
        int counterRedWasLit = 0;
        int counterBlueWasLit = 0;
        int counterGreenWasLit = 0;
        int counterYellowWasLit = 0;
        
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a file path as an argument. Example: dotnet run myFile.txt");
            return;
        }

        string searchTerm1 = "redWas pressed"; 
        string searchTerm2 = "blueWas pressed";
        string searchTerm3 = "greenWas pressed";
        string searchTerm4 = "yellowWas pressed";
        string seartchTerm5 = "redwas lit";
        string seartchTerm6 = "bluewas lit";
        string seartchTerm7 = "greenwas lit";
        string seartchTerm8 = "yellowwas lit";
        
        
            using (StreamReader sr = new StreamReader(args[0]))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {                    
                    if (line.Contains(searchTerm1))
                    {
                        counterRedWasPressed++; 
                        Console.WriteLine("Found: " + line);
                    }
                         
                    else if (line.Contains(searchTerm2))
                    {
                        counterBlueWasPressed++;
                        Console.WriteLine("Found: " + line);
                    }
                      else if (line.Contains(searchTerm3))
                    {
                        counterGreenWasPressed++;
                        Console.WriteLine("Found: " + line);
                    }
                      else if (line.Contains(searchTerm4))
                    {
                        counterYellowWasPressed++;
                        Console.WriteLine("Found: " + line);
                    }
                    else if (line.Contains(seartchTerm5))
                    {
                        counterRedWasLit++;
                        Console.WriteLine("Found: " + line);
                    }
                    else if (line.Contains(seartchTerm6))
                    {
                        counterBlueWasLit++;
                        Console.WriteLine("Found: " + line);
                    }
                    else if (line.Contains(seartchTerm7))
                    {
                        counterGreenWasLit++;
                        Console.WriteLine("Found: " + line);
                    }
                    else if (line.Contains(seartchTerm8))
                    {
                        counterYellowWasLit++;
                        Console.WriteLine("Found: " + line);
                    }
                }
                    double redPressedAtRightTime = (double)counterRedWasPressed / counterRedWasLit;
                    double bluePressedAtRightTime = (double)counterBlueWasPressed / counterBlueWasLit;
                    double greenPressedAtRightTime = (double)counterGreenWasPressed / counterGreenWasLit;
                    double yellowPressedAtRightTime = (double)counterYellowWasPressed / counterYellowWasLit;

                    Console.WriteLine("Results:");
                    Console.WriteLine($"Red was pressed {counterRedWasPressed} times");
                    Console.WriteLine($"Red was lit {counterRedWasLit} times");
                    Console.WriteLine($"Red was pressed at the right time {redPressedAtRightTime * 100}% of the time");

                    Console.WriteLine($"Blue was pressed {counterBlueWasPressed} times");
                    Console.WriteLine($"Blue was lit {counterBlueWasLit} times");
                    Console.WriteLine($"Blue was pressed at the right time {bluePressedAtRightTime * 100}% of the time");

                    Console.WriteLine($"Green was pressed {counterGreenWasPressed} times");
                    Console.WriteLine($"Green was lit {counterGreenWasLit} times");
                    Console.WriteLine($"Green was pressed at the right time {greenPressedAtRightTime * 100}% of the time");


                    Console.WriteLine($"Yellow was pressed {counterYellowWasPressed} times");
                    Console.WriteLine($"Yellow was lit {counterYellowWasLit} times");
                    Console.WriteLine($"Yellow was pressed at the right time {yellowPressedAtRightTime * 100}% of the time");
                   
            }
    }
}