namespace Homework_Template
{
    class Sale
    {
        private int inventoryNumber;
        private decimal amount;
        private decimal taxOwed;

        public int InventoryNumber
        {
            get { return inventoryNumber; }
            set { inventoryNumber = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                CalculateTax();
            }
        }

        public decimal TaxOwed
        {
            get { return taxOwed; }
        }

        private void CalculateTax()
        {
            if (amount <= 100)
            {
                taxOwed = amount * 0.08m;
            }
            else
            {
                taxOwed = (100 * 0.08m) + ((amount - 100) * 0.06m);
            }
        }
    }
}