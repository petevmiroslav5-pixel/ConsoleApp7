using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random random = new Random();

    public string RandomString()
    {
        if (Count == 0)
            return null;

        int index = random.Next(Count);
        string element = this[index].ToString();

        RemoveAt(index);

        return element;
    }
}