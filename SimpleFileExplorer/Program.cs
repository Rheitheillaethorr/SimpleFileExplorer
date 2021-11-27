using System;
using System.IO;
using System.Linq;
namespace SimpleFileExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstDirectory = @"d:\Programy\VisualStudio\Projects\SimpleFileExplorer\";
            Files SFE = new Files(firstDirectory);
            SFE.UserChoice();
        }
    }
}