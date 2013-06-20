namespace CohesionAndCoupling
{
    using System;
    using System.Linq;

    public class FilenameUtils
    {
        public static string GetFileExtension(string file)
        {
            int indexOfLastDot = file.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string fileExtension = file.Substring(indexOfLastDot + 1);
            return fileExtension;
        }

        public static string GetFileNameWithoutExtension(string file)
        {
            int indexOfLastDot = file.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return file;
            }

            string fileName = file.Substring(0, indexOfLastDot);
            return fileName;
        }
    }
}
