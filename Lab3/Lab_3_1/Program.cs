void Circle(int n)
{
    var circleList = Enumerable.Range(1, n).ToList();
    Console.Write("\nНачальный список:"  + string.Join(',', circleList));
    
    for (; circleList.Count > 1;) {
        for (var i = 1; i < circleList.Count; i+=1) {
            Console.WriteLine(list[i]);
            circleList.RemoveAt(i);
        }
        Console.Write("\nВесь список:"  + string.Join(',', circleList));
    }
    Console.Write("\nОсталось" + circleList.Count + " людей");
}

Circle(15);