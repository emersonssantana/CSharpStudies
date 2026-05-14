using System;
using System.IO;
using System.Collections.Generic;

namespace CSharpStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] logRecord = sr.ReadLine().Split(',');
                        string name = logRecord[0];
                        int votes = int.Parse(logRecord[1]);

                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += votes;
                        }
                        else
                        {
                            dictionary[name] = votes;
                        }
                    }
                    foreach (var item in  dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}


