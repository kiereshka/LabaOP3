
List<int> ReplaceRepeatableNumbers(List<int> list) {
    return list.Select(item => {
        if (list.Count(i => i == item) > 1)
            return 0;
        
        return item;
    }).ToList();
}
var list1 = new List<int> {1, 2, 3, 1, 4, 5, 2, 2, 1};
Console.WriteLine(string.Join(", ", ReplaceRepeatableNumbers(list1)));