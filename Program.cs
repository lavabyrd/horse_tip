using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HorseBetTracking
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please hold, working!");
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "commit_changes.txt");
            var fileContents = ReadFile(fileName);
        }
    }
}
