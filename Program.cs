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
              string ln = string.Empty;

                    
                        while (true)
                        {
                            ln = Console.ReadLine();
                            if (String.IsNullOrEmpty(ln))
                            {
                                linesQueue.Enqueue(ln);
                                ln = Console.ReadLine();
                                if (string.IsNullOrEmpty(ln))
                                {
                                    break;
                                }
                            }
                            linesQueue.Enqueue(ln);
                        }
                    

                    try {

                        string line = string.Empty;
                        int lineLength = 0;
                        int lastIndex = 0;
                        int starsInLine = 0;
                        int totalStars = 0;

                        while (linesQueue.Any())
                        {

                            line = linesQueue.Dequeue();

                            if (!String.IsNullOrEmpty(line) && line.Length > 0)
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
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
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
                                {
                                    Console.WriteLine();
                                }

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
