using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Введіть n1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть n2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть n3: ");
        int n3 = int.Parse(Console.ReadLine());

        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine("Найбільше число:" + n1);
        }
        else if (n2 > n1 && n2 > n3)
        {
            Console.WriteLine("Найбільше число:" + n2);
        }
        else if (n3 > n1 && n3 > n2)
        {
            Console.WriteLine("Найбільше число:" +n3);
        }
     else
        {
            Console.WriteLine("Це не є найбільшим числом");
        }
    }
    
}