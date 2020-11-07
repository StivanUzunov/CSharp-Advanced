using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {


                    string line = reader.ReadLine();
                    int lineCounter = 0;
                    while (line != null)
                    {
                        if (lineCounter % 2 == 0)
                        {
                            Regex pattern = new Regex("[-,.!?]");
                            line = pattern.Replace(line, "@");
                            var arr = line.Split().ToArray().Reverse();
                            writer.WriteLine(String.Join(" ", arr));

                        }
                        lineCounter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
