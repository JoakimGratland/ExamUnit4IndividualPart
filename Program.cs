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
            Console.WriteLine($"{Text.pleaseProvideAFilePathAsAnArgument}");
            return;
        }

        string searchTerm1 = $"{Text.redWasPressed}"; 
        string searchTerm2 = $"{Text.blueWasPressed}";
        string searchTerm3 = $"{Text.greenWasPressed}";
        string searchTerm4 = $"{Text.yellowWasPressed}";
        string seartchTerm5 = $"{Text.redWasLit}";
        string seartchTerm6 = $"{Text.blueWasLit}";
        string seartchTerm7 = $"{Text.greenWasLit}";
        string seartchTerm8 = $"{Text.yellowWasLit}";
        
        
            using (StreamReader reader = new StreamReader(args[0]))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {                    
                    if (line.Contains(searchTerm1))
                    {
                        counterRedWasPressed++; 
                        Console.WriteLine($"{Text.found} " + line);
                    }
                         
                    else if (line.Contains(searchTerm2))
                    {
                        counterBlueWasPressed++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                      else if (line.Contains(searchTerm3))
                    {
                        counterGreenWasPressed++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                      else if (line.Contains(searchTerm4))
                    {
                        counterYellowWasPressed++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                    else if (line.Contains(seartchTerm5))
                    {
                        counterRedWasLit++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                    else if (line.Contains(seartchTerm6))
                    {
                        counterBlueWasLit++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                    else if (line.Contains(seartchTerm7))
                    {
                        counterGreenWasLit++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                    else if (line.Contains(seartchTerm8))
                    {
                        counterYellowWasLit++;
                        Console.WriteLine($"{Text.found} " + line);
                    }
                }
                    double redPressedAtRightTime = (double)counterRedWasPressed / counterRedWasLit;
                    double bluePressedAtRightTime = (double)counterBlueWasPressed / counterBlueWasLit;
                    double greenPressedAtRightTime = (double)counterGreenWasPressed / counterGreenWasLit;
                    double yellowPressedAtRightTime = (double)counterYellowWasPressed / counterYellowWasLit;

                    Console.WriteLine($"{Text.results}");
                    Console.WriteLine($"{Text.redWasPressedCount} {counterRedWasPressed} {Text.times}");
                    Console.WriteLine($"{Text.redWasLitCount} {counterRedWasLit} {Text.times}");
                    Console.WriteLine($"{Text.redWasPressedAtRightTime} {redPressedAtRightTime * 100}{Text.precentageOfTheTime}");

                    Console.WriteLine($"{Text.blueWasPressedCount} {counterBlueWasPressed} {Text.times}");
                    Console.WriteLine($"{Text.blueWasLitCount} {counterBlueWasLit} {Text.times}");
                    Console.WriteLine($"{Text.blueWasPressedAtRightTime} {bluePressedAtRightTime * 100}{Text.precentageOfTheTime}");

                    Console.WriteLine($"{Text.greenWasPressedCount} {counterGreenWasPressed} {Text.times}");
                    Console.WriteLine($"{Text.greenWasLitCount} {counterGreenWasLit} {Text.times}");
                    Console.WriteLine($"{Text.greenWasPressedAtRightTime} {greenPressedAtRightTime * 100}{Text.precentageOfTheTime}");


                    Console.WriteLine($"{Text.yellowWasPressedCount} {counterYellowWasPressed} {Text.times}");
                    Console.WriteLine($"{Text.yellowWasLitCount} {counterYellowWasLit} {Text.times}");
                    Console.WriteLine($"{Text.yellowWasPressedAtRightTime} {yellowPressedAtRightTime * 100}{Text.precentageOfTheTime}");
                   
            }
    }
}