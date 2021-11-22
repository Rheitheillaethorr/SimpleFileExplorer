using System;
using System.IO;
namespace SimpleFileExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDirectory = @"D:\Programy\VisualStudio\Projects\SimpleFileExplorer";
            Files Test = new Files(firstDirectory);
            //Test.ReadAllFiles();
            //Test.CDBack();
            //Test.ReadAllFiles();
            //Test.CDNext();
            //Test.ReadAllFiles();
            //Test.WhereAmI();
            //Test.CDNext();
            //Test.WhereAmI();
            Test.UserChoice();
        }
    }
    class Files
    {
        public string PresentDirectory { get; set; }
        public Files(string firstDirectory)
        {
            PresentDirectory = firstDirectory;
        }
        public void ReadAllFiles()
        {
            //Console.WriteLine("\n"+PresentDirectory);
            DirectoryInfo di = new DirectoryInfo (@PresentDirectory);
            foreach (var fi in di.GetDirectories())
            {
                Console.WriteLine(fi.Name);
            }
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
            UserChoice();
        }
        public void CDBack()
        {
            string str1 = "\\";
            for (int i = PresentDirectory.Length; i>=0 ; i--)
            {
                if (string.Equals(Convert.ToString(PresentDirectory[PresentDirectory.Length - 1]), str1))
                {

                }
                else
                {
                    PresentDirectory = PresentDirectory.Remove(PresentDirectory.Length - 1);
                    
                }
            }
            PresentDirectory = PresentDirectory.Remove(PresentDirectory.Length - 1);
            UserChoice();
        }
        public void CDNext()
        {
            Console.WriteLine("Tell me next directory");
            string directory = Console.ReadLine();
            if (Directory.Exists(PresentDirectory + "\\" + directory))
            {
                PresentDirectory = PresentDirectory + "\\" + directory;
            }
            else
            {
                Console.WriteLine("This directory does not exist!");
            }
            UserChoice();
        }
        public void WhereAmI()
        {
            Console.WriteLine(PresentDirectory);
            UserChoice();
        }
        public void Help()
        {
            Console.WriteLine("available commands:");
            Console.WriteLine("'ls' list files and directories");
            Console.WriteLine("'pwd' prints the current working directory");
            Console.WriteLine("'cdnext' changing directory to selected directory");
            Console.WriteLine("'cdback' changing directory to previous in path");
            UserChoice();
        }
        public void UserChoice()
        {
            Console.WriteLine("\nInsert command, if you do not know what to use, use 'help' command\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "ls":
                    ReadAllFiles();
                    break;
                case "pwd":
                    WhereAmI();
                    break;
                case "cdnext":
                    CDNext();
                    break;
                case "cdback":
                    CDBack();
                    break;
                case "help":
                    Help();
                    break;
                default:
                    Console.WriteLine("Unknown command!");
                    UserChoice();
                    break;
            }
        }
    }
}
