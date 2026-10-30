using ATM.BankDataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Card
    {
        private string pin;
        private decimal balance;
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
        public decimal getBalance()
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
        public void AddBalance(decimal amount) {
            if (amount < 0)
            {
                Console.WriteLine("The amount can't be lower than 0!");
            }
            else{
                balance += amount;
            }
        }
        public bool RemoveBalance(decimal amount) {
            if (amount < 0) {
                Console.WriteLine("The amount can't be lower than 0!");
                return false;
            }
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
        public void DoPayment(Card card, decimal amount) {
            if (amount < 0) {
                Console.WriteLine("The amount can't be lower than 0!");
            }
            else
            try
            {
                if (card == null) {
                    throw new Exception("The card is invalid");
                }
                else if (RemoveBalance(amount)) {
                    card.AddBalance(amount);
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
