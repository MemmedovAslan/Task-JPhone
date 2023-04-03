using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class StandardJPhone
    {
        string name;
        int storage = 32;
        ArrayList accounts = new ArrayList();
        public StandardJPhone(string name)
        {
            this.name = name;
        }
        public void Call(string number)
        {
            if ((number.Length >= 6 && number.Length <= 8) && (number[0] == '4' || number[0] == '6'))
                Console.WriteLine($"  Calling to the number {number}");
            else
                Console.WriteLine("  Invalid phone number, please check the number!");
        }
        public void AddAccount(string name)
        {
            if (accounts.Count < 3)
            {
                accounts.Add(name);
                Console.WriteLine($"  +  Account {name} was added");
            }
            else
                Console.WriteLine("  You cannot add more accounts, limit is reached!");
        }
        public void PrintAllAccounts()
        {
            if (accounts.Count > 0)
            {
                Console.WriteLine("  Accounts are:");
                for (int i = 0; i < accounts.Count; i++)
                {
                    Console.WriteLine("  >  " + accounts[i]);
                }
            }
            else
                Console.WriteLine("  No user accounts to display");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"  JPhone is called ’{name} overpriced phone’, it has {storage}GB of memory and {accounts.Count} user accounts");
        }

        //Bonus
        public void DeleteAccount(string name)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i] == name)
                {
                    Console.WriteLine($"  -  {name} was deleted!");
                    break;
                }
                //else
                //{
                //    Console.WriteLine("  There is no account like that!");
                //    break;
                //}
            }
            accounts.Remove(name);
        }
    }
}
