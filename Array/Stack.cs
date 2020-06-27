namespace GS.Util
{
    public class Stack
{
    LinkedList newList = new LinkedList();

    public void Push(int data)
    {
        newList.addFirst(data);
    }

    public void Pop()
    {
        newList.deleteFirst();
    }

    public int Peek()
    {
        return newList.toArray()[0];
    }

    public bool isEmpty()
    {
        return newList.Count == 0;
    }

    public void Print()
    {
        newList.print();
    }
}
}
