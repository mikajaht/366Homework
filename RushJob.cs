using System;

namespace Homework_Template
{
    class RushJob : Job
    {
        public const double FEE = 150.00;

        public RushJob(int num, string name, string desc, double hrs)
            : base(num, name, desc, hrs)
        {
        }

        public override double Price
        {
            get { return base.Price + FEE; }
        }

        public override string ToString()
        {
            return $"Homework_Template.RushJob {JobNumber} {CustomerName} {JobDescription} {Hours} hours @{RATE:C2} per hour. Rush job adds {FEE:C2} premium. Total price is {Price:C2}";
        }
    }
}