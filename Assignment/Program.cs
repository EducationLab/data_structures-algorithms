using DoublyLinkedListDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoublyLinkedList<String> linkedList = null;
                Console.WriteLine(linkedList.ToString());

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
