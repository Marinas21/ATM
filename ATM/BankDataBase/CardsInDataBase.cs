using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BankDataBase
{
    public static class CardsInDataBase
    {
        private static List<Card> cards = new List<Card>();
        public static void AddCard(Card card) {
            cards.Add(card);
        }
        public static Card GetCard(String cardNumber) {
        foreach(Card c in cards)
            {
                if (cardNumber.Equals(c.getCardNumber())) {
                    return c;
                }
            }
            return null;
        }
    }
}
