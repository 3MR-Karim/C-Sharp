using System.Collections;

namespace Demo
{
    internal class Program
    {
        static int SumArrayList(ArrayList list)
        {
            int sum = 0;
            if (list != null)
            {
                for(int i = 0;  i < list.Count; i++)
                {
                    sum += (int)list[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Collection : Built in DS In C#
            // Array


            // Non Generics Collection -> Objects
            // Generics Collection -> T

            // Collection :
            // 1: Lists
            // 2: HashTable


            // Lists:
            // 1: Non Generics  ---> Array list
            // 2: Generic Collections ---> List - LinkedList - Stack - Queue


            #region ArrayList
            //// ArrayList : Non Generic Collections - Lists
            //// Array Based -> Implemented Based on Array

            //// ArrayList Indexed - Dynamic Size
            //// Array Indexed -     Fixed Size


            ////ArrayList list = new ArrayList();
            ////Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");
            ////list.Add(1);
            ////Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");

            ////list.Add(2);
            ////list.Add(3);
            ////list.Add(4);


            ////Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");
            ////list.Add(5);
            ////Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");

            //////list[0] = 12; // Get Update

            //////list[6] = 13;

            //////Console.WriteLine(list[6]);

            ////list.Add(6);
            ////list.Add(7);
            ////list.Add(8);
            ////list.Add(9);

            ////ArrayList list = new ArrayList(new int[] {1,2,3});
            ////ArrayList list = new ArrayList(7);

            //ArrayList list = new ArrayList();

            ////Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");

            //int i = list.Add(1);
            //i = list.Add(2);
            //i = list.Add(3);
            //i = list.Add(4);
            ////Console.WriteLine(i);

            //list.AddRange(new int[] {1,2,3,4,5});

            //list.BinarySearch(1);

            ////list.Clear();

            //list.Clone(); // Deep Copy

            //list.Contains(1);
            //list.IndexOf(1);
            ////list.IndexOf();

            ////list.Insert(0, 2); make shifting add from front

            //list.InsertRange();
            //list.LastIndexOf(1);
            //list.Remove(1);
            //list.TrimToSize();
            //int[] Numbers = new int[200];

            ////list.CopyTo(Numbers);
            //list.CopyTo(Numbers,6);


            //Console.WriteLine($"Length: {list.Count} , Capacity: {list.Capacity}");


            //Console.WriteLine("=============Element In Array List==================");
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem Of ArrayList
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add("Hello World");

            //int sum = SumArrayList(list);
            //Console.WriteLine(sum);
            #endregion

            #region Generics - List 
            //List<int> Num = new List<int>();
            //Console.WriteLine($"Count of list: {Num.Count}, capacity of list: {Num.Capacity}");

            //Num.AddRange(new int[] { 4, 5, 6 ,6});
            //Console.WriteLine($"Count of list: {Num.Count}, capacity of list: {Num.Capacity}");

            //Num.Add(77);

            //Console.WriteLine($"after adding 5th element");
            //Console.WriteLine($"Count of list: {Num.Count}, capacity of list: {Num.Capacity}");

            //Num.TrimExcess();
            //Console.WriteLine($"after trim ");
            //Console.WriteLine($"Count of list: {Num.Count}, capacity of list: {Num.Capacity}");

            //List<int> num00 = new List<int>(5) { 4,5,6 ,7,5};
            //Console.WriteLine($"Count of list: {num00.Count}, capacity of list: {num00.Capacity}");
            //num00.Add(0);
            //Console.WriteLine($"Count of list: {num00.Count}, capacity of list: {num00.Capacity}");
            //for(int i=0; i < num00.Count; i++)
            //{
            //    Console.WriteLine(num00[i]);
            //}


            //int Reult=  Sum.SumList(num00);
            //Console.WriteLine(Reult);

            //List<int> num00 = new List<int>() { 1, 2, 4, 5, 6, 7, 8};
            //Console.WriteLine($"the count of num00: {num00.Count}, the capapicty: {num00.Capacity}");
            //num00.AddRange(new int[] { 2, 4, 5 });
            //Console.WriteLine($"the count of num00: {num00.Count}, the capapicty: {num00.Capacity}");

            //foreach(int item in num00)
            //{

            //Console.Write(item); }

            //num00.InsertRange(5, new int[] { 4, 6, 7, });
            //Console.WriteLine($"the count of num00: {num00.Count}, the capapicty: {num00.Capacity}");
            //foreach (int item in num00)
            //{
            //    Console.Write(item);
            //}
            //int var= num00.BinarySearch(1);
            // Console.WriteLine(var);
            //num00.Clear();
            //Console.WriteLine($"the count of num00: {num00.Count}, the capapicty: {num00.Capacity}");
            //Console.WriteLine(num00.Contains(44));

            //List<int> numbers00 = new List<int>() { 1, 2, 3, 4, 5 };
            //int[] arr = new int[10];
            //numbers00.CopyTo(arr);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //numbers00.CopyTo(2, arr, 4,3);
            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            // List<int> numbers000 = new List<int>() { 1, 2, 3, 4, 5,3,4 };
            // Console.WriteLine($"the count of num00: {numbers00.Count}, the capapicty: {numbers00.Capacity}");
            //int indexof= numbers00.IndexOf(4);
            // Console.WriteLine(indexof);
            // Console.WriteLine(numbers00.LastIndexOf(3));

            #endregion

            #region Linked List

            //LinkedList<int> linkedlist00 = new LinkedList<int>();
            //linkedlist00.AddFirst(3);
            //linkedlist00.AddFirst(4);

            //foreach(int item in linkedlist00)
            //{
            //    Console.WriteLine(item);
            //}
            //linkedlist00.AddLast(33);
            //linkedlist00.AddLast(99);
            //foreach(int item in linkedlist00)
            //{
            //    Console.WriteLine(item);
            //}

            //LinkedListNode<int> addbefore = linkedlist00.Find(33);
            //linkedlist00.AddBefore(addbefore, 11);
            //foreach(int item in linkedlist00)
            //    { Console.WriteLine(item); }

            #endregion

            #region Stack
            //Stack <int> stack = new Stack<int>();
            //     stack.Push(44);
            //     stack.Push(11);
            //     stack.Push(12);

            //foreach(int item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());

            //foreach(int item in stack)
            //{
            //Console.WriteLine(item);
            //}
            #endregion

            #region Queue
            // Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            ////foreach(int item in queue) { Console.WriteLine(item); }
            //Console.WriteLine("__________");
            //Console.WriteLine(queue.Peek());
            ////foreach (int item in queue) { Console.WriteLine(item); }

            #endregion





        }
    }
}
