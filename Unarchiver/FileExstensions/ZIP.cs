using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unarchiver.FileExstensions
{
    internal class ZIP
    {
        public static void Unzip(string zipPath, string extractPath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                }
            }
        }
    }
}
