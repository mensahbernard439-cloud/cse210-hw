using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> Goods;
        Goods = new List<string>();

        Goods.Add("Kenkey");
        Goods.Add("shito");
        Goods.Add("Awuku");
        Goods.Add("Fish");
        Goods.Add("Mormon");

        foreach (string item in Goods)
        {
            Console.WriteLine(item);

        }

        Console.Write($"i have {Goods.Count}");

        for (int i = 0; i < Goods.Count; i++)
        {
            Console.WriteLine($"Item at index {i}: {Goods[i]}");
        }

        for (int i = 0; i < Goods.Count; i++)
{
    Console.WriteLine(Goods[i]);
}
    }
}
