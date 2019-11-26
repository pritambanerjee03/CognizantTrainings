using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLab
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo outFile = new FileInfo(@"E:\mongoDB\cts077_sort.js");
            if (outFile.Exists)
            {
                Console.WriteLine("FileName : {0}", outFile.Name);
                Console.WriteLine("Path : {0}", outFile.FullName);
                Console.WriteLine("creationTime : {0}", outFile.CreationTime);
                Console.WriteLine("Last Access Time : {0}", outFile.LastAccessTime);
            }

            DirectoryInfo outDir = new DirectoryInfo(@"E:\amar-api");

            Console.WriteLine("Directory : {0}", outDir.FullName);
            foreach(FileInfo file in outDir.GetFiles())
            {
                Console.WriteLine("File : {0}", file.Name);
            }

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive : {0}", drive.Name);
                Console.WriteLine("Type : {0}", drive.DriveType);
                Console.WriteLine("Available Size : {0}", drive.AvailableFreeSpace);
            }

            FileStream stream = File.Open(@"E:\amar-api\amar-api2.txt", 
                FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader reader = new StreamReader(stream);

            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
            stream.Close();

            MemoryStream memstream = new MemoryStream();
            StreamWriter writer = new StreamWriter(memstream);
            writer.AutoFlush = true;
            writer.WriteLine("Hello");
            writer.WriteLine("Good Bye");
            //writer.

            StreamReader reader1 = new StreamReader(memstream);
            string content1 = reader1.ReadToEnd();
            Console.WriteLine(content1);
            reader1.Close();
            memstream.Close();

            //GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            //int   

        }
    }
}
