using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscUtils;
using DiscUtils.Iso9660;

namespace Unarchiver.FileExstensions
{
    internal class ISO
    {
        public static void Extract(string ISOName, string ExtractionPath)
        {
            using (FileStream ISOStream = File.Open(ISOName, FileMode.Open))
            {
                CDReader Reader = new CDReader(ISOStream, true, true);
                ExtractDirectory(Reader.Root, ExtractionPath + Path.GetFileNameWithoutExtension(ISOName) + "\\", "");
                Reader.Dispose();
            }
        }

        public static void ExtractDirectory(DiscDirectoryInfo Dinfo, string RootPath, string PathinISO)
        {
            if (!string.IsNullOrWhiteSpace(PathinISO))
            {
                PathinISO += "\\" + Dinfo.Name;
            }
            RootPath += "\\" + Dinfo.Name;
            AppendDirectory(RootPath);
            foreach (DiscDirectoryInfo dinfo in Dinfo.GetDirectories())
            {
                ExtractDirectory(dinfo, RootPath, PathinISO);
            }
            foreach (DiscFileInfo finfo in Dinfo.GetFiles())
            {
                using (Stream FileStr = finfo.OpenRead())
                {
                    using (FileStream Fs = File.Create(RootPath + "\\" + finfo.Name)) // Here you can Set the BufferSize Also e.g. File.Create(RootPath + "\\" + finfo.Name, 4 * 1024)
                    {
                        FileStr.CopyTo(Fs, 4 * 1024); // Buffer Size is 4 * 1024 but you can modify it in your code as per your need
                    }
                }
            }
        }
        public static void AppendDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (DirectoryNotFoundException)
            {
                AppendDirectory(Path.GetDirectoryName(path));
            }
            catch (PathTooLongException)
            {
                AppendDirectory(Path.GetDirectoryName(path));
            }
        }
    }
}
