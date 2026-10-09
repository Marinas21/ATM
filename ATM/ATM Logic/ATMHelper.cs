using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ATM
{
    public class ATMHelper
    {
        private static ATM atm;
        public static  void setAtm(ATM atm) {
            atm = atm;
        }
        public static Person findPerson(string id)
        {
            foreach (Person person in atm.getClients())
            {
                if (person.isThisPersonsId(id))
                {
                    return person;
                }
            }
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
        public static void generateId(Person person)
        {
            String newId = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                newId += randomNumber.ToString();
            }
            person.setId(newId);
            Console.WriteLine($"Your Id is {newId}");
        }
        
        
        public static bool searchCustomerAndSetIt(string id)
        {
            foreach (Person p in atm.getClients())
            {
                if (p.getId() == id) { atm.setCurrentCustomer(id); return true; }
            }
            return false;
        }
        public static void createAccount(string id)
        {
            Console.WriteLine("Please insert your password");
            string password = Console.ReadLine();
            Account account = new Account(id, password);
        }
    }
}
