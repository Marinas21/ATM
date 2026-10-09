using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class ATMHelper
    {
        private ATM atm;
        public ATMHelper() {
            atm = new ATM();
            displayMenu();
        }

    }
}
