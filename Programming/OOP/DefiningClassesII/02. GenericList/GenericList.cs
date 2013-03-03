using System;
using System.Text;

public class GenericList<T>
    where T : IComparable
{
    private T[] list;
    private int position;

    public GenericList(int capacity = 5)
    {
        this.list = new T[capacity];
    }

    public T this[int index]
    {
        get
        {
            if (index < list.Length && index >= 0)
            {
                return this.list[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
        set
        {
            this.list[index] = value;
        }
    }

    public T Max()
    {
        dynamic bigest = int.MinValue;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] > bigest)
            {
                bigest = list[i];
            }
        }
        return bigest;
    }

    public T Min()
    {
        dynamic smallest = int.MaxValue;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] < smallest)
            {
                smallest = list[i];
            }
        }
        return smallest;
    }

    public void Add(T element) //adding element in the first avaible postion in the List
    {
        if (position >= list.Length)
        {
            T[] newList = new T[list.Length * 2];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            position++; //position incresed because the next element will be at the next position
            newList[list.Length] = element;
            list = newList;
        }
        else
        {
            list[position] = element;
            position++;
        }
    }

    public void RemoveByIndex(int index)
    {
        if (index < list.Length || index >= 0)
        {
            T[] newList = new T[1]; //create default element
            list[index] = newList[0]; //index recieve this element
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
    }

    public void InsertAtIndex(int index, T item)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
        else if (index < list.Length)
        {
            list[index] = item;
        }

        while (index >= list.Length)
        {
            T[] newList = new T[list.Length * 2];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }
            list = newList;
        }
        list[index] = item;
    }

    public void Clear()
    {
        this.list = new T[list.Length];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in list)
        {
            sb.AppendFormat("{0} ",item);
        }

        return sb.ToString().Trim();
    }
}