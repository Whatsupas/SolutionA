using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemASolution
{
    class Program
    {
        static void Main(string[] args)
        {

            var linesQueue = new Queue<string>();
            var inputLine = string.Empty;
            
            // Input
            while (true)
            {
                inputLine = Console.ReadLine();
                if (string.IsNullOrEmpty(inputLine))
                {
                    linesQueue.Enqueue(inputLine);
                    inputLine = Console.ReadLine();

                    if (string.IsNullOrEmpty(inputLine))
                        break;
                }
                linesQueue.Enqueue(inputLine);
            }
                    
            // Output
            try 
            {
                var line = string.Empty;
                var lineLength = 0;
                var lastIndex = 0;
                var starsInLine = 0;
                var totalStars = 0;

                while (linesQueue.Any())
                {

                    line = linesQueue.Dequeue();

                    if (!string.IsNullOrEmpty(line) && line.Length > 0)
                    {

                        lineLength = line.Length;
                        lastIndex = lineLength - 1 - totalStars;
                        starsInLine = line.Count(x => x == '*');
                        totalStars += starsInLine;
                        var rangeFrom = lastIndex - starsInLine + 1;

                        var availableIndexes = Enumerable.Range(rangeFrom, starsInLine).ToDictionary(x => x);

                        for (int i = 0; i < lineLength; i++)
                        {
                            if (availableIndexes.ContainsKey(i))
                                Console.Write("*");
                            else
                                Console.Write(".");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        lineLength = 0;
                        lastIndex = 0;
                        starsInLine = 0;
                        totalStars = 0;

                        if (linesQueue.Count != 0)
                            Console.WriteLine();
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Output line");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
