lista lista = new lista();
lista.add(12);
lista.add(5);
lista.add(9);
lista.print();

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