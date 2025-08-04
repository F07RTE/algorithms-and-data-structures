LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);

var value = linkedList.Find(2);

Console.WriteLine(value?.Value);

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}