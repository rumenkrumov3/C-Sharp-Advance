using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileAndStreams.cs
{
    class CopyBinaryFile
    {
        static void Copy()
        {
            string directoryPath = (@"D:\GIT\AdvanceModule\AdvanceModule\Files");
            long totalLenght = 0;

            totalLenght = GetTotalLenght(directoryPath);
            Console.WriteLine(totalLenght);
        }
         static long GetTotalLenght(string directoryPath)
        {
            long totalLenght = 0;

            string[] files = Directory.GetFiles(directoryPath);

            foreach (var file in files)
            {
                totalLenght += (new FileInfo(file).Length);
            }

            string[] subFolders = Directory.GetDirectories(directoryPath);

            foreach (var directorie in subFolders)
            {
                totalLenght += GetTotalLenght(directorie);
            }


            return totalLenght;
        }
       
    }

}
