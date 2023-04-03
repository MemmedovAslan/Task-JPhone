using System;
using Task;

namespace JPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardJPhone phone = new StandardJPhone("Aslan");

            phone.AddAccount("Vusal");
            Console.WriteLine();
            phone.AddAccount("Emin");
            Console.WriteLine();
            phone.AddAccount("Yusif");
            Console.WriteLine();

            phone.DeleteAccount("Emin");
            phone.DeleteAccount("Emin");
            phone.DeleteAccount("Emin");
            phone.DeleteAccount("Emin");

            Console.WriteLine("\n************************************\n");

            phone.PrintAllAccounts();
            Console.WriteLine();

            phone.Call("423456");
            Console.WriteLine();

            phone.PrintInfo();

        }
    }
}

    
