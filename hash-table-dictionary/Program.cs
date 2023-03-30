using hash_table_dictionary;
using KeyValuePair = hash_table_dictionary.KeyValuePair;


var myDictionary = new StringsDictionary(10);
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
Console.WriteLine("hello! this is dictionary! amazing, isn't it? you can type in some word, and I will give you a defenition");
while (true)
{
    string input = Console.ReadLine();
    string requestedWord = input.ToUpper();
    try
    {
        string defenition = myDictionary.Get(requestedWord);
        Console.WriteLine($"{requestedWord}   {defenition}");
    }
    catch
    {
        Console.WriteLine("seems, like you have entered incorrect word");
    }
}
