using System;
using System.Collections.Generic;

namespace Map
{ 
    public class Map<TKey, TValue>
{
    private List<TKey> Keys;  
    private List<TValue> Values;

    public Map()
    {
        Keys = new List<TKey>();
        Values = new List<TValue>();
    }

    public void add(TKey K, TValue V)
    {
        Keys.Add(K);
        Values.Add(V);
        
    }

    public TValue getValue(TKey k)
    {
        for (int i = 0; i < Values.Count; i++)
        {
            if (Keys[i].Equals(k))
            {
                return Values[i]; 
            }
        }

        return default;
    }

    public int getLength()
    {

        return Keys.Count;
    }

}

    class Program
    {
        static void Main(string[] args)
        {
            Map<String, String> MyMap = new Map<string, string>();

            MyMap.add("1", "One");
            MyMap.add("2", "Two");
            MyMap.add("3", "Three");
            MyMap.add("4", "Four");
            MyMap.add("5", "Five");

            Console.WriteLine(MyMap.getValue("1"));
            Console.WriteLine(MyMap.getValue("3"));
            Console.WriteLine(MyMap.getValue("5"));
        }
    }
}
