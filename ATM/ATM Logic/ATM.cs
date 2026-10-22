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
        }

        public void addClient(String firstName, String lastName)
        {
            Person person = new Person(firstName, lastName);
            clients.Add(person.getId(), person);
            ATMHelper.generateId(person);
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
    }
}
