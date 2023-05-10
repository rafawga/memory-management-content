lista lista = new lista();
lista.add(12);
lista.add(5);
lista.add(9);
lista.print();

LinkedList linkedList = new LinkedList();
linkedList.Add(2);
linkedList.Add(5);
linkedList.PrintinkedList();

public class lista
{
    private int[] vetor = new int[2];
    public int index;
    public int count;


    public void add(int number)
    {
        count = 0;
        index = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            index = i;
            if (vetor[i] == 0)
            {
                break;
            }
            else
            {
                count++;
            }
        }

        if (vetor.Length > count)
        {
            vetor[index] = number;
        }

        else
        {
            int[] novoVetor = new int[vetor.Length * 2];
            for (int i = 0; i < vetor.Length; i++)
            {
                novoVetor[i] = vetor[i];
            }
            vetor = novoVetor;
            vetor[count] = number;
            count++;
        }



    }

    public void print()
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            System.Console.WriteLine(vetor[i]);
        }
    }


}

public class Node
{
    public int value { get; set; }
    public Node Next { get; set; }
}


public class LinkedList
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

    public void PrintinkedList()
    {
        Node current = first;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.Next;
        }
    }

}