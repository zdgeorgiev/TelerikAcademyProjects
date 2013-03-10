using System;

class Program
{
    static void Main()
    {
        GenericList<int> genList = new GenericList<int>(10);
        genList.Add(4);
        genList.Add(6);
        genList.Add(4);
        genList.Add(6);
        genList.Add(4);
        genList.Add(6);
        genList.Add(4);
        genList.Add(6);
        genList.Add(4);
        genList.Add(6);
        genList[0] = 6;
        Console.WriteLine(genList[0]);
        Console.WriteLine(genList[1]);
        Console.WriteLine(genList);
        genList.RemoveByIndex(3);
        Console.WriteLine(genList);
        genList.InsertAtIndex(18, 6);
        Console.WriteLine(genList);

        GenericList<string> genList1 = new GenericList<string>();
        genList1.Add("Gosho");
        genList1.Add("stefan");
        genList1.Add("Gosho");
        genList1.Add("stefan");
        genList1.Add("Gosho");
        genList1.Add("stefan");
        genList1.Add("Gosho");
        genList1.Add("stefan");
        genList1.Add("Gosho");
        genList1.Add("stefan");
        genList1.RemoveByIndex(2);
        genList1.RemoveByIndex(6);
        Console.WriteLine(genList1);
        genList1.InsertAtIndex(11, "Petar");
        Console.WriteLine(genList1);
    }
}
