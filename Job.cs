using System;

namespace Homework_Template
{
    class Job
    {
        private double hours;
        private double price;
        public const double RATE = 45.00;

        public int JobNumber { get; set; }
        public string CustomerName { get; set; }
        public string JobDescription { get; set; }

        public double Hours
        {
            get { return hours; }
            set
            {
                hours = value;
                price = hours * RATE;
            }
        }

        public virtual double Price
        {
            get { return price; }
        }

        public Job(int num, string name, string desc, double hrs)
        {
            JobNumber = num;
            CustomerName = name;
            JobDescription = desc;
            Hours = hrs;
        }

        public override bool Equals(object obj)
        {
            return obj is Job j && j.JobNumber == JobNumber;
        }

        public override int GetHashCode()
        {
            return JobNumber;
        }

        public override string ToString()
        {
            return $"Homework_Template.Job {JobNumber} {CustomerName} {JobDescription} {Hours} hours @{RATE:C2} per hour. Total price is {Price:C2}";
        }
    }
}