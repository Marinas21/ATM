namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            DisplayMenu.displayMenu(atm);
        }
    }
}
