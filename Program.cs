using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Slingshot
{
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo screenshots = args.Length == 1
                ? new DirectoryInfo(args[0])
                : GetScreenshotFolder();

            if (!screenshots.Exists)
            {
                Console.Error.WriteLine("Tibia screenshots folder not found. Is this the correct path? {0}", screenshots.FullName);
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(-1);
            }

            Console.WriteLine("Found Tibia folder in: {0}", screenshots.FullName);

            var files = FindFiles(screenshots);

            Console.WriteLine("Moving {0} files...", files.Count);

            foreach (var (Source, Target) in files)
            {
                // If the destination directory doesn't exist, create it.
                Directory.CreateDirectory(Target.DirectoryName);
                Console.Write(".");
                Source.MoveTo(Target.FullName);
            }

            Console.WriteLine();
            Console.WriteLine("Done. Press any key to open the folder and exit...");
            Console.ReadLine();

            Process.Start("explorer.exe", screenshots.FullName);
        }

        private static IList<(FileInfo Source, FileInfo Target)> FindFiles(DirectoryInfo screenshots)
        {
            // File names have the following pattern: DATE_TIME_CHAR_TYPE.png
            // Let's break that up and organize
            return screenshots.EnumerateFiles()
                .Select(file => new
                {
                    FileInfo = file,
                    Parts = Path.GetFileNameWithoutExtension(file.Name).Split('_')
                })
                .Where(item => item.Parts.Length == 4)
                .Select(item => new
                {
                    Source = item.FileInfo,
                    Target = new FileInfo(Path.Combine(screenshots.FullName, item.Parts[2], item.Parts[3], item.FileInfo.Name))
                })
                .Where(item => item.Target.Exists == false)
                .Select(item => (item.Source, item.Target))
                .ToList();
        }

        private static DirectoryInfo GetScreenshotFolder()
        {
            var tibiaRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Tibia");
            var screenshots = new DirectoryInfo(Path.Combine(tibiaRoot, @"packages\Tibia\screenshots"));
            return screenshots;
        }
    }
}
