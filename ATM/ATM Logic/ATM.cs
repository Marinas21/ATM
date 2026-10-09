using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    internal class ATM
    {
        private List<Person> clients;
        private Person currentCustomer;

        public ATM()
        {
            clients = new List<Person>();
        }
        public void login(string id) {
            currentCustomer = findPerson(id);
        }
        public void exit() {
            currentCustomer = null;
        }
        
        public void addClient(String firstName, String lastName) {
            Person person = new Person(firstName, lastName);
            clients.Add(person);
            generateId(person);
            createAccount(person.getId());
        }
        public void removeClient(string id) {
            clients.Remove(findPerson(id));
        }
        public Person getClient(string id) {
            return findPerson(id);
        }
        private void generateId(Person person)
        {
            String newId = "";
            Random random = new Random();
            for (int i = 0;i<10;i++)
            {
                int randomNumber = random.Next(0, 10);
                newId += randomNumber.ToString();
            }
            person.setId(newId);
            Console.WriteLine($"Your Id is {newId}");
        }
        private Person findPerson(string id){
            foreach (Person person in clients)
            {
                if (person.isThisPersonsId(id))
                {
                    return person;
                }
            }
            return null;
        }
        public void setCurrentCustomer(string id) {
            currentCustomer = findPerson(id);
        }
        public bool searchCustomerAndSetIt(string id) {
            foreach (Person p in clients) {
                if (p.getId() == id) {setCurrentCustomer(id); return true; }
            }
                return false;
        }
        private void createAccount(string id) {
            Console.WriteLine("Please insert your password");
            string password = Console.ReadLine();
            Account account = new Account(id,password);
        }
    }
}
