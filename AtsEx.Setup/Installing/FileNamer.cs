﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtsEx.Setup.Installing
{
    internal static class FileNamer
    {
        public static string CreateFilePathInSequence(string pathBase)
        {
            string extension = Path.GetExtension(pathBase);
            string pathBaseWithoutExtension = Path.Combine(Path.GetDirectoryName(pathBase), Path.GetFileNameWithoutExtension(pathBase));

            string pathWithoutExtension = pathBaseWithoutExtension;
            int i = 0;
            while (File.Exists(pathWithoutExtension + extension))
            {
                i++;
                pathWithoutExtension = $"{pathBaseWithoutExtension} ({i})";
            }

            return pathWithoutExtension + extension;
        }
    }
}
