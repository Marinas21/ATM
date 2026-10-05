namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // clasa atm ca si controler
            //din clasa atm putem sa facem un client nou sau sa ne logam ca client
            //un client are un cont
            //un cont poate avea mai multe carduri
            //din cont putem sa vedem banii totali pe care ii avem, banii pe carduri pe care ii avem si sa facem transferuri intre carduri si plati
            //din carduri putem transfera bani catre alte alte carduri sau plati
            //tot in carduri putem depunde si retrage bani
            ATMHelper atm = new ATMHelper();
        }
    }
}
