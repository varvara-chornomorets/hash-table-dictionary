namespace hash_table_dictionary;

public class StringsDictionary
{
    private const int InitialSize = 10;

    private LinkedList[] _buckets = new LinkedList[InitialSize];

    /*public StringsDictionary()
    {
        _buckets = new LinkedList[InitialSize];
        for (int i = 0; i < InitialSize; i++)
        {
            _buckets[i] = new LinkedList();
        }
    }*/

    public void Add(string key, string value)
    {
        // int curHash = CalculateHash(key);
        int curHash = 2;
        int index = curHash % InitialSize;
        if (_buckets[index] == null)
        {
            _buckets[index] = new LinkedList();
        }
        _buckets[index].AddBack(new KeyValuePair(key, value));
    }

    public void PrintDictionary()
    {
        for (int i = 0; i < InitialSize; i++)
        {
            Console.WriteLine($"bucket number{i}");
            var variabBucket = _buckets[i];
            if (variabBucket != null)
            {
                variabBucket.PrintLinkedList();
            }
            else
            {
                Console.WriteLine("null");
            }
            
        }
    }
    /* public void Remove(string key)
    {
            
    }

    public string Get(string key)
    {
            
    }


    private int CalculateHash(string key)
    {
        // function to convert string value to number 
    } */
}