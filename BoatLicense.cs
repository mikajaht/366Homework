namespace Homework_Template
{
    class BoatLicense
    {
        private string licenseNum;
        private string state;
        private int motorSizeInHP;
        private decimal price;

        public string LicenseNum
        {
            get { return licenseNum; }
            set { licenseNum = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int MotorSizeInHP
        {
            get { return motorSizeInHP; }
            set
            {
                motorSizeInHP = value;
                CalculatePrice();
            }
        }

        public decimal Price
        {
            get { return price; }
        }

        private void CalculatePrice()
        {
            if (motorSizeInHP <= 50)
            {
                price = 25.00m;
            }
            else
            {
                price = 38.00m;
            }
        }
    }
}