using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.NewFolder
{
    public class Account
    {
        private decimal balance;
        private List<Card> cards;
        private string password;
        private string id;

        public Account(string id, string password) {
            this.id = id;
            this.password = password;
            balance = 0;
            cards = new List<Card>();
            Console.WriteLine("Account was created succesfully");
        }
        public void generateCard() {
            Console.WriteLine("Choose a PIN please");
            string pin = Console.ReadLine();
            Card card = new Card(pin);
            Console.WriteLine(card.ToString());
            cards.Add(card);
        }
        public Card searchCard(string cardNumber) {
            foreach (Card card in cards) {
                if (card.getCardNumber() == cardNumber) return card;
            }
            return null;
        }
        public decimal getTotalBalance() {
            decimal balance = 0;
            foreach (Card c in cards) {
                balance += c.getBalance();
            }
            return balance;
        }
        public bool checkPassword(String inputPassword)
        {
            if (inputPassword.Equals(password)) return true;
                return false;
        }
        public void getCardsInfo() { 
            foreach(var c in cards){
                Console.WriteLine(c.ToString());
            }
        }
    }
}
