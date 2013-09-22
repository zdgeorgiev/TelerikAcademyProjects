using System;
using System.Text;

public class GenericClass<T> 
    where T : IComparable
{
    private const int DefaultCapacity = 10;
    private T[] allElements;
    //Field which remembers wheres the index of the last element
    private int currentPosition;

    public GenericClass(int capacity = DefaultCapacity)
    {
        this.allElements = new T[capacity];
        currentPosition = 0;
    }

    public T this[int index]
    {
        get { return this.allElements[index]; }
        set { this.allElements[index] = value; }
    }

    public void Add(T element)
    {
        if (currentPosition >= this.allElements.Length)
        {
            this.allElements = AutoGrow();
        }

        this.allElements[currentPosition] = element;

        currentPosition++;
    }

    public void RemoveAt(int index)
    {
        if (this.currentPosition <= index)
        {
            throw new IndexOutOfRangeException("Index is outside of the bounds of the array.");
        }

        T[] tempArray = new T[this.currentPosition - 2];

        //If the index is at the last element from the array
        if (index == this.currentPosition - 1)
        {
            for (int i = 0; i < this.currentPosition; i++)
            {
                tempArray[i] = allElements[i];
            }
        }
        else
        {
            int nextIndex = 0;

            for (int i = 0; i < this.currentPosition - 1; i++)
            {
                if (i == index)
                {
                    continue;
                }

                tempArray[nextIndex] = this.allElements[i];
                nextIndex++;
            }
        }

        currentPosition = tempArray.Length;
        this.allElements = tempArray;
    }

    public void InsertAt(int index, T element)
    {
        if (index > this.currentPosition)
        {
            throw new IndexOutOfRangeException("Index out of range of the bounds of the array");
        }

        if (currentPosition + 1 >= this.allElements.Length)
        {
            this.allElements = AutoGrow();
        }

        T[] tempArray = new T[this.currentPosition + 1];

        if (index > 0)
        {
            for (int i = 0; i < index; i++)
            {
                tempArray[i] = this.allElements[i];
            }
        }

        for (int i = index + 1; i < tempArray.Length; i++)
        {
            tempArray[i] = this.allElements[i - 1];
        }

        tempArray[index] = element;
        this.allElements = tempArray;

        this.currentPosition++;
    }

    public void Clear()
    {
        this.allElements = new T[0];
    }

    public int IndexOf(T element)
    {
        int index = -1;

        for (int i = 0; i < this.allElements.Length; i++)
        {
            if (this.allElements[i].Equals(element))
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public T Min()
    {
        dynamic lowestValue = this.allElements[0];

        for (int i = 1; i < this.allElements.Length; i++)
        {
            if (lowestValue.CompareTo(this.allElements[i]) == 1)
            {
                lowestValue = this.allElements[i];
            }
        }

        return lowestValue;
    }

    public T Max()
    {
        dynamic biggestValue = this.allElements[0];

        for (int i = 1; i < this.allElements.Length; i++)
        {
            if (biggestValue.CompareTo(this.allElements[i]) == -1)
            {
                biggestValue = this.allElements[i];
            }
        }

        return biggestValue;
    }

    private T[] AutoGrow()
    {
        T[] tempArray = new T[this.allElements.Length * 2];

        for (int i = 0; i < this.currentPosition; i++)
        {
            tempArray[i] = this.allElements[i];
        }

        return tempArray;
    }

    public int Lenght
    {
        get { return this.currentPosition; }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        if (this.allElements.Length == 0)
        {
            return "Array is empty!";
        }

        for (int i = 0; i < this.currentPosition; i++)
        {
            output.Append(this.allElements[i] + " ,");
        }

        output.Length -= 2;

        return output.ToString();
    }
}