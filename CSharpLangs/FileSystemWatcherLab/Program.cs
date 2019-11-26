using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherLab
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"E:\amar-api");
            watcher.Created += WatcherHandler;
            watcher.Deleted += WatcherHandler;
            watcher.Renamed += WatcherHandler;

            //enable rasing to events
            watcher.EnableRaisingEvents = true;
            Console.ReadLine();
        }

        private static void WatcherHandler(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Directory changed, change Type: {e.ChangeType}, Path:{e.FullPath}");
        }
    }
}


