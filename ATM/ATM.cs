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
            displayMenu();
        }
        public void login(string id) {
            currentCustomer = findPerson(id);
        }
        public void exit() {
            currentCustomer = null;
        }
        private void displayMenu() {
            Console.WriteLine("Hello, what can we do today for you?");
            Console.WriteLine("1- Create Account");
            Console.WriteLine("2- Login into the account");
            Console.WriteLine("3- Delete Account") ;
            Console.WriteLine("4 - Exit");
            chooseOption();
        }
        private void chooseOption() {
            string option = Console.ReadLine();
            switch (option) {
                case "1":
                    Console.WriteLine("Please insert your first name");
                    string fn = Console.ReadLine();
                    string sn = Console.ReadLine();
                    addClient(fn, sn);
                    break;
                case "2":
                    Console.WriteLine("Please insert your id");
                    currentCustomer = findPerson(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Please insert your id");
                    removeClient(Console.ReadLine());
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Please insert a valid option");
                    break;
            }
        }
        public void addClient(String firstName, String lastName) {
            Person person = new Person(firstName, lastName);
            clients.Add(person);
            generateId(person);
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
    }
}
