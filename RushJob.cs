using System;

namespace Homework_Template
{
    class RushJob : Job
    {
        public const double FEE = 150;

        public RushJob(int num, string name, string desc, double hrs)
            : base(num, name, desc, hrs) { }

        public override double Price => base.Price + FEE;

        public override string ToString()
        {
            return base.ToString() + $" (Rush +{FEE:C2}) = {Price:C2}";
        }
    }
}