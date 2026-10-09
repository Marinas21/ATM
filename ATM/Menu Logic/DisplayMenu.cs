using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class DisplayMenu
    {
        public static void displayMenu(ATM atm)
        {
            Console.WriteLine("Hello, what can we do today for you?");
            Console.WriteLine("1- Create Account");
            Console.WriteLine("2- Login into the account");
            Console.WriteLine("3- Delete Account");
            Console.WriteLine("4 - Exit");
            chooseOption(atm);
        }
        private static void chooseOption(ATM atm)
        {
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Please insert your first name");
                    string fn = Console.ReadLine();
                    Console.WriteLine("Please insert your last name");
                    string sn = Console.ReadLine();
                    atm.addClient(fn, sn);
                    break;
                case "2":
                    Console.WriteLine("Please insert your id");
                    ATMHelper.searchCustomerAndSetIt(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Please insert your id");
                    atm.removeClient(Console.ReadLine());
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Please insert a valid option");
                    break;
            }
            displayMenu(atm);
        }
    }
}
