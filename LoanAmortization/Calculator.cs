using System;

namespace LoanAmortization
{
    public enum Period
    {
        Monthly = 12,
        Quarterly = 4,
        Biannual = 2,
        Annual = 1
    }

    public class Calculator
    {
        public decimal LoanAmount { get; private set; }
        public decimal InterestRate { get; private set; }
        public decimal Payment { get; private set; }
        public Period InstallmentPeriod { private get; set; }
        public int Installments { get { return (int)InstallmentPeriod * LoanTermMonths / 12; } }
        public int LoanTermMonths { get; private set; }
        public int LoanTermYears { get { return LoanTermMonths / 12; } set { LoanTermMonths = value * 12; } }
        public DateTime LoanStartDate { get; private set; }
        public DateTime LoanCurrentDate { get; private set; }
        public DateTime LoanEndDate { get { return LoanStartDate.AddMonths(LoanTermMonths); } }

        public Calculator(double LoanAmount, double InterestRate, int LoanTermMonths, DateTime LoanStartDate)
        {
            this.LoanAmount = (decimal)LoanAmount;
            this.InterestRate = (decimal)InterestRate;
            this.LoanTermMonths = LoanTermMonths;
            this.LoanStartDate = LoanStartDate;
            this.LoanCurrentDate = LoanStartDate;
            this.InstallmentPeriod = Period.Monthly;
            this.Payment = CalculatePayment();
        }

        public decimal CalculatePayment()
        {
            decimal Payment = 0;

            if (LoanTermMonths > 0)
            {
                if (InterestRate != 0)
                {
                    decimal Rate = (InterestRate / (int)InstallmentPeriod) / 100;
                    decimal Factor = (Rate + (Rate / (decimal)(Math.Pow((double)Rate + 1, LoanTermMonths) - 1)));
                    Payment = (LoanAmount * Factor);
                }
                else Payment = (LoanAmount / LoanTermMonths);
            }
            return Math.Round(Payment, 2);
        }

        public decimal CalculateInterest()
        {
            decimal Rate = (InterestRate / (int)InstallmentPeriod) / 100;
            return Math.Round(LoanAmount * Rate, 2);
        }

        public decimal CalculatePrincipal()
        {
            return Math.Round(Payment - CalculateInterest(), 2);
        }

        public void NextInstallment()
        {
            int Months = 12 / (int)InstallmentPeriod;
            LoanCurrentDate = LoanCurrentDate.AddMonths(Months);
            LoanAmount -= CalculatePrincipal();
        }
    }
}
