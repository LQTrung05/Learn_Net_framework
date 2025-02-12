
var list = new GenericClass<string>();
for(long i = 0; i < 10; i++){
  list.AddHead(i.ToString());
}
foreach (var item in list)
{
  Console.WriteLine(item);
}

public class GenericClass<Q>{
  private class Node(Q t){
    public Q Data { get; set; } = t;
    public Node? Next { get; set; }
  }

  private Node? head;
  public void AddHead(Q t){
    Node n = new(t); //Cách khai báo mới này
    n.Next = head;
    head = n;
  }

  public IEnumerator<Q> GetEnumerator(){
    Node? curent = head;
    while(curent is not null){
      yield return curent.Data;
      curent = curent.Next;
    }
  }
}

