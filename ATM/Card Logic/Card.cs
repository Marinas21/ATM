using ATM.BankDataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Card
    {
        private string pin;
        private double balance;
        private string cardNumber;
        private string expirationDate;

        public Card(string pin)
        {
            this.pin = pin;
            this.balance = 0;
            this.cardNumber = generateCardNumber();
            this.expirationDate = generateExpirationDate();
            CardsInDataBase.AddCard(this);
        }
        public string getCardNumber()
        {
            return cardNumber;
        }
        private string generateCardNumber()
        {
            String newCardNumber = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                newCardNumber += randomNumber.ToString();
            }
            return newCardNumber;
        }
        private string generateExpirationDate()
        {
            DateTime expiration = DateTime.Now.AddYears(4);
            return expiration.ToString("MM/yy");
        }
        public double getBalance()
        {
            return balance;
        }

        public void getCard(string cardNumber)
        {

        }
        public bool checkPin(string pin)
        {
            return pin == this.pin;
        }

        public string ToString() {
            return pin + " " + cardNumber + " " + expirationDate;
        }
        public void AddBalance(double amount) {
            balance += amount;
        }
        public bool RemoveBalance(double amount) {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else { 
            Console.WriteLine("The amount is greater than the balance");
            }
            return false;
        }
        public void DoPayment(Card card, double amount) {
            try
            {
                if (card == null) {
                    new Exception("The card is invalid");
                }
                if (RemoveBalance(amount)) {
                    card.AddBalance(amount);
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
