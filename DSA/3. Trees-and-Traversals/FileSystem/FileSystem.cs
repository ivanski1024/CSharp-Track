using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class FileSystem
    {
        public const string WantedPath = "C:\\WINDOWS";
        static void Main(string[] args)
        {
            Folder windowsFolder = GetFolder(WantedPath); // Gets an instance of the class Folder which represents the exact folder in the file system.

            Console.WriteLine("The size of the folder: {0} is: {1} bytes.", WantedPath, windowsFolder.Size());
        }

        /// <summary>
        /// Returns the folder with the given path.
        /// </summary>
        /// <param name="wantedPath">The path of the folder you want.</param>
        /// <returns>An instance of the class <seealso cref="FileSystem.Folder">Folder</seealso> which represents an existing folder in your file sytem.</returns>
        public static Folder GetFolder(string wantedPath)
        {
            Folder wantedFolder = null;
            FillInFolder(wantedFolder, wantedPath);
            return wantedFolder;
        }

        public static void FillInFolder(Folder folder, string folderPath)
        {
            string[] filesStrings;
            string[] childFoldersStrings;
            try
            {
                filesStrings = Directory.GetFiles(folderPath);
                childFoldersStrings = Directory.GetDirectories(folderPath);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message); // Logs on the console when the access to some folder in the file system is denied.
                return;
            }

            folder = new Folder(folderPath);
            int filesCount = filesStrings.Length;
            File[] files = new File[filesCount];
            for (int fileIndex = 0; fileIndex < filesCount; fileIndex++)
            {
                FileInfo fileInfo = new FileInfo(filesStrings[fileIndex]);
                files[fileIndex] = new File(filesStrings[fileIndex], fileInfo.Length);
            }

            int foldersCount = childFoldersStrings.Length;
            Folder[] childFolders = new Folder[foldersCount];
            for (int folderIndex = 0; folderIndex < foldersCount; folderIndex++)
            {
                Folder childFolder = null;
                FillInFolder(childFolder, childFoldersStrings[folderIndex]);
                childFolders[folderIndex] = childFolder;
            }
            folder.Files = files;
            folder.ChildFolders = childFolders;
        }
    }
}
