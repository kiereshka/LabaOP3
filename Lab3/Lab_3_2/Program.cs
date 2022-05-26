
Dictionary<string, int> SumDictValues(List<Dictionary<string, string>> list) {
    
    var ret = new Dictionary<string, int>();

    foreach (var dictionary in list)
    {
        if(!ret.ContainsKey(dictionary["item"]))
            ret[dictionary["item"]] = int.Parse(dictionary["amount"]);
        else
            ret[dictionary["item"]] += int.Parse(dictionary["amount"]); 
    }
    return ret;
}

var dictionarys = new List<Dictionary<string, string>>

{
    new() {{"item", "item1"},{"amount", "400"}},
    new() {{"item", "item2"},{"amount", "300"}},
    new() {{"item", "item1"},{"amount", "750"}},
};

var dictionarySum = SumDictValues(dictionarys);

foreach (var dictionary in dictionarySum)
{
    Console.WriteLine(dictionary);
}