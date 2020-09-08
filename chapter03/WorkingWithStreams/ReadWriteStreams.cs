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

            StreamReader streamReader = new StreamReader("test.txt");
            string line = streamReader.ReadLine();
            while(streamReader.EndOfStream == false)
            {
                Console.WriteLine(line);
                streamReader.Close();
            }
        }
    }
}
