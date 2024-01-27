using SueExtensionMethods;
using System.Collections.Generic;

internal class Program
{
    static List<int> integers;
    static List<string> strings;
    static List<double> doubles;
    static List<Patient> patients;
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
       
       // Befüllen der Listen mit folgenden Daten:
        integers = new List<int> { 5, 76, 3, 93, 143, 5, 11, 67, 5 };
        doubles = new List<double> { 1.23, 68.25, 44.55, 96.12, 393.4567, 2.45 };
        strings = new List<string> { "Hansi", "Pauli", "Heinzi", "Susi", "Pepi" };
        patients = new List<Patient>();
        patients.Add(new Patient { Firstname = "Hansi", Lastname = "Huber", Age = 66, Costs = 1513 });
        patients.Add(new Patient { Firstname = "Heinzi", Lastname = "Prüller", Age = 77, Costs = 3100 });
        patients.Add(new Patient { Firstname = "Susi", Lastname = "Maurer", Age = 55, Costs = 2460 });
        patients.Add(new Patient { Firstname = "Gerti", Lastname = "Lehner", Age = 55, Costs = 2941 });
        patients.Add(new Patient { Firstname = "Pauli", Lastname = "Huber", Age = 44, Costs = 1471 });

        Console.WriteLine(integers.MyCount());
        Console.WriteLine(integers.MyMax());
        Console.WriteLine(integers.MyMin());
        Console.WriteLine(integers.MySum());
        Console.WriteLine(integers.MyAvg());
        
        List<int> numbersGR70 = integers.MyWhere(x=>x>70);
        numbersGR70.MyPrintList();
        var L = strings.MyTake(2);
        L.MyPrintList();
        var S = strings.MySkip(2);
        S.MyPrintList();

        var Ii = integers.MyDistinct();
        Ii.MyPrintList();
        
        var rev = strings.MyReverse();
        rev.MyPrintList();
        List<int> li = new List<int>();
        Console.WriteLine(integers.MyFirst());
        //Console.WriteLine(li.MyFirst());
        Console.WriteLine(integers.MyElementAt(2));
        //Console.WriteLine(integers.MyElementAt(30));
        Console.WriteLine(integers.MyFirstorDefault());
        Console.WriteLine(li.MyFirstorDefault());
        List<int> integwhile = integers.MyTakeWhile(x => x < 140);
        integwhile.MyPrintList();
        List<int> integwhile1 = integers.MySkipWhile(x => x < 140);
        integwhile1.MyPrintList();
        List<string> ls = patients.MySelect(x => x.Firstname + " " + x.Lastname);
        ls.MyPrintList();
        //List<int> ins = integers.MyOrderBy(x,y:x < y);
    }
}