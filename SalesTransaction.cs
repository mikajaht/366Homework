namespace Homework_Template
{
    class SalesTransaction
    {
        private string name;
        private double salesAmount;
        private double commissionRate;
        private double commission;

        public SalesTransaction(string name, double salesAmount, double commissionRate)
        {
            Name = name;
            SalesAmount = salesAmount;
            CommissionRate = commissionRate;
            commission = salesAmount * commissionRate;
        }

        public SalesTransaction(string name, double salesAmount)
            : this(name, salesAmount, 0)
        {
        }

        public SalesTransaction(string name)
            : this(name, 0, 0)
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }

        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public double Commission
        {
            get { return commission; }
        }

        public static SalesTransaction operator +(SalesTransaction s1, SalesTransaction s2)
        {
            return new SalesTransaction("Total", s1.SalesAmount + s2.SalesAmount, 0);
        }
    }
}