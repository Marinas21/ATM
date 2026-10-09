using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class ATM
    {
        private List<Person> clients;
        private Person currentCustomer;

        public ATM()
        {
            clients = new List<Person>();
        }

        public void addClient(String firstName, String lastName)
        {
            Person person = new Person(firstName, lastName);
            clients.Add(person);
            ATMHelper.generateId(person);
            ATMHelper.createAccount(person.getId());
        }

        public void setCurrentCustomer(string id)
        {
            currentCustomer = ATMHelper.findPerson(id);
        }
        public void setCurrentCustomer(Person p){
            if (p == null)
                currentCustomer = null;
            else
                currentCustomer = p;
        }
        public List<Person> getClients(){
            return clients;
        }
        public void removeClient(string id)
        {
            clients.Remove(ATMHelper.findPerson(id));
        }
    }
}
