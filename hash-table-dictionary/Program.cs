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
    string definition = string.Join("", wordDefArray, 1, wordDefArray.Length - 1);
    myDictionary.Add(word, definition);
}
Console.WriteLine("hello! this is dictionary! amazing, isn't it? you can type in some word, and I will give you a definition");
while (true)
{
    string input = Console.ReadLine();
    string requestedWord = input.ToUpper();
    try
    {
        string definition = myDictionary.Get(requestedWord);
        Console.WriteLine($"{requestedWord}   {definition}");
    }
    catch
    {
        Console.WriteLine("there's no such word in a dictionary");
    }
}


