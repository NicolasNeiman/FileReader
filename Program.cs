using System;
using System.IO;
using System.Collections;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No argument passed");
            }
            else
            {
                string curentFolder = Directory.GetCurrentDirectory();
                string relativePath = args[0];
                string absolutePath = $"{curentFolder}\\{relativePath}";

                if (!File.Exists(absolutePath) && !File.Exists(relativePath))
                {
                    Console.WriteLine(absolutePath);
                    string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }
                    }
                    Console.WriteLine(Directory.GetCurrentDirectory());
                    Console.WriteLine("No file found");
                }
                else
                {
                    string path = "";
                    if (File.Exists(relativePath))
                    {
                        path = relativePath;
                    }
                    else
                    {
                        path = absolutePath;
                    }
                    using StreamReader file = File.OpenText(path);
                    {
                        string s = "";
                        while ((s = file.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
            }
        }
    }
}
