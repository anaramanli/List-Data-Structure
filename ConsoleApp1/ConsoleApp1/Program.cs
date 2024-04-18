using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Int32 = System.Int32;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IntArrayList list = new IntArrayList();
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
            Console.WriteLine(list.ToString());*/
            /*StringArrayList strs = new StringArrayList();
            strs.Add("Salam");
            strs.Add("Aleykum");
            strs.GetElements();*/
            /*ObjectArrayList objs = new ObjectArrayList(typeof(Int32));
            objs.Add(12);
            objs.Add(true);
            objs.Add("salam");
            objs.GetElements();*/
            /*GenericList<int> intArr = new GenericList<int>(10, typeof(int));
            intArr.Add(89);*/
            GenericList<Student> intArr = new GenericList<Student>();
            intArr.Add(new Student()
            {
                Name = "Anar",
                Surname = "Amanli"
            });
            intArr.GetElements();
        }
    }
    class GenericList<Anar>
    {
        private Anar[] _arr;
        public int Capacity { get; private set; } = 5;
        public int Count { get; private set; }
        private Type _listType;

        public GenericList()
        {
            _arr = new Anar[Capacity];
        }

        public GenericList(int capacity)
        {
            Capacity = capacity;
            _arr = new Anar[Capacity];
        }

        public void Add(Anar value)
        {
            if (Count == Capacity)
            {
                Array.Resize(ref _arr, Capacity * 2);
                Capacity *= 2;
            }

            _arr[Count++] = value;
            Count++;

        }

        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
    class ObjectArrayList
    {
        private object[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; }
        private Type _listType;

        public ObjectArrayList(Type listType)
        {
            _arr = new object[Capacity];
            _listType = listType;
        }
        public ObjectArrayList(int capacity, Type listType)
        {
            Capacity = capacity;
            _arr = new object[Capacity];
            _listType = listType;
        }
        public void Add(object value)
        {
            if (value.GetType().Name == _listType.Name)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }

                _arr[Count] = value;
                Count++;
            }
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
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

        /*public void FirstIndexOf(int index)
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
        }*/

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
    class StringArrayList
    {
        private string[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; }

        public StringArrayList()
        {
            _arr = new string[Capacity];
        }

        public StringArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new string[Capacity];
        }

        public void Add(string value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }

            _arr[Count] = value;
            Count++;
        }

        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
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

        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
