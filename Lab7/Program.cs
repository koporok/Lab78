using System;

class GenericArray<T>
{
    public T[] array;
    private int length;

    public GenericArray(int size)
    {
        array = new T[size];
        length = 0;
    }

    public void Add(T element)
    {
        array[length] = element;
        length++;
        Console.WriteLine(length);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= length)
        {
            throw new Exception("Индекс находится вне диапазона");
        }

        for (int i = index; i < length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        length--;
        Console.WriteLine($"Удаление {length}");
    }

    public T GetElementAt(int index)
    {
        if (index < 0 || index >= length)
        {
            throw new Exception("Индекс находится вне диапазона");
        }


        Console.WriteLine(array[index]);
        return array[index];
    }

    public int GetLength()
    {
        return length;
    }
}

/*class Program
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);

        GenericArray<string> stringArray = new GenericArray<string>(3);
        stringArray.Add("Hello");
        stringArray.Add("World");

        GenericArray<double> doubleArray = new GenericArray<double>(4);
        doubleArray.Add(1.5);
        doubleArray.Add(2.5);
        doubleArray.Add(3.5);
    }
}*/