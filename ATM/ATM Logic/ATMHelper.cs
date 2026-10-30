using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ATM
{
    public static class ATMHelper
    {
        private static ATM atm;
        public static void setAtm(ATM outsideAtm) {
            atm = outsideAtm;
        }
        public static Person findPerson(string id)
        {
            Dictionary<String, Person> myDict = atm.getClients();
            if (myDict.ContainsKey(id)) return myDict[id];
            return null;
        }
        public static void login(string id)
        {
            atm.setCurrentCustomer(findPerson(id));
        }
        public static void exit()
        {
           atm.setCurrentCustomer(new Person());
        }
        public static Person getClient(string id)
        {
            return findPerson(id);
        }
        public static String generateId()
        {
            String newId = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                newId += randomNumber.ToString();
            }
            return newId;
        }
        
        
        public static bool searchCustomerAndSetIt(string id)
        {
            Person p = findPerson(id);
            String password = "";
            int attempts = 3;
            if (p == null) return false;
            do
            {
                Console.WriteLine("What's your Password?");
                password = Console.ReadLine();
                if (p.getAccount().checkPassword(password))
                {
                    atm.setCurrentCustomer(id);
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Incorect password, you have {attempts} more attempts");
                }
            } while (attempts != 0);
            if (attempts == 0) return false;
            return true;
        }
        public static void createAccount(string id)
        {
            Console.WriteLine("Please insert your password");
            string password = Console.ReadLine();
            Account account = new Account(id, password);
            Person p = findPerson(id);
            p.setAccount(account);
        }
    }
}
