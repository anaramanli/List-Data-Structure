using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            list.Add(10);
            list.Add(90);
            list.Add(10);
            list.Add(30);
            list.Add(30);
            list.Add(20);
            list.GetElements();
            list.FirstIndexOf(90);
            list.LastIndexOf(30);
            Console.WriteLine("------");
            list.Remove(3);
            list.GetElements();
            Console.WriteLine("------");
            Console.WriteLine(list.ToString());
        }
    }

    class IntArrayList
    {
        private int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; }
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Out of range");
                return;
            }
            _arr[index] = 0;

            /*for (int i = index; i < Count; i++)
            {
                /*if (_arr[i] == index)
                {
                    _arr[i] = 0;
                    return; //buda istediyimiz reqemin yerine 0 yazmaq ucundu elsesi {cw "not found'}  
                }#1#
            }*/
            Console.WriteLine("removed");
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void FirstIndexOf(int index)
        {
            for (int i = 0; i < Count; i++)
            {
                if (index == _arr[i])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void LastIndexOf(int index)
        {
            for (int i = Count - 1; i > -1; i--)
            {
                if (index == _arr[i])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
            {
                result += _arr[i].ToString();
                if (i < Count - 1)
                {
                    result += " , ";
                }
            }
            return result;
        }

    }
}
