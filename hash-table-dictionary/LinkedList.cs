namespace hash_table_dictionary;

public class LinkedList
{
    private LinkedListNode? Head;

    private LinkedListNode? Tail;
    private int Size;

    public LinkedList()
    {
        Tail = null;
        Head = null;
        Size = 0;
    }
    public void AddBack(KeyValuePair pair)
    {
        // add provided pair to the end of the linked list
        if (this.Size == 0)
        {
            LinkedListNode cur = new LinkedListNode(pair);
            Tail = cur;
            Head = cur;
            Size++;
            return;
        }

        LinkedListNode notLastAnymore = Tail;
        LinkedListNode last = new LinkedListNode(pair);
        Tail = last;
        notLastAnymore.Next = last;
        Size++;
    }

    public void PrintLinkedList()
    {
        LinkedListNode? cur = Head;
        for (int i = 0; i < Size; i++)
        {
            Console.WriteLine($"{cur.Pair.Key} and {cur.Pair.Value}");
            cur = cur.Next;
        }
    }

    /* public void RemoveByKey(string key)
    {
        // remove pair with provided key
    }

    public KeyValuePair GetItemWithKey(string key)
    {
        // get pair with provided key, return null if not found
        return;
    }*/
}