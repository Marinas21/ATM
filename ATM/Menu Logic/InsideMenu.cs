using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Menu_Logic
{
    public static class InsideMenu
    {

        public static void displayMenu(Person p)
        {
            Console.WriteLine($"Hello, {p.getFullName()} what can we do today for you?");
            Console.WriteLine("1- Create a new card");
            Console.WriteLine("2- Check existing card");
            Console.WriteLine("3- Check total balance");
            Console.WriteLine("4- Check cards");
            Console.WriteLine("5 - Exit");
            chooseOption(p);
        }
        private static void chooseOption(Person p)
        {
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    p.createCard();
                    break;
                case "2":
                    Console.WriteLine("Please insert your cardNumber");
                    Card card = p.searchCard(Console.ReadLine());
                    if (card != null) {
                        Console.WriteLine("Please insert your pin number");
                        int attemps = 3;
                        while (attemps!=0) {
                            string pin = Console.ReadLine();
                            if (card.checkPin(pin)) {
                                card.ToString();
                                break;
                            }
                            attemps--;
                        }
                        if (attemps == 0)
                        {
                            Console.WriteLine("Your card is locked! Too many incorect inputs!");
                        }
                        else {
                            CardMenu.displayMenu(card);
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine($"Your total balance is {p.getBalance()}");
                    break;
                case "4":
                    p.getCardsInfo();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please insert a valid option");
                    break;
            }
            if (option != "5")
                displayMenu(p);
        }
    }
}
