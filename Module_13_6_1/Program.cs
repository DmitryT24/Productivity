using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TesterCollections tester = new TesterCollections();

                tester.TestToList();
                Console.WriteLine($"Время заполнения List<>: {tester.timeWorkList} мс.");

                tester.TestToLinkedList();
                Console.WriteLine($"Время заполнения LinkedList<>: {tester.timeWorkLinkedList}");

                Console.WriteLine();
                if (tester.timeWorkList > tester.timeWorkLinkedList)
                {
                    Console.WriteLine("Производительность списока LinkedList выше чем у коллекции List<>!");
                }
                else
                {
                    Console.WriteLine("Производительность коллекции List<> выше чем у списока LinkedList!");
                }
                Console.ReadKey();

            }
            catch (MyException ex)
            {
                Console.WriteLine($"Программа завершилась с ошибкой - {ex.Message}");
                Console.ReadKey();
            }
        }

    }
}
