using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections;
using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core;
public class BackPack<T> : IEnumerable<T>

{

    T[] items;

    public int Count { get; private set; }

    public BackPack()
    {
        items = new T[10];
    }

    public void Add(T item)
    {

        if (Count == items.Length)
            Array.Resize(ref items, Count * 2);
        //items[Count] = item;
        //Count++;
        items[Count++] = item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}