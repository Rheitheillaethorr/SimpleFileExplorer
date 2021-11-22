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
            Test.ReadAllFiles();
            Test.CDBack();
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
            DirectoryInfo di = new DirectoryInfo (@PresentDirectory);
            foreach (var fi in di.GetDirectories())
            {
                Console.WriteLine(fi.Name);
            }
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
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
            Console.WriteLine(PresentDirectory);
        }
    }
}
