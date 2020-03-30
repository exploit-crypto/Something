using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command or 'help' to continue");

            while (true)
            {
                string cmd = Console.ReadLine(); //"list disk";
                switch (cmd)
                {
                    case "help":
                        Console.WriteLine("help\nlist disk");
                        break;
                    case "list disk":
                    case "lis dis":
                    case "li di":
                        foreach (var drive in DriveInfo.GetDrives())
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Drive:{0}\t Rem Space :{1} GB\t Space used:{2}\t Type: {3}", drive.Name, drive.AvailableFreeSpace / 1000000000, drive.TotalSize, drive.DriveType);
                        }
                        break;
                    case "cd":
                        Console.WriteLine("Enter disk:");
                        string disk = Console.ReadLine();//folder path
                        if (disk.ToLower() == "")
                        {
                            //Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Select disk");
                            Console.ResetColor();
                            Console.WriteLine("Enter disk:");
                            disk = Console.ReadLine();
                        }
                        if (disk.ToLower().Contains(":\\") == false)
                        {
                            disk = disk + ":\\";
                        }
                        Console.WriteLine(disk);

                        Console.WriteLine("Enter file name:");
                        string fileName = Console.ReadLine();

                        DirectoryInfo directory = new DirectoryInfo(disk);
                        FileInfo[] filesInDir = directory.GetFiles("*" + fileName + "*.*");

                        foreach (FileInfo foundFile in filesInDir)
                        {
                            string fullName = foundFile.FullName;
                            Console.WriteLine(fullName);
                        }
                        break;
                    case "cls":
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You made a syntax error, check the spelling!//\n\tIf U need more info use 'help'!");
                        Console.ResetColor();
                        break;
                }
    
            }
            
            #region
            //DirectoryInfo directory = new DirectoryInfo(disk);
            //var directories = directory.GetDirectories(fileName,SearchOption.AllDirectories);
            //var files = directory.GetFiles(fileName,SearchOption.AllDirectories);

            //foreach (FileInfo foundFile in files)
            //{
            //    string fullName = foundFile.FullName;
            //    Console.WriteLine(fullName);
            //}
            #endregion
        }
    }
}
