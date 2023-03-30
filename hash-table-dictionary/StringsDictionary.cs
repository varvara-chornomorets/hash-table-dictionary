namespace hash_table_dictionary;

public class StringsDictionary
{
    private const int InitialSize = 10;

    private LinkedList[] _buckets;

    public StringsDictionary()
    {
        _buckets = new LinkedList[InitialSize];
        for (int i = 0; i < InitialSize; i++)
        {
            _buckets[i] = new LinkedList();
        }
    }

    public void Add(string key, string value)
    {
        // int curHash = CalculateHash(key);
        int curHash = 2;
        int index = curHash % InitialSize;
        LinkedList bucket = _buckets[index];
        bucket.AddBack(new KeyValuePair(key, value));
    }

    public void PrintDictionary()
    {
        foreach (var variabBucket in _buckets)
        {
            variabBucket.PrintLinkedList();
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