using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    internal class Account
    {
        private decimal balance;
        private List<Card> cards;
        private string password;
        private string id;

        public Account(string id, string password) {
            this.id = id;
            this.password = password;
            balance = 0;
            Console.WriteLine("Account was created succesfully");
        }
        public void generateCard() {
            Console.WriteLine("Choose a PIN please");
            string pin = Console.ReadLine();
            Card card = new Card(pin);
            cards.Add(card);
        }
    }
}
