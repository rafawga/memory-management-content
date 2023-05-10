List lista = new List();
lista.Add(2);
lista.Add(5);
lista.PrintList();
public class Node
{
    public int value { get; set; }
    public Node Next { get; set; }
}
public class List
{
    private Node first = null;
    public void Add(int value)
    {
        if (first == null)
        {
            first = new Node();
            first.value = value;
            first.Next = null;
            return;
        }

        Node current = first;
        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node();
        newNode.value = value;
        newNode.Next = null;
        current.Next = newNode;
    }

    public void PrintList()
    {
        Node current = first;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.Next;
        }
    }

}