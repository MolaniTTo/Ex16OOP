using System;

namespace Ex16OOP
{
    public class PaymentCard
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public PaymentCard(double openingBalance)
        {
            Balance = openingBalance;
        }

        public override string ToString()
        {
            return "The card has a balance of " + Balance + " pounds";
        }

    }
}
