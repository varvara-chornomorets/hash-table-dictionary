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
}
myDictionary.PrintDictionary();
Console.WriteLine(myDictionary.Get("ABASE"));


