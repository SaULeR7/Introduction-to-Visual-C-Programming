using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            
            ArrayList arlist = new ArrayList(size);
            for (int i = 0; i < size; i++)
            {
                arlist.Add(i);
            }

            List<int> list = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }

            display_array(arr);
            WriteLine("Element 4 have index:{0}", arr.ElementAt(4));
            WriteLine("Max element:{0}", arr.Max());
            arlist.Reverse();
            display_arrayList(arlist);
            WriteLine("Capacity of ArrayList:{0}", arlist.Capacity);
            WriteLine("Element 6 have index:{0}", arlist.IndexOf(6));
            arlist.Remove(6);
            
            display_list(list);
            WriteLine("Element 4 have index:{0}", list.BinarySearch(4));
            WriteLine("Min element:{0}", list.Min());

            list.RemoveAt(size - 1);

            ReadKey();
        }
        static void display_array(int[] array) {
            WriteLine("\nArray");
            foreach (int item in array)
            {
                WriteLine(item);
            }
        }

        static void display_arrayList(ArrayList array)
        {
            WriteLine("\nArrayList");
            foreach (var item in array)
            {
                WriteLine(item);
            }
        }
        static void display_list(List<int> array)
        {
            WriteLine("\nList");
            foreach (int item in array)
            {
                WriteLine(item);
            }
        }
    }
}
