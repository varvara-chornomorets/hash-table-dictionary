using hash_table_dictionary;
using KeyValuePair = hash_table_dictionary.KeyValuePair;


var myDictionary = new StringsDictionary();
myDictionary.Add("varia", "sasha");
myDictionary.Add("sasha", "varia");
myDictionary.Add("liza", "taras");
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