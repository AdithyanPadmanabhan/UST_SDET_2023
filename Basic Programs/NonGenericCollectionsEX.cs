using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonGenericCollectionsEX
    {
        //nonGeneric
        public void ArraryListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            //for (int i = 0; i < arrayList.Count; i++)
            //     {
            //         Console.WriteLine(arrayList[i]);
            //     }
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            arrayList.Add("AMal");

            arrayList.Add(true); 
            arrayList.Add(false);

            //arrayList.Reverse();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            // arrayList.RemoveAt(2);

            // arrayList.Clear();
            arrayList.Contains(10);
            Console.WriteLine(arrayList.Contains(10));
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

        }
        public void StackHandling()
        {
            Stack st = new Stack();
            st.Push(10);

            st.Push(20);    
            st.Push(30);
            st.Push("Adhi");
            st.Push(true);
            st.Push(37.34);
            st.Push(57);
            st.Push(99);

            foreach (var item in st)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Pop "+st.Pop());

            foreach (var item in st)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("Peek "+st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);

            }
            


        }


        public void QueueHandling()
        {
            Queue q = new Queue();
           q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(true);
            q.Enqueue(false);

            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Pop " + q.Dequeue());

            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Peek " + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
           

        }
        public void HashTableHandlingExample()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);  
                ht.Add(3, 30);
            ht.Add("3", "Adhi");
            ht.Add(4, "amal");
            foreach (var item in ht)
            {
                Console.WriteLine(item);

            }
           ht.Remove(3);
            Console.WriteLine("removed");
            foreach (var item in ht)
            {
                Console.WriteLine(item);

            }
         Console.WriteLine(   ht.ContainsKey("6"));
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);

            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Count:" + ht.Count);

            

        }

        public void SortedListHandling()
        {
            SortedList sl = new SortedList();
            sl.Add(3, 10);
            sl.Add(1, 20);
            sl.Add(2, 30);
            sl.Add(4, "aa");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }


        }
    }
}
