using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkin_Git_Test
{
    class Program
    {

        static void Main(string[] args)
        {
            string LogFilePathName;
            LogFilePathName = "C:\\LogDir\\PushBuild.txt";
            FileStream LogFileStream = File.Open(LogFilePathName, FileMode.Append, FileAccess.Write);
            StreamWriter LogFileWriter = new StreamWriter(LogFileStream);
            

            for (int i = 0; i < 7; i++)
            {
                LogFileWriter.WriteLine("Main: Jenkins - MSBuild - :" + i + Environment.NewLine);
            }

            Console.WriteLine("...........................");
            LogFileWriter.Flush();
            LogFileWriter.Close();
        }
    }
}
