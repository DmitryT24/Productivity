using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13_6_1
{
    internal class TesterCollections
    {
        public double timeWorkList { get; set; }
        public double timeWorkLinkedList { get; set; }
        StopwatchTime stopwatchTime;
        public TesterCollections()
        {
            stopwatchTime = new StopwatchTime();
        }
        static StreamReader OpenFile()
        {
            StreamReader _fileRead = null;
            var directoryFile = Path.Combine(Directory.GetCurrentDirectory(), "Text1.txt");
            if (File.Exists(directoryFile))
            {
                _fileRead = File.OpenText(directoryFile);
            }
            else
            {
                //  Console.WriteLine($"Ошибка открытия файла: {directoryFile}!");
                throw new MyException($"Ошибка открытия файла: {directoryFile}!");
            }

            return _fileRead;
        }
        public void TestToList()
        {
            var list = new List<string>();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
            using (StreamReader fileRead = OpenFile())
            {
                if (fileRead != null)
                {
                    string[] strings = fileRead.ReadToEnd().Split(delimiterChars);

                    stopwatchTime.StartTimer();

                    foreach (string str in strings)
                        list.Add(str);


                    timeWorkList = stopwatchTime.TimeWork();

                }
                fileRead.Close();
            }


        }
        public void TestToLinkedList()
        {
            var list = new LinkedList<string>();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
            using (StreamReader fileRead = OpenFile())
            {
                if (fileRead != null)
                {
                    string[] strings = fileRead.ReadToEnd().Split(delimiterChars);

                    stopwatchTime.StartTimer();

                    foreach (string str in strings)
                        list.AddLast(str);

                    timeWorkLinkedList = stopwatchTime.TimeWork();
                }
                fileRead.Close();
            }
        }
    }
}
