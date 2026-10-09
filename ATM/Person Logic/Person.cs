using ATM.NewFolder;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ATM
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private Account account;
        private string id;
        public Person()
        {
        }
        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string getId() {
            return id;
        }
        public void setId(string id) {
            this.id = id;
        }
        public bool isThisPersonsId(string id) {
            if (this.id == id) return true;
            return false;
        }
        public void setAccount()
        {
            this.account = account;
        }
        public Account getAccount() {
            return account;

        }
        public Boolean hasAccount() {
            if (account != null) return true;
            return true;
        }
        public void deleteAccount() {
            account = null;
        }
    }
}
