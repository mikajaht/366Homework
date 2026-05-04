using System;
using System.IO;

namespace Homework_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine("Good Bye...");
        }

        public static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 10");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;
        }

        private static bool Run(string exeArg)
        {
            switch (exeArg.ToLower())
            {
                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "e":
                    return true;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    Pause();
                    return true;
            }
        }

        private static void DoExe1()
        {
            // Add code for Exercise 1 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            // Ask the user to enter a directory path.
            string directory;

            Console.WriteLine("Directory Information");
            Console.WriteLine();

            Console.Write("Enter a directory >> ");
            directory = Console.ReadLine();

            // Continue asking for directories until the user types "end".
            while (directory.ToLower() != "end")
            {
                // Check whether the directory exists.
                if (Directory.Exists(directory))
                {
                    // Store all files from the directory in an array.
                    string[] files = Directory.GetFiles(directory);

                    Console.WriteLine();
                    Console.WriteLine(directory + " contains the following files");

                    // Display a message if the directory has no files.
                    if (files.Length == 0)
                    {
                        Console.WriteLine("There are no files in this directory.");
                    }
                    else
                    {
                        // Display each file in the directory.
                        foreach (string file in files)
                        {
                            Console.WriteLine("   " + file);
                        }
                    }
                }
                else
                {
                    // Display a message if the directory does not exist.
                    Console.WriteLine();
                    Console.WriteLine("Directory " + directory + " does not exist");
                }

                Console.WriteLine();
                Console.Write("Enter another directory or type end to quit >> ");
                directory = Console.ReadLine();
            }

            Pause();
        }

        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("File Comparison");
            Console.WriteLine();

            // Ask the user to enter the full path for the Word document.
            Console.Write("Enter the full path of the Word file >> ");
            string wordFileName = Console.ReadLine().Trim('"');

            // Ask the user to enter the full path for the Notepad text file.
            Console.Write("Enter the full path of the Notepad file >> ");
            string notepadFileName = Console.ReadLine().Trim('"');

            Console.WriteLine();

            // Make sure both files exist before comparing their sizes.
            if (File.Exists(wordFileName) && File.Exists(notepadFileName))
            {
                // Create FileInfo objects so the program can access file details.
                FileInfo wordFileInfo = new FileInfo(wordFileName);
                FileInfo notepadFileInfo = new FileInfo(notepadFileName);

                // Store each file size in bytes.
                long wordFileSize = wordFileInfo.Length;
                long notepadFileSize = notepadFileInfo.Length;

                // Calculate the Notepad file size as a percentage of the Word file size.
                double ratio = (double)notepadFileSize / wordFileSize * 100;

                // Display the comparison results in a clean format.
                Console.WriteLine("File Size Comparison Results");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Word file size:    " + wordFileSize + " bytes");
                Console.WriteLine("Notepad file size: " + notepadFileSize + " bytes");
                Console.WriteLine("Ratio: The Notepad file is " + ratio.ToString("F2") + "% of the Word file size.");
            }
            else
            {
                // Display a helpful message if either file path is invalid.
                Console.WriteLine("One or both files could not be found.");
                Console.WriteLine();

                if (!File.Exists(wordFileName))
                {
                    Console.WriteLine("Word file not found: " + wordFileName);
                }

                if (!File.Exists(notepadFileName))
                {
                    Console.WriteLine("Notepad file not found: " + notepadFileName);
                }
            }

            Pause();
        }

        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            string fileName;
            string directory;
            string path;
            string[] files;
            int x;

            Console.WriteLine("Debugged Directory and File Code");
            Console.WriteLine();

            Console.Write("Enter a directory: ");
            directory = Console.ReadLine();

            // Check whether the directory exists before trying to get files.
            if (Directory.Exists(directory))
            {
                // Get all files from the directory.
                files = Directory.GetFiles(directory);

                // Check whether the directory contains any files.
                if (files.Length == 0)
                {
                    Console.WriteLine("There are no files in " + directory);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(directory + " contains the following files");

                    // Display each file using a for loop.
                    for (x = 0; x < files.Length; ++x)
                    {
                        Console.WriteLine(" " + files[x]);
                    }

                    Console.WriteLine();
                    Console.Write("Enter a file name: ");
                    fileName = Console.ReadLine();

                    // Build the full file path safely.
                    path = Path.Combine(directory, fileName);

                    // Check whether the selected file exists.
                    if (File.Exists(path))
                    {
                        Console.WriteLine();
                        Console.WriteLine("File exists and was created " + File.GetCreationTime(path));
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(fileName + " does not exist in the " + directory + " directory");
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Directory " + directory + " does not exist");
            }

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}