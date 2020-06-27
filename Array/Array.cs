using System.Collections.Generic;

namespace GS.Util
{
    public class Array
    {
        //List<T> tempList = new List<T>();
        int arrayLength;
        List<object> newList = null;
        public object this[int index]
        {
            get { return newList[index]; }
            //set { /* set the specified index to value here */ }
        }
        public int Length { get { return newList.Count; } }
        public Array(int length = 0)
        {
            arrayLength = length;
            newList = new List<object>();
        }

        public void insert(object item)
        {
            newList.Add(item);
        }
        public void removeAt(int index)
        {
            newList.RemoveAt(index);
        }

        public int indexOf(object item)
        {
            return newList.IndexOf(item);
        }
    }
}
