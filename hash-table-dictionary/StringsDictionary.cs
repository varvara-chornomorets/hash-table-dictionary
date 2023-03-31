namespace hash_table_dictionary;

public class StringsDictionary
{
    private int _size;

    private LinkedList[] _buckets;
    
    public StringsDictionary(int size)
    {
        this._size = size;
        _buckets = new LinkedList[_size];
    }

    public void Add(string key, string value)
    {
        int curHash = CalculateHash(key);
        
        int index = curHash % _size;
        if (_buckets[index] == null)
        {
            _buckets[index] = new LinkedList();
        }
        _buckets[index].AddBack(new KeyValuePair(key, value));
        if (LoadFactor() > 0.7)
        {
            ResizeDictionary();
        }
    }
    
    private void ResizeDictionary()
    {
        Console.WriteLine($"RESIZING! from size {this._size}, load factor {LoadFactor()} unused {_buckets.Count(item => item == null)}");
        this._size = this._size * 2;
        var oldBuckets = _buckets;
        _buckets = new LinkedList[this._size];
        var allElements = new List<KeyValuePair>();
        foreach (var bucket in oldBuckets)
        {
            if (bucket == null)
            {
                continue;
            }

            allElements = bucket.GetAllPairs(allElements);
            if (allElements == null)
            {
                continue;
            }

        }

        foreach (var pair in allElements)
        {
            Add(pair.Key, pair.Value);
        }

    }
    private float LoadFactor()
    {
        float used = _buckets.Count(item => item != null);
        var result = used / this._size;
        return result;
    }

    public void PrintDictionary()
    {
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
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
    public void Remove(string key)
    {
        int curHash = CalculateHash(key);
        
        int index = curHash % _size;
        if (_buckets[index] == null)
        {
            throw new Exception("there is no such element (bucket is null)");
        }
        _buckets[index].RemoveByKey(key);
    }

    public string Get(string key)
    {
        int curHash = CalculateHash(key);
        
        int index = curHash % _size;
        if (_buckets[index] == null)
        {
            throw new Exception("there is no such an element (bucket is null");
        }
        var pair = _buckets[index].GetItemWithKey(key);
        if (pair == null)
        {
            throw new Exception("there is no such an element(not on the list or list is empty");
        }
        return pair.Value;
    }


     private int CalculateHash(string key)
    {
        // function to convert string value to number 
        int result = 0;
        for (int i = 0; i < key.Length; i++)
        {
            byte number = Convert.ToByte(key[i]); 
            result += number * number * (i+1);
        }
        return result;
    } 
}
