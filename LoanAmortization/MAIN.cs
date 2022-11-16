using System;
using System.Windows.Forms;


namespace LoanAmortization
{
    public partial class MAIN : Form
    {
        decimal Selected = 0;
        decimal Total = 0;

        public MAIN()
        {
            InitializeComponent();
        }

        private void FillData(int Start) 
        {
            double Amount = Convert.ToDouble(AMO.Text);
            double Rate = Convert.ToDouble(RAT.Text);
            decimal Ratio = Convert.ToDecimal(INT_BOX.Text) / 100;
            int Months = Convert.ToInt32(MON.Text);

            Calculator C = new Calculator(Amount, Rate, Months, DAT.Value);
            for(int i = 0; i < C.Installments; i++)
            {
                int No = i + 1;
                string Date = C.LoanCurrentDate.ToString("dd / MM / yyyy");
                decimal Payment = C.Payment;
                decimal BeginingBalance = C.LoanAmount;
                decimal Principal = C.CalculatePrincipal();
                decimal Interest = C.CalculateInterest();
                if (i >= Start) Selected += Interest;
                Total += Interest;
                C.NextInstallment();
                decimal EndingBalance = C.LoanAmount;
                if (Start == No)
                {
                    decimal Item = Math.Round(Ratio * EndingBalance + EndingBalance, 2);
                    decimal Ins = No * Payment + 4100;
                    BAL.Text = EndingBalance.ToString();
                    REQ.Text = Item.ToString();
                    INS.Text = Ins.ToString();
                    COS.Text = (Item + Ins).ToString();
                }
                DGV.Rows.Add(new object[] { No, Date, BeginingBalance, Payment, Principal, Interest, EndingBalance });
            }
            SEL.Text = Selected.ToString();
            TTL.Text = Total.ToString();
        }

        private void CAL_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Selected = 0;
                Total = 0;
                DGV.Rows.Clear();
                int Start = Convert.ToInt32(SEL_STR.Text);
                FillData(Start);
            }
            catch
            {

            }
        }
    }
}
