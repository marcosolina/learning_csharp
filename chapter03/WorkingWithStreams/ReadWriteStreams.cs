using System;
using System.IO;

namespace WorkingWithStreams
{
    class ReadWriteStreams
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter("test.txt");
            streamWriter.WriteLine("Hello Marco");
            streamWriter.Close();
        }
    }
}
