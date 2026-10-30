using ATM.BankDataBase;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ATM.Menu_Logic
{
    public static class CardMenu
    {
        public static void displayMenu(Card card)
        {
            Console.WriteLine("Welcome to the card Informations, what do you want to do");
            Console.WriteLine("1- Add balance");
            Console.WriteLine("2- Remove money");
            Console.WriteLine("3- Do a payment");
            Console.WriteLine("4- Check balance");
            Console.WriteLine("5 - Exit");
            chooseOption(card);
        }
        private static void chooseOption(Card card)
        {
            double amount = 0;
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    amount = GetDoubleInput();
                    card.AddBalance(amount);
                    break;
                case "2":
                    amount = GetDoubleInput();
                    card.RemoveBalance(amount);
                    break;
                case "3":
                    Card reciveCard = getCard();
                    amount = GetDoubleInput();
                    try{
                        card.DoPayment(reciveCard, amount); }
                    catch(Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "4":
                    Console.WriteLine($"This card's balance is {card.getBalance()}");
                    break;
                case "5":
                    break;
                default:
                    
                    break;
            }
            if (option != "5")
                displayMenu(card);
        }

        private static Double GetDoubleInput() {
            Console.WriteLine("What amount will you like to transfer?");
            return Double.Parse(Console.ReadLine());
        }
        private static Card getCard() {
            Console.WriteLine("Please insert the card information to which card you will like to transfer money");
            return CardsInDataBase.GetCard(Console.ReadLine());
        }
    }
}
