using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\fileFolder",
                @"D:\zipFolder\zipOfpng.zip");

            ZipFile.ExtractToDirectory(@"D:\zipFolder\zipOfpng.zip", 
                @"D:\extractFolder");
        }
    }
}
