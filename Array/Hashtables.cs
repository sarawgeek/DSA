using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Hashtables
    {
        // Use Chaining for collision
        class Entry
        {
            int key;
            string value;
            public int Key 
            { 
                get 
                { 
                    return key; 
                } 
                set 
                { 
                    key = value; 
                } 
            }
            public string Value
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                }
            }
            public Entry(int Key, string Value)
            {
                key = Key;
                value = Value;
            }
        }

        static int hashTableLength = 5;
        LinkedList<Entry>[] linkedListArray = new LinkedList<Entry>[hashTableLength];
        public int GeHashTableKey(int key)
        {
            return key % hashTableLength;
        }
        public void Put(int key, string value)
        {
            int hashTableKey = GeHashTableKey(key);
            var entry = new Entry(key, value);
            bool keyExisted = false;
            if (linkedListArray[hashTableKey] == null)
                linkedListArray[hashTableKey] = new LinkedList<Entry>();
            foreach (var item in linkedListArray[hashTableKey])
            {
                if (item.Key == key)
                {
                    item.Value = value;
                    keyExisted = true;
                    break;
                }
            }
            if (keyExisted == false)
            {
                linkedListArray[hashTableKey].AddLast(entry);
            }
            

        }

        public string Get(int key)
        {
            int hashtableKey = GeHashTableKey(key);
            if (linkedListArray[hashtableKey] != null)
            {
                foreach (var item in linkedListArray[hashtableKey])
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
            }
            return string.Empty;
        }

        public void Remove(int key)
        {
            int hashtableKey = GeHashTableKey(key);
            Entry entry = null;
            if (linkedListArray[hashtableKey] != null)
            {
                //linkedListArray[hashtableKey].
                foreach (var item in linkedListArray[hashtableKey])
                {
                    if (item.Key == key)
                    {
                        linkedListArray[hashtableKey].Remove(item);
                        return;
                    }
                }

            }
            else throw new InvalidOperationException();
        }
    }
}
