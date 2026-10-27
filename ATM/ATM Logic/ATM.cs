using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class ATM
    {
        private Dictionary<String, Person> clients;
        private Person currentCustomer;

        public ATM()
        {
            clients = new Dictionary<String, Person>();
            ATMHelper.setAtm(this);
        }

        public void addClient(String firstName, String lastName)
        {
            Person person = new Person(firstName, lastName);
            person.setId(ATMHelper.generateId());
            clients.Add(person.getId(), person);
            String message = person.ToString();
            Console.WriteLine(message);
            ATMHelper.createAccount(person.getId());
        }

        public void setCurrentCustomer(string id)
        {
            if (clients.ContainsKey(id))
                currentCustomer = clients[id];
        }
        public void setCurrentCustomer(Person p){
            if (p == null)
                currentCustomer = null;
            else
                currentCustomer = p;
        }
        public Dictionary<String, Person> getClients(){
            return clients;
        }
        public void removeClient(string id)
        {
            clients.Remove(id);
        }
        public Person getPerson() {
            return currentCustomer;
        }
    }
}
