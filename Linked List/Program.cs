 

LinkedList<string> listy = new LinkedList<string> ();
//AddLast
//AddFirst
listy.AddLast("SARA");
listy.AddLast("Rebecca");

Console.WriteLine(listy.Contains("Polly"));
Console.WriteLine(listy.Count);

listy.RemoveFirst();


foreach (string item in listy) { 

    Console.WriteLine(item);


}