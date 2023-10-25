using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericCollectionEx
    {
        public void ListHandling()
        {
           List<int> numbers = new List<int>();  
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(20);
            numbers.Add(30);
            //for (int i = 0; i < arrayList.Count; i++)            arrayList.Add(10);

            //     {
            //         Console.WriteLine(arrayList[i]);
            //     }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            //numbers.Add("AMal");

            //numbers.Add(true);
            //numbers.Add(false);
            Console.WriteLine("reverse");

            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("removed");

            numbers.RemoveAt(2);

            // arrayList.Clear();
            //arrayList.Contains(10);
            //Console.WriteLine(arrayList.Contains(10));
            foreach (int item in numbers)
            {
                Console.WriteLine
                    (item);
            }

            Console.WriteLine("Sorted");
            numbers.Sort();

            foreach (int item in numbers)
            {
                Console.WriteLine
                    (item);
            }


            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");

            list.Sort();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void StackHandling()

        {
            Stack<int> st = new Stack<int>();
            //Stack st = new Stack();
            st.Push(10);

            st.Push(20);
            st.Push(30);
            //st.Push("Adhi");
            //st.Push(true);
            //st.Push(37.34);
            st.Push(57);
            st.Push(99);

            foreach (int item in st)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Pop " + st.Pop());

            foreach (int item in st)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Peek " + st.Peek());
            foreach (int item in st)
            {
                Console.WriteLine(item);

            }



        }
        public void QueueHandling()
        {
            Queue<int> q = new Queue<int>();
            //Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            //q.Enqueue(true);
            //q.Enqueue(false);

            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Pop " + q.Dequeue());

            foreach (int item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Peek " + q.Peek());
            foreach (int item in q)
            {
                Console.WriteLine(item);

            }


        }
        public void DictionaryHandlingExample()
        {
            Dictionary <int,string>  ht = new Dictionary<int, string>();    
           // Hashtable ht = new Hashtable();
            ht.Add(1, "10");
            ht.Add(2, "20");
            ht.Add(3, "30");
            ht.Add(5, "Adhi");
            ht.Add(4, "amal");
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);

            }
            ht.Remove(3);
            Console.WriteLine("removed");
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(ht.ContainsKey(6));
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);

            }
            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Count:" + ht.Count);



        }


        public void SortedListHandling()
        {
            SortedDictionary<int,string> sl =new SortedDictionary<int,string>();
            //SortedList sl = new SortedList();
            sl.Add(3, "10");
            sl.Add(1, "20");
            sl.Add(2, "30");
            sl.Add(4, "aa");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }


        }


    }
}
