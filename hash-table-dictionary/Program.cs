using hash_table_dictionary;
using KeyValuePair = hash_table_dictionary.KeyValuePair;

var myDictionary = new StringsDictionary();
int counter = 0;
string[] lines = File.ReadAllLines("C:/Users/chorn/Desktop/it/hash-table-dictionary/hash-table-dictionary/dictionary.txt");
foreach (var line in lines)
{
    counter++;
    var wordDefArray = line.Split(";");
    string word = wordDefArray[0];
    string defenition = string.Join("", wordDefArray, 1, wordDefArray.Length - 1);
    myDictionary.Add(word, defenition);
    if (counter > 150)
    {
        break;
    }
}
myDictionary.PrintDictionary();
Console.WriteLine(myDictionary.Get("ABASE"));


/* var myDictionary = new StringsDictionary();
myDictionary.Add("varia", "sasha");
myDictionary.Add("sasha", "varia");
myDictionary.Add("liza", "taras");
var smth = myDictionary.Get("liza");
Console.WriteLine(smth);

myDictionary.Remove("liza");
var afhs = myDictionary.Get("liza");
myDictionary.PrintDictionary();

/* LinkedList myList = new LinkedList();
myList.AddBack(new KeyValuePair("liza", "taras"));
myList.AddBack(new KeyValuePair("varia", "sasha"));
myList.AddBack(new KeyValuePair("love", "support"));
myList.AddBack(new KeyValuePair("caring", "affection"));


var pair = myList.GetItemWithKey("varia");
Console.WriteLine($"{pair.Key} and {pair.Value}");
var pair2 = myList.GetItemWithKey("love");
Console.WriteLine($"{pair2.Key} and {pair2.Value}");
myList.RemoveByKey("varia");
var pair3 = myList.GetItemWithKey("varia");
Console.WriteLine($"{pair3.Key} and {pair3.Value}");



myList.PrintLinkedList();
Console.WriteLine("/");
myList.RemoveByKey("caring");
myList.PrintLinkedList();
Console.WriteLine("/");
myList.RemoveByKey("e");
myList.PrintLinkedList();
Console.WriteLine("/");
myList.RemoveByKey("liza");
myList.PrintLinkedList();
Console.WriteLine("/");
myList.RemoveByKey("varia");
myList.PrintLinkedList();
Console.WriteLine("/");
*/